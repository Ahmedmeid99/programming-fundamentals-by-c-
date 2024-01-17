#pragma once
#include <iostream>
#include "../01-LinkedList-DB/clsDbLinkedList.cpp"
using namespace std;
// Push()
// Pop()
// Front()
// Back()
// Size()
// Print()
template <class T>
class clsQueue
{
    // [1] Dynamic Array using pointer
    // [2] LinkedList Structure (doubly)
protected:
    clsDbLinkedList<T> DbLinkedList;

public:
    clsQueue()
    {
    }

    void Push(T Item)
    {
        DbLinkedList.InsertAtEnd(Item);
    }

    void Pop()
    {
        DbLinkedList.DeleteFirstNode();
    }

    T Front()
    {
        return DbLinkedList.GetItem(0);
    }

    T Back()
    {
        return DbLinkedList.GetItem(DbLinkedList.Size() - 1);
    }

    int Size()
    {
        return DbLinkedList.Size();
    }

    void Print()
    {
        DbLinkedList.PrintLinkedListItems();
    }

    T GetItem(int index)
    {
        return DbLinkedList.GetItem(index);
    }

    void UpdateItem(int index, T Value)
    {
        DbLinkedList.UpdateItem(index, Value);
    }

    void InsertAfter(int index, T Value)
    {
        DbLinkedList.InsertAfter(index, Value);
    }

    void InsertBack(T Value)
    {
        DbLinkedList.InsertAtEnd(Value);
    }

    void InsertFront(T Value)
    {
        DbLinkedList.InsertAtBigining(Value);
    }

    void Reverse()
    {
        DbLinkedList.Reverse();
    }

    void Clear()
    {
        DbLinkedList.Clear();
    }
};