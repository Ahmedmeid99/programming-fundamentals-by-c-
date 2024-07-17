// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

void Header(string Title)
{
    Console.WriteLine("-----------------------------");
    Console.WriteLine($"-------{Title}--------");
    Console.WriteLine("-----------------------------");
}
void PrintCollection(IEnumerable<string> collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
}

void PrintSortedList(SortedList<string,int> collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine($"{item.Key} : {item.Value}");
    }
}
void PrintSortedDictionary(SortedDictionary<string, int> collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine($"{item.Key} : {item.Value}");
    }
}


//---------------------------------------
var sortedList = new SortedList<string, int>();
sortedList.Add("banana",4);
sortedList.Add("Apple",3);
sortedList.Add("Pear",1);


Header("SortedList");
PrintSortedList(sortedList);

//---------------------------------------
var sortedSet = new SortedSet<string>();
sortedSet.Add("banana");
sortedSet.Add("Apple" );
sortedSet.Add("Pear");


Header("SortedSet");
PrintCollection(sortedSet);

Console.WriteLine("----------------------");

var sSet = sortedSet.Where(i => i.Length > 4).Select(i => i.ToUpper());
PrintCollection(sSet);

//---------------------------------------
SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
sortedDictionary.Add("banana", 4);
sortedDictionary.Add("Apple", 3);
sortedDictionary.Add("Pear", 1);

Header("SortedDictionary");
PrintSortedDictionary(sortedDictionary);


//---------------------------------------







