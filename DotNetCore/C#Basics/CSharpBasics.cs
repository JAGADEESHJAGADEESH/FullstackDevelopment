namespace C_Basics
{
    public class CSharpBasics
    {
        public CSharpBasics()
        {
            int G;

            // Pass variable G to the method
            // using out keyword
            Sum(out G);

            // Display the value G
            Console.WriteLine("The sum of" +
                    " the value is: {0}", G);
            string str = "Geek";

            // Pass as a reference parameter
            SetValue(ref str);

            // Display the given string
            Console.WriteLine(str);
        }

        static void SetValue(ref string str1)
        {

            // Check parameter value
            if (str1 == "Geek")
            {
                Console.WriteLine("Hello!!Geek");
            }

            // Assign the new value
            // of the parameter
            str1 = "GeeksforGeeks";
        }
        // Method in which out parameter is passed
        // and this method returns the value of
        // the passed parameter
        public static void Sum(out int G)
        {
            G = 80;
            G += G;
        }
    }
}
