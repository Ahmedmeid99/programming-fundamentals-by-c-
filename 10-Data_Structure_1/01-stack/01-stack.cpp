#include <stack>
#include <iostream>
using namespace std;

template <typename T>
void PrintStack(stack<T> stacNumbers)
{
    while (!stacNumbers.empty())
    {
        // print top element
        cout << stacNumbers.top() << endl;

        // remove top element
        stacNumbers.pop();
    }
}

int main()
{
    stack<int> stacNumbers1;
    stacNumbers1.push(1);
    stacNumbers1.push(2);
    stacNumbers1.push(3);
    stacNumbers1.push(4);
    stacNumbers1.push(5);

    // stack
    //
    // |    5    |
    // |    4    |
    // |    3    |
    // |    2    |
    // |    1    |
    // -----------
    ///////////////

    // stacNumbers stack size
    cout << stacNumbers1.size() << endl;

    // top element in stack
    cout << stacNumbers1.top() << endl;
    cout << "print stackNumber1 \n";
    PrintStack<int>(stacNumbers1);

    stack<int> stacNumbers2;
    stacNumbers2.push(10);
    stacNumbers2.push(9);
    stacNumbers2.push(8);
    stacNumbers2.push(7);
    stacNumbers2.push(6);

    stacNumbers1.swap(stacNumbers2);

    cout << "after swapping  \n";
    cout << "print stackNumber1 \n";
    PrintStack<int>(stacNumbers1);

    cout << "print stackNumber2 \n";
    PrintStack<int>(stacNumbers2);
}