using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

void SectionHeader(string title)
{
    Console.WriteLine("-------------------------");
    Console.WriteLine($"[{title}]");
    Console.WriteLine("-------------------------");
}

//-------------------------
//------[ArrayList]--------
//-------------------------
// - Its contain  items have diffrent types 
SectionHeader("       ArrayList      ");
ArrayList arrayList = new ArrayList();

arrayList.Add(1);
arrayList.Add("Ahmed");
arrayList.Add(true);

for(int i=0; i< arrayList.Count; i++)
{
    Console.WriteLine(arrayList[i]);
}

Console.WriteLine("-------------------------");
ArrayList nums = new ArrayList() {1,8,2,2,7,2,3,4,5,6 };

Console.WriteLine(nums.Cast<int>().Min());
Console.WriteLine(nums.Cast<int>().Max());
Console.WriteLine(nums.Cast<int>().Sum());

Console.WriteLine(nums.Cast<int>().Count(num=> num == 2)); // 3

// sort
nums.Sort();

foreach (var item in nums)
{
    Console.WriteLine(item);
}


SectionHeader("  Observable Collection  ");

ObservableCollection<string> names = new ObservableCollection<string>();

// subscripe to access changes
names.CollectionChanged += ItemsChangedCollection;

names.Add("Ahmed");
names.Add("Mohmed");
names.Add("Eid");
names.Add("Ali");
names.Add("Hassan");

foreach (string item in names)
{
    Console.WriteLine(item);
}
names.Remove("Ali");

names[1] = "Mohammed";

names.Move(0, 2);

void ItemsChangedCollection(object sender,System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine("\n collection Changed \n"); // 
    switch (e.Action)
    {
        case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
            Console.WriteLine("Added");
            foreach (var item in e.NewItems)
            {
                Console.WriteLine($"- {item}");
            }
            break;
        case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
            Console.WriteLine("Removed");
            foreach (var item in e.OldItems)
            {
                Console.WriteLine($"- {item}");
            }
            break;
        case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
            Console.WriteLine("Replace");
            foreach (var item in e.OldItems)
            {
                Console.Write($"- {item} Replaced by");
            }
            foreach (var item in e.NewItems)
            {
                Console.Write($" {item} \n");
            }
            break;
        case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
            break;
        case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
            break;
        default:
            break;
    }
}







Console.ReadKey();
