#include <iostream>
using namespace std;

class Node
{
public:
    Node *Prev; // Prev Node Location
    int Value;  // Data
    Node *Next; // Next Node Location
};

void PrintLinkedListItems(Node *head)
{
    // NULL List
    if (head == NULL)
        cout << "This List is NULL\n";

    while (head != NULL)
    {
        // print its value
        cout << head->Value << " ";

        // transate to Next Node
        head = head->Next;
    }
    cout << endl;
}

// [/] InsertAtBigining()
// [/] InsertNodeAfter()
// [/] InsertAtEnd()
// [/] FindNode()
// [/] DeleteNode()
// [/] DeleteFirstNode()
// [/] DeleteLastNode()

void InsertAtBigining(Node *&head, int Value)
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
        return;
    }

    Node *Current_Node = head;     // First Node
    New_Node->Next = Current_Node; // [] -> 1
    Current_Node->Prev = New_Node; // [] <- 1
    head = New_Node;               // head => []
}

void InsertAtEnd(Node *&head, int Value)
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
}

void InsertNodeAfter(Node *&Prev_Node, int Value)
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
}

Node *FindNode(Node *&head, int Value)
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

void DeleteNode(Node *&head, Node *&NodeToDelete)
{
    if (head == NULL || NodeToDelete == NULL)
    {
        return;
    }

    if (head == NodeToDelete)
    {
        head = NodeToDelete->Next;
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
}

void DeleteFirstNode(Node *&head)
{
    Node *First_Node = head;
    if (First_Node == NULL)
    {
        return;
    }
    head = First_Node->Next;
    head->Prev = NULL;
    delete First_Node;
}

void DeleteLastNode(Node *&head)
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
}

int main()
{
    Node *head = NULL;

    // InsertAtBigining()
    InsertAtBigining(head, 5);
    InsertAtBigining(head, 4);
    InsertAtBigining(head, 3);
    InsertAtBigining(head, 2);
    InsertAtBigining(head, 1);

    PrintLinkedListItems(head);

    // InsertAtEnd()
    InsertAtEnd(head, 6);
    PrintLinkedListItems(head);

    // FindNode()
    Node *N3 = FindNode(head, 3);
    cout << "Find : " << N3->Value << endl;

    // InsertNodeAfter
    InsertNodeAfter(N3, 33);
    PrintLinkedListItems(head);

    // DeleteNode
    Node *N33 = FindNode(head, 33);
    DeleteNode(head, N33);
    PrintLinkedListItems(head);

    // DeleteFirstNode
    DeleteFirstNode(head);
    PrintLinkedListItems(head);

    // DeleteLastNode
    DeleteLastNode(head);
    PrintLinkedListItems(head);
    return 0;
};