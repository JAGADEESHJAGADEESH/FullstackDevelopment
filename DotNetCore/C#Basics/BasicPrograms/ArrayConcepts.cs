using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.BasicPrograms
{
    public static class ArrayConcepts
    {
        // Concatenate two arrays of integers and return the result and print them

        public static void ConcatenateIntArrays(int[] array1, int[] array2)
        {
            // Create a new array with the combined length of both arrays
            int[] result = new int[array1.Length + array2.Length];
            // Copy the first array into the result array
            Array.Copy(array1, result, array1.Length);
            // Copy the second array into the result array starting from the end of the first array
            Array.Copy(array2, 0, result, array1.Length, array2.Length);
            Console.WriteLine("Concatenated Integer Array: " + string.Join(", ", result));
        }
        public static void ConcatenateStringArrays(string[] array1, string[] array2)
        {
            // Create a new array with the combined length of both arrays
            string[] result = new string[array1.Length + array2.Length];
            // Copy the first array into the result array
            Array.Copy(array1, result, array1.Length);
            // Copy the second array into the result array starting from the end of the first array
            Array.Copy(array2, 0, result, array1.Length, array2.Length);
            Console.WriteLine("Concatenated string Array: " + string.Join(", ", result));
        }
        public static void GetDupicateValuesUsingLinq(List<string> items)
        {
            
            var duplicates = items
                .GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);

            foreach (var dup in duplicates)
            {
                Console.WriteLine(dup);
            }
        }

        public static void GetDupicateValuesUsingDictionary(List<string> items)
        {
            var counts = new Dictionary<string, int>();

            foreach (var item in items)
            {
                if (counts.ContainsKey(item))
                    counts[item]++;
                else
                    counts[item] = 1;
            }

            foreach (var pair in counts)
            {
                if (pair.Value > 1)
                    Console.WriteLine(pair.Key);
            }
        }

        public static void GetDupicateValuesUsingForLoop(List<string> items)
        {
            var printed = new List<string>();

            for (int i = 0; i < items.Count; i++)
            {
                for (int j = i + 1; j < items.Count; j++)
                {
                    if (items[i] == items[j] && !printed.Contains(items[i]))
                    {
                        Console.WriteLine(items[i]);
                        printed.Add(items[i]);
                        break;
                    }
                }
            }
        }

        public static void GetDupicateValuesUsingForEachLoop(List<string> items)
        {
            var printed = new List<string>();

            foreach (var item in items)
            {
                int count = 0;
                foreach (var compare in items)
                {
                    if (item == compare)
                        count++;
                }
                if (count > 1 && !printed.Contains(item))
                {
                    Console.WriteLine(item);
                    printed.Add(item);
                }
            }
        }
        // Using LINQ
        public static void PrintUniqueValuesWithLinq(List<string> items)
        {
            var unique = items.Distinct();
            foreach (var item in unique)
            {
                Console.WriteLine(item);
            }
        }

        // Using Dictionary
        public static void PrintUniqueValuesWithDictionary(List<string> items)
        {
            var dict = new Dictionary<string, bool>();
            foreach (var item in items)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = true;
                    Console.WriteLine(item);
                }
            }
        }

        // Using foreach (nested loops)
        public static void PrintUniqueValuesWithForeach(List<string> items)
        {
            var printed = new List<string>();
            foreach (var item in items)
            {
                bool isDuplicate = false;
                foreach (var p in printed)
                {
                    if (item == p)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Console.WriteLine(item);
                    printed.Add(item);
                }
            }
        }
    }
}

