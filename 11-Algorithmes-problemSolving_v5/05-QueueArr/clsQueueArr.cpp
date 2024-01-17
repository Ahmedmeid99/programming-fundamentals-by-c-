#pragma once
#include <iostream>
#include "../04-DynamicArray/clsDynamicArray.cpp"
using namespace std;
// Push()
// Pop()
// Front()
// Back()
// Size()
// Print()
template <class T>
class clsQueueArr
{
    // [1] Dynamic Array using pointer
    // [2] LinkedList Structure (doubly)
private:
protected:
    clsDynamicArray<T> DynamicArray;

public:
    void Push(T Item)
    {
        DynamicArray.InsertAtEnd(Item);
    }

    void Pop()
    {
        DynamicArray.DeleteFirstItem();
    }

    T Front()
    {
        return DynamicArray.GetItem(0);
    }

    T Back()
    {
        return DynamicArray.GetItem((DynamicArray.Size() - 1));
    }

    int Size()
    {
        return DynamicArray.Size();
    }

    void Print()
    {
        DynamicArray.PrintList();
    }

    T GetItem(int index)
    {
        return DynamicArray.GetItem(index);
    }

    bool UpdateItem(int index, T Value)
    {
        // delete
        DynamicArray.setItem(index, Value);
        return false;
    }

    bool InsertAfter(int index, T Value)
    {
        return DynamicArray.InsertAfter(index, Value);
    }

    bool InsertBack(T Value)
    {
        return DynamicArray.InsertAtEnd(Value);
    }

    bool InsertFront(T Value)
    {
        return DynamicArray.InsertAtBegining(Value);
    }

    void Reverse()
    {
        DynamicArray.Reverse();
    }

    void Clear()
    {
        DynamicArray.Clear();
    }
};