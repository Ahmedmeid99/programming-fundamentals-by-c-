//--------------
//    Array 
//--------------

using System.Collections;

static void HeaderSeaction(string title)
{
    Console.WriteLine("-------------------------");
    Console.WriteLine(title);
    Console.WriteLine("-------------------------");
}

static void SubSeaction(string subTitle)
{
    Console.WriteLine(subTitle);
}

static void PrintArrayOfNums(int[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}

static void PrintArrayOfStrings(string[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}


HeaderSeaction("\tDeclaring");
SubSeaction("[1]");
int[] arrOfNums = new int[5]; // prepare 5 cells in memory each one store int
arrOfNums[0] = 1;
arrOfNums[1] = 5;
arrOfNums[2] = 4;
arrOfNums[3] = 3;
arrOfNums[4] = 2;
PrintArrayOfNums(arrOfNums);


SubSeaction("[2]");
string[] arrayOfStrings = { "Ahmed", "Mohamed", "Eid", "Ali", "Hassan", "Adel" };
PrintArrayOfStrings(arrayOfStrings);


HeaderSeaction("\t Sorting");
Array.Sort(arrOfNums);
PrintArrayOfNums(arrOfNums);


HeaderSeaction("\t Search");
int index =Array.IndexOf(arrayOfStrings, "Mohamed");
Console.WriteLine(arrayOfStrings[index]);


HeaderSeaction("MultiDimensional");
int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.WriteLine(matrix[i,j]);
    }
}

HeaderSeaction("\t Copy");
int[] original = {1,2,3,4,5 };
int[] copy = new int[5];
Array.Copy(original, copy, original.Length); // change by refrence
PrintArrayOfNums(copy);



Console.WriteLine();
HeaderSeaction("\t BitArray");
BitArray bits1 = new BitArray(10);
Console.WriteLine("bits1" + BitArrayToString(bits1));

bool[] initial = { true, false, true, false, true, false, true, false };
BitArray bits2 = new BitArray(initial);
Console.WriteLine("bits2" + BitArrayToString(bits2));

byte[] initial2 = { 0xAA, 0x55 };
BitArray bits3 = new BitArray(initial2);
Console.WriteLine("bits3" + BitArrayToString(bits3));

BitArray bits4 = new BitArray(8);
bits4.Set(1,true);
bits4[3] = true;
Console.WriteLine("bits4" + BitArrayToString(bits4));

BitArray bits5 = new BitArray(8);
bits4.SetAll(true);
Console.WriteLine("bits5" + BitArrayToString(bits5));

Console.WriteLine(bits5.Length);

BitArray bits6 = new BitArray(new bool[]{ true, false, true, false }); 
BitArray bits7 = new BitArray(new bool[]{ true, true, true, false });

BitArray bitsAndResult = new BitArray(bits6);
bitsAndResult.And(bits7);
Console.WriteLine("And" + BitArrayToString(bitsAndResult));

BitArray bitsOrResult = new BitArray(bits6);
bitsOrResult.Or(bits7);
Console.WriteLine("Or" + BitArrayToString(bitsOrResult));

BitArray bitsNotResult = new BitArray(bits6);
bitsNotResult.Not();
Console.WriteLine("Not" + BitArrayToString(bitsNotResult));

BitArray bitsXorResult = new BitArray(bits6);
bitsXorResult.Xor(bits7);
Console.WriteLine("Xor" + BitArrayToString(bitsXorResult));



// ------------------------
static string BitArrayToString(BitArray bitArray)
{
    char[] chars = new char[bitArray.Length];
    for (int i = 0; i < bitArray.Length; i++)
    {
        chars[i] = bitArray[i] ? '1' : '0';
    }

    return new string(chars);
} 
// ------------------------










