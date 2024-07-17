
void PrintHashSet(HashSet<int> hashSet)
{
    foreach (int item in hashSet)
    {
        Console.Write($"{item} ");
    }
    Console.Write("\n");
}

void breakLine()
{
    Console.Write("----------------------------------\n");
}

void SectionTitle(string title)
{
    if(title.Trim() == "")
        return;

    Console.Write("\n----------------------------------\n");
    Console.Write($"-------{title}--------\n");
    Console.Write("----------------------------------\n");
}

// ------------------------
// ------[HashSet]---------
// ------------------------


HashSet<int> numbers = new HashSet<int> () { 1, 1, 2, 3, 4, 4, 5 };

SectionTitle("Start With HashSet");
PrintHashSet(numbers);

numbers.Add(5);
numbers.Add(6);
numbers.Add(6);
PrintHashSet(numbers);


numbers.Remove(6);
PrintHashSet(numbers);

bool IsThereFounded = numbers.Contains(3);
Console.WriteLine("Is Number 3 Founded " + IsThereFounded);

Console.WriteLine("the Count is " + numbers.Count);

numbers.Clear();
PrintHashSet(numbers);
breakLine();

// -----------------------------------

HashSet<int> Set_1 = new HashSet<int>() { 1, 2, 3 };
HashSet<int> Set_2 = new HashSet<int>() { 3, 4, 5 };

Set_1.UnionWith(Set_2);

SectionTitle("Operations in HashSet");
PrintHashSet(Set_1);

Set_1.IntersectWith(Set_2);
PrintHashSet(Set_1);

Set_1.ExceptWith(Set_2);
PrintHashSet(Set_1);

Set_1.SymmetricExceptWith(Set_2);
PrintHashSet(Set_1);

breakLine();

HashSet<int> S_1 = new HashSet<int>() { 1, 2, 3 };
HashSet<int> S_3 = new HashSet<int>() { 1, 2, 3 };
HashSet<int> S_2 = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };

Console.WriteLine( "SetEquals " + S_1.SetEquals(S_3));        // true
Console.WriteLine( "IsSubsetOf " + S_1.IsSubsetOf(Set_2));    // true
Console.WriteLine( "IsSupersetOf " + S_2.IsSupersetOf(S_3));  // true
Console.WriteLine( "Overlaps " + S_1.Overlaps(S_2));          // true



Console.ReadKey();