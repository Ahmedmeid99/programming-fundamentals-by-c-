#include <iostream>
#include <vector>
#include "./clsString.cpp"

using namespace std;

int main()
{
    vector<string> vWords = {"ali", "ahmed", "mohamed"};
    clsString String_1;
    clsString String_2("Ahmed");

    String_1.SetValue("Ali ahmed eid");

    cout << String_1.GetValue() << endl;
    cout << String_2.GetValue() << endl;

    cout << String_1.CountWords() << endl;
    cout << clsString::CountWords("Abo eid", " ") << endl;
    cout << clsString::JoinWords(vWords, " ") << endl; // ali ahmed mohamed
    String_2.JoinWords(vWords);
    String_2.JoinWords(vWords);

    cout << String_2.GetValue() << endl; // ali ahmed mohamed

    return 0;
}