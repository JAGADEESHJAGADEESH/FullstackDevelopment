using System.Reflection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.Reflection
{
    public static class Reflection_Metadata
    {
        public static void ReflectionMetadata()
        {
            Assembly executing = Assembly.GetExecutingAssembly();

            // Array to store types of the assembly
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                // Display each type
                Console.WriteLine("Class : {0}", item.Name);

                // Array to store methods
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method
                    Console.WriteLine("--> Method : {0}", method.Name);

                    // Array to store parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }
            Console.WriteLine();
            Thread.Sleep(10000);
        }
    }
}
        

    


