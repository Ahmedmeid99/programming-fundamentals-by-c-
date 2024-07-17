using System.Collections.Generic;

void SevtionHeader(string title)
{
    Console.WriteLine("--------------------------");
    Console.WriteLine($"{title}");
    Console.WriteLine("--------------------------");
}

SevtionHeader("\t  Stack");
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

Console.WriteLine(stack.Peek());

foreach (int item in stack)
{
    Console.WriteLine(item);
}

stack.Pop();

foreach (int item in stack)
{
    Console.WriteLine(item);
}

stack.Clear();

//-------------------------------------
SevtionHeader("\t  Queue");
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

Console.WriteLine(queue.Peek());

foreach (int item in queue)
{
    Console.WriteLine(item);
}

queue.Dequeue();

foreach (int item in queue)
{
    Console.WriteLine(item);
}

queue.Clear();

//-------------------------------------
SevtionHeader("  LinkedList");

LinkedList<int> list = new LinkedList<int>();
list.AddLast(1);
list.AddLast(2);
list.AddLast(3);
list.AddLast(4);
list.AddLast(5);

foreach (var item in list)
{
    Console.WriteLine(item);
}

list.Remove(1);

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine(list.First);
Console.WriteLine(list.Last);

list.Clear();








Console.WriteLine("Hello, World!");
Console.ReadKey();
