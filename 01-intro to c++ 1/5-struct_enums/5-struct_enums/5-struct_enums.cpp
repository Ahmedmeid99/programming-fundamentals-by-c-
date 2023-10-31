#include <iostream>
using namespace std;



//creat structure and enum

enum enColor { Red , Green , Blue };
enum enGander { Male , Female};

struct stAddrees
{
	string Street;
	string Id;
};

struct stContactInfo
{
	string Email;
	string Phone;
	stAddrees Addrees;
};

struct stPerson
{
	string FirstName;
	string LastName;
	stContactInfo ContactInfo;
	enColor Color;
	enGander Gander;
};



int main() {
	stPerson me;
	//me.FirstName = "Ahmed";
	//me.LastName = "Eid";
	//me.ContactInfo.Email = "ahmedalbakrycool@gmail";
	//me.ContactInfo.Phone = "01095814411";
	//me.ContactInfo.Addrees.Street = "2 abu eid street";
	//me.ContactInfo.Addrees.Id = "1231231231";
	//me.Color = enColor::Blue;  // 2
	//me.Gander = enGander::Male;

	//cout << me.FirstName << endl; // Ahmed
	//cout << me.Color; // 2

	cout << "Hello please enter your information to creat a card for you \n";
	cout << "whit is your first name? ";
	cin >> me.FirstName;
	cout << "whit is your last name? ";
	cin >> me.LastName;
	cout << "whit is your email? ";
	cin >> me.ContactInfo.Email;
	cout << "whit is your phone? ";
	cin >> me.ContactInfo.Phone;
	cout << "whit is your addrees street? ";
	cin >> me.ContactInfo.Addrees.Street;
	cout << "whit is your addrees id ";
	cin >> me.ContactInfo.Addrees.Id;
	////cout << "whit is your favaurit color? ";
	//cin >> me.Color;
	//cout << "whit is your Gander? \n";

	cout << "********************\n";
	cout << "FirstName: " << me.FirstName << endl;
	cout << "LastName: " << me.LastName << endl;
	cout << "Email: " << me.ContactInfo.Email << endl;
	cout << "Phone: " << me.ContactInfo.Phone << endl;
	cout << "Street: " << me.ContactInfo.Addrees.Street << endl;
	cout << "AddreesId: " << me.ContactInfo.Addrees.Id << endl;
	//cout << me.Color << endl;
	cout << "********************\n";

	return 0;
}