#include "Human.h"
#include <iostream>
#include <istream>
#include <iomanip>
#include <conio.h>
#include <string>

using namespace std;

Human::Human()
{
	size = 50;
	Name = new char[size];
	SurName = new char[size];
	Age = 0;
}

Human::Human(const Human &h)
{
	this->size = h.size;
	this->Name = new char[h.size];
	for (int i = 0; i < size; i++)
	{
		Name[i] = h.Name[i];
	}
}

Human::~Human()
{

}

void Human::FillHuman()
{
	cout << "Enter Name: " << endl;
	cin >> Name;
	cout << "Enter SurName: " << endl;
	cin >> SurName;
	cout << "Enter Age: " << endl;
	cin >> Age;
}

void Human::Show()
{
	cout << "Human Name: " << Name << endl;
	cout << "Human SurName: " << SurName << endl;
	cout << "Human Age: " << Age << endl;
}

