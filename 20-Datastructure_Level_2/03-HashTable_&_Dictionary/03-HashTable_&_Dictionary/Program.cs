
using System.Collections;

// HasTable & Dictionary 

// ----------------------------------
// -----------[HasTable]-------------
// ----------------------------------

Hashtable hashtable = new Hashtable();
hashtable.Add("Key1", "value 1");
hashtable.Add("Key2", "value 2");
hashtable.Add("Key3", "value 3");

foreach(DictionaryEntry item in hashtable)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

hashtable.Remove("Key3");

foreach (DictionaryEntry item in hashtable)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}
Console.WriteLine(hashtable.Count);

// ----------------------------------
// ---------[Dictionary]-------------
// ----------------------------------

Dictionary<string, int> fruitBaskets = new Dictionary<string, int>();

fruitBaskets.Add("Apple", 12);
fruitBaskets.Add("Panana", 7);
fruitBaskets.Add("WaterMelon", 1);
fruitBaskets.Add("Pear", 6);

foreach (KeyValuePair<string, int> item in fruitBaskets)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

fruitBaskets.Remove("Pear");

foreach (KeyValuePair<string, int> item in fruitBaskets)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}










Console.WriteLine("---------------------------------");

Console.ReadKey();