#pragma once
#include <iostream>
#include "../02-Queue/clsQueue.cpp"
using namespace std;

template <class T>
class clsStack : public clsQueue<T>
{
    // [1] Dynamic Array using pointer
    // [2] LinkedList Structure (doubly)
public:
    clsStack()
    {
    }

    void Push(T Item)
    {
        clsQueue<T>::DbLinkedList.InsertAtBigining(Item);
    }

    T Top()
    {
        return clsQueue<T>::Front();
    }

    T Bottom()
    {
        return clsQueue<T>::Back();
    }

    void InsertBottom(T Item)
    {
        clsQueue<T>::InsertBack(Item);
    }

    void InsertTop(T Item)
    {
        clsQueue<T>::InsertFront(Item);
    }
};