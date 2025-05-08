using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.ExtentionsMethods
{
    public static class NewMethodClass
    {
        // Extension method to reverse a string
        public static string ReverseString(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string InpuData(this int data)
        {
            if (data > 0)
                return $" input data is : {data}";

            else
                return new string("input data is less than 0");
        }
    }
}
