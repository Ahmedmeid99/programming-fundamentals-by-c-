#pragma once
#include <iostream>
using namespace std;

template <class T>
class clsDynamicArray
{
private:
    int _Size = 0;

    static void _Swap(T &Item1, T &Item2)
    {
        T Temp = Item1;
        Item1 = Item2;
        Item2 = Temp;
    }

public:
    T *OriginalArray;
    T *TempArray;
    clsDynamicArray()
    {
        OriginalArray = new T[0];
    }
    clsDynamicArray(int Size)
    {
        OriginalArray = new T[Size];
        _Size = Size;
    }

    ~clsDynamicArray()
    {
        delete[] OriginalArray;
        _Size = 0;
    }

    bool setItem(int index, T value)
    {
        if (index <= _Size && index >= 0)
        {
            OriginalArray[index] = value;
            return true;
        }
        return false;
    }

    T GetItem(int index)
    {
        if (index >= _Size || index < 0)
            return NULL;

        return OriginalArray[index];
    }

    void PrintList()
    {
        for (int i = 0; i < _Size; i++)
        {
            cout << OriginalArray[i] << " ";
        }
        cout << "\n";
    }

    int Size()
    {
        return _Size;
    }

    bool IsEmpty()
    {
        return (_Size == 0);
    }

    void Clear()
    {
        _Size = 0;
        TempArray = new T[0];
        delete[] OriginalArray;
        TempArray = OriginalArray;
    }

    void Resize(int NewSize)
    { // resize 5 -> 2

        // validation
        if (NewSize < 0)
            NewSize = 0;

        TempArray = new T[NewSize];

        // to small size
        if (NewSize < _Size)
            _Size = NewSize;

        for (int i = 0; i < _Size; i++)
        {
            TempArray[i] = OriginalArray[i];
        }

        _Size = NewSize;

        delete[] OriginalArray;
        OriginalArray = TempArray;
    }

    void Reverse()
    {
        for (int i = 0; i < _Size / 2; i++)
        {
            // O (1/2 n)
            _Swap(OriginalArray[i], OriginalArray[_Size - i - 1]);
        }
    }

    int Find(T Value)
    {
        for (int i = 0; i < _Size; i++)
        {
            if (OriginalArray[i] == Value)
            {
                return i;
            }
        }
        return -1;
    }

    bool DeleteItemAt(int index)
    {
        if (index < 0 || index >= _Size)
        {
            return false;
        }

        _Size--;
        TempArray = new T[_Size];
        int shift = 0;
        for (int i = 0; i < _Size; i++)
        {
            if (index != i)
            {
                TempArray[i] = OriginalArray[(i + shift)];
            }
            else
            {
                shift++;
                TempArray[i] = OriginalArray[(i + shift)];
            }
        }

        delete[] OriginalArray;
        OriginalArray = TempArray;
        return true;
    }

    bool DeleteItem(T Value)
    {
        int ItemIndex = Find(Value);
        return DeleteItemAt(ItemIndex);
    }

    bool DeleteFirstItem()
    {
        return DeleteItemAt(0);
    }

    bool DeleteLastItem()
    {
        return DeleteItemAt(_Size - 1);
    }

    bool InsertAt(int index, T Value)
    {
        if (index < 0 || index > _Size)
            return false;

        _Size++;
        TempArray = new T[_Size];
        int Shift = 0;
        for (int i = 0; i < _Size; i++)
        {
            if (index != i)
            {
                TempArray[i] = OriginalArray[(i + Shift)];
            }
            else
            {
                Shift--;
                TempArray[i] = Value;
            }
        }

        delete OriginalArray;
        OriginalArray = TempArray;

        return true;
    }

    bool InsertAfter(int index, T Value)
    {
        return InsertAt(index + 1, Value);
    }
    bool InsertAtBegining(T Value)
    {
        return InsertAt(0, Value);
    }

    bool InsertAtEnd(T Value)
    {
        return InsertAt(_Size, Value);
    }
};