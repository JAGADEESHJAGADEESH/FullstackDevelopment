using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.BasicPrograms
{
    public static class PermutationCombination
    {
        // Permutations
        public static void Permute(string str, string prefix = "")
        {
            if (str.Length == 0)
            {
                Console.WriteLine(prefix);
                return;
            }
            for (int i = 0; i < str.Length; i++)
            {
                string rem = str.Substring(0, i) + str.Substring(i + 1);
                Permute(rem, prefix + str[i]);
            }
        }

        // Combinations
        public static void Combine(string str, int start = 0, string prefix = "")
        {
            for (int i = start; i < str.Length; i++)
            {
                string newPrefix = prefix + str[i];
                Console.WriteLine(newPrefix);
                Combine(str, i + 1, newPrefix);
            }
        }
    }

}
