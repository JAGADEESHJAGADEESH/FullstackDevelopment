// See https://aka.ms/new-console-template for more information
using C_Basics;
using C_Basics.AnnonymousMethods;
using C_Basics.BasicPrograms;
using C_Basics.ExtentionsMethods;
using C_Basics.OOPS.Abstraction;
using C_Basics.OOPS.Polymorphism;
using C_Basics.Partial;
using C_Basics.Reflection;
using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using static C_Basics.Delegates;


#region Partial Class Example

Console.WriteLine("           Partial class example            ");
Console.WriteLine("---------------------------------------------");
Test test = new Test();
Console.WriteLine("---------------------------------------------");

#endregion

#region OOPS

// Creating an instance of the abstract class
//Hotel hotel = new Hotel();
Console.WriteLine("                                 OOPS concept                                     ");
Console.WriteLine("----------------------------------------------------------------------------------");

Console.WriteLine(" \n                        Polymorphism  example                              ");
Console.WriteLine("                  ----------------------------------                  ");

OverrridingAndOverloading oops = new OverrridingAndOverloading();
oops.Draw(); // Calls the overridden method in OverrridingAndOverloading class
oops.DrawAShape(10, 20); // Calls the overridden method in OverrridingAndOverloading class
oops.TestMethod(); // Calls the TestMethod from OverrridingAndOverloading class

Console.WriteLine("---------------------------------------------");
#endregion

#region Interview basics 

Console.WriteLine(" \n                   Interview basics             ");
Console.WriteLine("-------------------------------------------------");


Console.WriteLine("string concatenation");
Console.WriteLine("---------------------   ");
var x = 10;
var y = "20";
var result = x + y;
Console.WriteLine(result);

Console.WriteLine("\n\ndifference between ToString() and Convert.ToString()");

// ToString() method 
int num = 123;
string str = num.ToString(); // "123"

object obj = null;
//string s = obj.ToString(); // ❌ NullReferenceException

// Convert.ToString() method
int num1 = 123;
string str1 = Convert.ToString(num1); // "123"

object obj1 = null;
string s1 = Convert.ToString(obj); // "" (no exception)


//string object iteration : check the count of any letter in the string
var userName = "Jagadeesh";
int charCount = 0;
foreach (var letter in userName)
{
    if (letter == 'e')
        charCount = charCount + 1;

}
Console.WriteLine(charCount);

//permutations and combinations

PermutationCombination.Permute("ABC");
Console.WriteLine("Combinations:");
PermutationCombination.Combine("ABC");

#endregion

#region Extension methods

Console.WriteLine("\n\n\n       Extension Methods             ");
Console.WriteLine("-------------------------------------");

Console.WriteLine("\n\n reverse a string and input data  ");
Console.WriteLine("-------------------------------------- ");

string original = "Hello, World!";
string reversed = original.ReverseString(); // Using the extension method
Console.WriteLine($"Original: {original}");
Console.WriteLine($"Reversed: {reversed}");



int testData = 10;
string testDataOutput = testData.InpuData(); // Using the extension method
Console.WriteLine($"Original: {testData}");
Console.WriteLine($"Reversed: {testDataOutput}");

// Creating an instance of the Geek class
Geek geek = new Geek();
geek.M1(); // Calling the original method
geek.M2(); // Calling the original method
geek.M3(); // Calling the original method

// Calling the extension method
geek.M4(); // Calling the extension method
geek.M5(); // Calling the extension method

#endregion

#region String Manipulation

Console.WriteLine("String manipulation example");
Console.WriteLine("------------------------------  ");

var name = "Jagadeesh Reddy Virupakshi";
var charList = new List<(char, int)>();
foreach (var character in name)
{
    var charItem = charList.FirstOrDefault(c => character == c.Item1);
    if (charItem != default)
    {
        var count = charItem.Item2 + 1;
        charList.Remove(charItem);
        charList.Add((character, count));
    }
    else
    {
        charList.Add((character, 1));
    }
}
charList = charList.OrderByDescending(c => c.Item2).ToList();
foreach (var item in charList)
{
    Console.WriteLine($"Character: {item.Item1}, Count: {item.Item2}");
}

name = "Jagadeesh Reddy Virupakshi";
Dictionary<char, int> letterCount = new Dictionary<char, int>();

foreach (char c in name)
{
    if (c != ' ')
    {
        if (letterCount.ContainsKey(c))
            letterCount[c]++;
        else
            letterCount[c] = 1;
    }
}

foreach (var pair in letterCount)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}


Console.WriteLine("-----------------------------------------------------------------");

#endregion

#region Delegates

Delegates del = new Delegates();

// instantiating the delegates
AddNumber del_obj1 = new AddNumber(del.Sum);
SubtractNumber del_obj2 = new SubtractNumber(del.Subtract);


// pass the values to the methods by delegate object
var sum = del_obj1(100, 40);
var subtraction = del_obj2(100, 60);

// These can be written as using
// "Invoke" method
// del_obj1.Invoke(100, 40);
// del_obj2.Invoke(100, 60);


#endregion

#region Anonymous Method Example

// Call the method to demonstrate anonymous features
AnnonymousClass.DemonstrateAnonymousFeatures();

#endregion

#region Reflection

//Reflection_Metadata.ReflectionMetadata();


var unsafeExample = new ReflectionExample();

var unsafeReflectionMethod = typeof(ReflectionExample).GetProperty("PrivateProperty", BindingFlags.Instance | BindingFlags.NonPublic);

Console.WriteLine(unsafeReflectionMethod); // outputs Unsafe Name


#endregion

#region HashSet

var words = new HashSet<string>();
words.Add("Jagadeesh");
words.Add("is");
words.Add("is");

Console.WriteLine(words.SelectMany(s=> s));

#endregion

#region Array Concepts
int[] array1 = { 1, 2 };
int[] array2 = { 3, 4 };
ArrayConcepts.ConcatenateIntArrays(array1, array2);

#endregion

#region Ref and Out Keywords

RefAndOutKeyWords refAndOutKeyWords = new RefAndOutKeyWords();

#endregion
