

using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace ProductService.Services
{
    public abstract class DBConnectionRepository<T>
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection;
            }
        }
        // Generic method to map database data to a model 
        public  T MapDataToModel<T>(IDataReader reader) where T : new()
        {
            T model = new T(); // Create an instance of the model

            // Get all properties of the model
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                // Check if the reader contains a column matching the property name
                if (reader.HasColumn(property.Name) && !reader.IsDBNull(reader.GetOrdinal(property.Name)))
                {
                    // Assign the value from the database to the property
                    property.SetValue(model, reader[property.Name]);
                }
            }

            return model;
        }

        // Generic method to execute a procedureName and return a list of models
        public  List<T> DBToListObject<T>(string procedureName, SqlParameter[] parameters) where T : new()
        {
            List<T> result = new List<T>();
            //try catch block to handle exceptions
            try
            {
                using (SqlDataReader reader = GetSqlDataReader(procedureName, parameters))
                {
                    while (reader.Read())
                    {
                        T model = MapDataToModel<T>(reader);
                        result.Add(model);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is closed
                SqlConnection connection = GetConnection();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return result;
        }

        //create a common method to get sqlreader using stored procedure and sqlparameters with try catch blocks
        public  SqlDataReader GetSqlDataReader(string procedureName, SqlParameter[] parameters = null)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection connection = GetConnection();
                SqlCommand command = new SqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (parameters != null && parameters.Any())
                {
                    command.Parameters.AddRange(parameters);
                }
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine($"Error: {ex.Message}");
            }
            return reader;
        }

        // Generic method to execute a storeprocedure and save data to the database using try catch

        public  int SaveDataToDB<T>(T objectToSave, string storedProcedure, SqlParameter[] parameters = null)
        {
            int result = 0;
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null && parameters.Any())
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    try
                    {
                        result = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
            return result;
        }
    }
    public static class DataReaderExtensions
    {
        public static bool HasColumn(this IDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
