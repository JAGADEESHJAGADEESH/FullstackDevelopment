// See https://aka.ms/new-console-template for more information
using C_Basics;
using C_Basics.ExtentionsMethods;
using C_Basics.Partial;
using System.Xml.Linq;
using static C_Basics.Delegates;


Console.WriteLine("Hello, World!");
Test test = new Test();

Console.WriteLine();


#region Extension methods
string original = "Hello, World!";
string reversed = original.ReverseString(); // Using the extension method
Console.WriteLine($"Original: {original}");
Console.WriteLine($"Reversed: {reversed}");

int testData = 10;
string testDataOutput = testData.InpuData(); // Using the extension method
Console.WriteLine($"Original: {testData}");
Console.WriteLine($"Reversed: {testDataOutput}");

#endregion

#region String Manipulation

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
//Task.Delay(10000).Wait();
Console.WriteLine();

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

