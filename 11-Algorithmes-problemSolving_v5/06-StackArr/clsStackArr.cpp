#pragma once
#include <iostream>
#include "../05-QueueArr/clsQueueArr.cpp"
using namespace std;

template <class T>
class clsStackArr : public clsQueueArr<T>
{
    // [1] Dynamic Array using pointer
    // [2] LinkedList Structure (doubly)
public:
    clsStackArr()
    {
    }

    void Push(T Item)
    {
        clsQueueArr<T>::DynamicArray.InsertAtBegining(Item);
    }

    T Top()
    {
        return clsQueueArr<T>::Front();
    }

    T Bottom()
    {
        return clsQueueArr<T>::Back();
    }

    bool InsertBottom(T Item)
    {
        return clsQueueArr<T>::InsertBack(Item);
    }

    bool InsertTop(T Item)
    {
        return clsQueueArr<T>::InsertFront(Item);
    }
};