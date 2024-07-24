using System.Collections;
using System.Collections.Generic;
void SectionHedaer (string title)
{
    Console.WriteLine("----------------------");
    Console.WriteLine(title);
    Console.WriteLine("----------------------");
}

void PrintJaggedArray(int[][] jaggedArray)
{
    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            Console.Write(jaggedArray[i][j]);
        }
        Console.WriteLine();
    }
}

SectionHedaer("Jagged Array");

int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[]{ 1,2,3};
jaggedArray[1] = new int[] { 4,5,6,7,8};
jaggedArray[2] = new int[] { 9,10};

PrintJaggedArray(jaggedArray);

PrintJaggedArray(jaggedArray.Select(arr => arr.Select(num => num * 2).ToArray()).ToArray());
PrintJaggedArray(jaggedArray.Select(arr => arr.Where(num => num % 2 == 0).ToArray()).ToArray());

// -----------------------------

SectionHedaer("\t  Tuple"); 
// used for basic data record
Tuple<string, int, bool> person = new Tuple<string, int, bool>("Ahmed", 26, true);

Tuple<string, int, bool> Getperson()
{
    return person;
}

Tuple<string, int, bool> Returnedperson = Getperson();

 Console.WriteLine(Returnedperson.Item1);
 Console.WriteLine(Returnedperson.Item2);
 Console.WriteLine(Returnedperson.Item3);

