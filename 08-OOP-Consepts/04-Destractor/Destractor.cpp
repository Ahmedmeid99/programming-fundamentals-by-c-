#include <iostream>
using namespace std;

class clsAddress
{
private:
    string _StreetAddress_1;
    string _StreetAddress_2;
    string _POBox;
    string _ZipCode;

public:
    // constractor
    clsAddress(string StreetAddress_1, string StreetAddress_2, string POBox, string ZipCode)
    {
        _StreetAddress_1 = StreetAddress_1;
        _StreetAddress_2 = StreetAddress_2;
        _POBox = POBox;
        _ZipCode = ZipCode;
    }

    void SetStreetAddress_1(string StreetAddress_1)
    {
        _StreetAddress_1 = StreetAddress_1;
    }

    string StreetAddress_1()
    {
        return _StreetAddress_1;
    }

    void SetStreetAddress_2(string StreetAddress_2)
    {
        _StreetAddress_2 = StreetAddress_2;
    }

    string StreetAddress_2()
    {
        return _StreetAddress_2;
    }

    void SetPOBox(string POBox)
    {
        _POBox = POBox;
    }

    string POBox()
    {
        return _POBox;
    }

    void SetZipCode(string ZipCode)
    {
        _ZipCode = ZipCode;
    }

    string ZipCode()
    {
        return _ZipCode;
    }

    ~clsAddress()
    {
        cout << "From Constracotr" << endl;
    }
};

int main()
{
    clsAddress Address_1("street 1", "street 2", "123", "GFR-42617626");

    cout << Address_1.StreetAddress_1() << endl; // Street 1

    Address_1.SetStreetAddress_1("Street 123");
    
    cout << Address_1.StreetAddress_1() << endl; // Street 123    
    // From Constracotr
    return 0;
}