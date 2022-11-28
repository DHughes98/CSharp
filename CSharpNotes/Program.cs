// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Data Types
// What is a statically typed language?
// You have to specify the type of variable or function you want to create
// Javascript
// var name = "Dillon";
//C#
string name = "Dillon";
int number = 7;
double dec = 3.14;
float floatvalue = 1.2f;
bool isTired = true;

// Lists and Dictionaries
// Array and List
// Arrays are fixed length
string[] groceryList = new string[4];
// [null, null, null, null]
string[] groceryList2 = {"Carrots", "Turkey", "Bread", "Milk"};

groceryList[2] = "Ham";
// null, null, Ham, null
Console.WriteLine(groceryList[2]);

//Size of an Array
Console.WriteLine(groceryList.Length);

// Lists are variable lenght 
List<int> numberList = new List<int>();
numberList.Add(3);
numberList.Add(3);
numberList.Add(4);
// Remove at the location index 3
// numberList.RemoveAt(3);
// First parameter is the index, second is the value
numberList.Insert(1,5);
// This removes the value of 3
numberList.Remove(3);
//Size of a List
Console.WriteLine(numberList.Count);

foreach (int i in numberList)  {
Console.WriteLine(i);
}


