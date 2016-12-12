#include "Overcoat.h"
#include <iostream>
#include <conio.h>


using namespace std;

Overcoat::Overcoat()
{
}

Overcoat::Overcoat(int otherprice, char * othertypeOvercoat, char * othermark)
{
	this->price = otherprice;
	this->typeOvercoat = othertypeOvercoat;
	this->mark = othermark;
}

Overcoat::~Overcoat()
{
}

void Overcoat::FillOvercoat()
{
	cout << "Enter Overcoat type: " << endl;
	gets(typeOvercoat);
	cout << "Enter Overcoat mark: " << endl;
	gets(mark);
	cout << "Enter Overcoat price: " << endl;
	cin >> price;

}

void Overcoat::ShowOvercoat() const
{
	cout << "Overcoat type: " << typeOvercoat<< endl;
	cout << "Overcoat mark: " << mark << endl;
	cout << "Overcoat price: " << price << endl;
}

void Overcoat::ShowOvercoatPrice() const
{
	cout << "Price: " << price << endl;
}


char Overcoat::operator== (Overcoat &overcoat)
{
	if (typeOvercoat == overcoat.typeOvercoat)
		return 'Y';
	else
		return 'N';
}
Overcoat &Overcoat::operator= (Overcoat &overcoat1)
{
	this->price = overcoat1.price;
	return *this;
}
Overcoat &Overcoat::operator>(Overcoat &overcoat2)
{
	if (price > overcoat2.price)
		return overcoat2;
	else
		return *this;
}



