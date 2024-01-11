#include <queue>
#include <iostream>
using namespace std;

template <typename T>
void Printqueue(queue<T> qucNumbers)
{
    while (!qucNumbers.empty())
    {
        // print top element
        cout << qucNumbers.front() << endl;

        // remove top element
        qucNumbers.pop();
    }
}

int main()
{
    queue<int> qucNumbers1;
    qucNumbers1.push(1);
    qucNumbers1.push(2);
    qucNumbers1.push(3);
    qucNumbers1.push(4);
    qucNumbers1.push(5);

    // queue
    // --------------------------
    //    1    2    3    4    5
    // --------------------------

    ///////////////

    // qucNumbers queue size
    cout << qucNumbers1.size() << endl;

    // top element in queue
    cout << qucNumbers1.front() << endl;

    // top element in queue
    cout << qucNumbers1.back() << endl;

    cout << "print queueNumber1 \n";
    Printqueue<int>(qucNumbers1);

    queue<int> qucNumbers2;
    qucNumbers2.push(6);
    qucNumbers2.push(7);
    qucNumbers2.push(8);
    qucNumbers2.push(9);
    qucNumbers2.push(10);

    qucNumbers1.swap(qucNumbers2);

    cout << "after swapping  \n";
    cout << "print queueNumber1 \n";
    Printqueue<int>(qucNumbers1);

    cout << "print queueNumber2 \n";
    Printqueue<int>(qucNumbers2);
}