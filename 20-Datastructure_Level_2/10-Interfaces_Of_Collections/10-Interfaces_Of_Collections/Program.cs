using System;
using System.Collections;
using System.Collections.Generic;
using _10_Interfaces_Of_Collections;
// -----------------------------
// -- Interfaces of Collections
// -----------------------------
// - IEnumerable   (iteration)    
// - ICollection   (Add,Remove,Clear)             :IEnumerable
// - IList         (Index,Insert,RemoveAt)        :ICollection
// - IDictionary   (Key,Value Paire)              :ICollection
// - ISet          (Union,differnt,interSection)  
// - ICompareable  (handle Object in Collection)
// --------------------------------------------------------------


//-------------------------------------
var simpleCollection = new SimpleCollection<int>();
simpleCollection.Add(1);
simpleCollection.Add(2);
simpleCollection.Add(3);


foreach (var item in simpleCollection )
{
    Console.WriteLine(item);
}
//-------------------------------------

CustomCollection<string> shoppingCart = new CustomCollection<string>();
shoppingCart.Add("Apple");
shoppingCart.Add("Banana");
shoppingCart.Add("Carrot");


Console.WriteLine($"Items in cart: {shoppingCart.Count}");

if (shoppingCart.Contains("Banana"))
{
    shoppingCart.Remove("Banana");
    Console.WriteLine("Banana removed from the cart.");
}


Console.WriteLine("Final items in the cart:");
foreach (var item in shoppingCart)
{
    Console.WriteLine(item);
}

// -------------------------------------
CustomList<string> myList = new CustomList<string>();
myList.Add("First");
myList.Add("Second");
myList.Insert(1, "Inserted");


Console.WriteLine("List after adding and inserting:");
foreach (var item in myList)
{
    Console.WriteLine(item);
}


myList.RemoveAt(1); // Removes "Inserted"
myList[0] = "Updated First"; // Update the first item


Console.WriteLine("\nList after removing and updating:");
foreach (var item in myList)
{
    Console.WriteLine(item);
}
// ---------------------------------------
// Create an instance of CustomDictionary
var myDictionary = new CustomDictionary<int, string>();


// Adding elements to the dictionary
myDictionary.Add(1, "One");
myDictionary.Add(2, "Two");
myDictionary.Add(3, "Three");


// Accessing an element by key
Console.WriteLine($"Element with key 2: {myDictionary[2]}");


// Updating an element by key
myDictionary[2] = "Two Updated";
Console.WriteLine($"Updated element with key 2: {myDictionary[2]}");


// Iterating over the dictionary
Console.WriteLine("\nIterating over the dictionary:");
foreach (var kvp in myDictionary)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}


// Demonstrate the ContainsKey and Remove functionality
if (myDictionary.ContainsKey(3))
{
    Console.WriteLine("\nContains key 3, removing...");
    myDictionary.Remove(3);
}

// Display the dictionary after removal
Console.WriteLine("\nDictionary after removing key 3:");
foreach (var kvp in myDictionary)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

// --------------------------------------------

List<Person> people = new List<Person> // Person come from CustomList cs file 
{
    new Person { Name = "John", Age = 30 },
    new Person { Name = "Jane", Age = 25 },
    new Person { Name = "Doe", Age = 28 },
};


people.Sort();





