#include <iostream>

using namespace std;

template <class T>
class clsDbLinkedList
{
protected:
    int _Size = 0;

public:
    class Node
    {
    public:
        Node *Prev; // Prev Node Location
        T Value;    // Data
        Node *Next; // Next Node Location
    };

    Node *_head = NULL;

    /////////////////////////////

    static void InsertAtBigining(Node *&head, T Value, int &Size)
    {
        // Creat Node
        Node *New_Node = new Node();
        New_Node->Prev = NULL;   // const
        New_Node->Value = Value; // const
        New_Node->Next = NULL;

        // Base case
        if (head == NULL)
        {
            head = New_Node;
            Size++;
            return;
        }

        Node *Current_Node = head;     // First Node
        New_Node->Next = Current_Node; // [] -> 1
        Current_Node->Prev = New_Node; // [] <- 1
        head = New_Node;               // head => []
        Size++;
    }

    void InsertAtBigining(T Value)
    {
        InsertAtBigining(_head, Value, _Size);
    }

    static void InsertAtEnd(Node *&head, T Value, int &Size)
    {
        // Creat Node
        Node *New_Node = new Node();
        New_Node->Prev = NULL;
        New_Node->Value = Value; // const
        New_Node->Next = NULL;   // const

        // Base case
        if (head == NULL)
        {
            head = New_Node;
            Size++;
            return;
        }

        Node *Last_Node = head;

        // find Last Node in LinkedList
        while (Last_Node->Next != NULL)
        {
            Last_Node = Last_Node->Next;
        }

        Last_Node->Next = New_Node; // 5 -> []
        New_Node->Prev = Last_Node; // 5 <- []
        Size++;
    }

    void InsertAtEnd(T Value)
    {
        InsertAtEnd(_head, Value, _Size);
    }

    static void InsertAfter(Node *&Prev_Node, T Value, int &Size)
    {

        // Creat Node
        Node *New_Node = new Node();
        New_Node->Prev = NULL;
        New_Node->Value = Value; // const
        New_Node->Next = NULL;

        // Base case
        if (Prev_Node == NULL)
        {
            Prev_Node = New_Node;
        }
        else
        {
            New_Node->Prev = Prev_Node;
            New_Node->Next = Prev_Node->Next;
            Prev_Node->Next = New_Node;
        }
        Size++;
    }

    void InsertAfter(Node *&Prev_Node, T Value)
    {
        InsertAfter(Prev_Node, Value, _Size);
    }

    bool InsertAfter(int index, T Value)
    {
        Node *N = GetNode(index);
        if (N != NULL)
        {
            InsertAfter(N, Value);
            return true;
        }
        return false;
    }

    static Node *FindNode(Node *&head, T Value)
    {
        Node *Current_Node = head;

        while (Current_Node != NULL)
        {
            if (Current_Node->Value == Value)
            {
                return Current_Node;
            }
            Current_Node = Current_Node->Next;
        }
        return NULL;
    }

    Node *FindNode(T Value)
    {
        return FindNode(_head, Value);
    }

    static void DeleteNode(Node *&head, Node *&NodeToDelete, int &Size)
    {
        Node *Current = head;
        if (Current == NULL || NodeToDelete == NULL)
        {
            return;
        }

        if (Current == NodeToDelete)
        {
            Current = NodeToDelete->Next;
        }

        if (NodeToDelete->Next != NULL)
        {
            NodeToDelete->Next->Prev = NodeToDelete->Prev;
        }

        if (NodeToDelete->Prev != NULL)
        {
            NodeToDelete->Prev->Next = NodeToDelete->Next;
        }

        delete NodeToDelete;
        Size--;
    }

    void DeleteNode(Node *&NodeToDelete)
    {
        DeleteNode(_head, NodeToDelete, _Size);
    }

    static void DeleteFirstNode(Node *&head, int &Size)
    {
        Node *First_Node = head;
        if (First_Node == NULL)
        {
            return;
        }
        head = First_Node->Next;
        head->Prev = NULL;
        delete First_Node;
        Size--;
    }

    void DeleteFirstNode()
    {
        DeleteFirstNode(_head, _Size);
    }

    static void DeleteLastNode(Node *&head, int &Size)
    {
        if (head == NULL)
        {
            return;
        }

        Node *Last_Node = head, *Prev_Node = head;
        while (Last_Node->Next != NULL)
        {
            Prev_Node = Last_Node;
            Last_Node = Last_Node->Next;
        }
        Prev_Node->Next = NULL;
        delete Last_Node;
        Size--;
    }

    void DeleteLastNode()
    {
        DeleteLastNode(_head, _Size);
    }

    static void PrintLinkedListItems(Node *head)
    {
        // NULL List
        Node *Current = head;
        if (Current == NULL)
            cout << "This List is NULL\n";

        while (Current != NULL)
        {
            // prT its value
            cout << Current->Value << " ";

            // transate to Next Node
            Current = Current->Next;
        }
        cout << endl;
    }

    int Size()
    {
        return _Size;
    }

    bool IsEmpty()
    {
        // return (_head == NULL);
        return (_Size == 0);
    }

    void Clear()
    {
        // Node *Current = _head;
        // while (Current != NULL)
        // {
        //     delete Current;
        //     Current = Current->Next;
        // }

        // _head = Current; // NULL
        // _Size = 0;

        while (_Size != 0)
        {
            DeleteFirstNode();
        }
    }

    static int GetNodeIndex(Node *head, Node *NodeToGetIndex)
    {
        Node *Current = head;
        int Count = 0;
        if (Current == NULL || NodeToGetIndex == NULL)
        {
            return -1;
        }

        while (Current != NULL)
        {
            if (Current->Value == NodeToGetIndex->Value)
            {
                break;
            }
            Current = Current->Next;
            Count++;
        }

        return Count;
    }

    int GetNodeIndex(Node *NodeToGetIndex)
    {
        return GetNodeIndex(_head, NodeToGetIndex);
    }

    Node *GetNode(int index)
    {
        Node *Current = _head;
        int Counter = 0;

        // Validation
        if (index > _Size || index < 0)
        {
            return NULL;
        }

        while (Counter != _Size - 1)
        {
            if (index == Counter)
            {
                break;
            }
            Current = Current->Next;
            Counter++;
        }
        return Current;
    }

    bool UpdateItem(int index, T Value)
    {
        Node *N = GetNode(index);
        if (N != NULL)
        {
            N->Value = Value;
            return true;
        }
        else
            return false;
    }

    T GetItem(int index)
    {
        Node *N = GetNode(index);
        if (N == NULL)
            return -1;
        else
            return N->Value;
    }

    static void Swap(Node *&Node1, Node *&Node2)
    {
        T Temp = Node1->Value;
        Node1->Value = Node2->Value;
        Node2->Value = Temp;
    }

    void Reverse()
    {
        int Counter = 0;
        int breakPoint = Size() / 2;

        while (Counter != breakPoint)
        {
            Node *N1 = GetNode(Counter);
            Node *N2 = GetNode(Size() - Counter - 1);
            Swap(N1, N2);
            Counter++;
        }
    }

    void PrintLinkedListItems()
    {
        PrintLinkedListItems(_head);
    }

    static void PrintNode(Node *Node)
    {
        cout << "<== " << Node->Value << " ==>\n";
    }
};