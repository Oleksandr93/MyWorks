#include "Flat.h"
using namespace std;

Flat::Flat(void)
{
}

Flat::Flat(double area, double coast, int rooms)
{
	this->area = area;
	this->coast = coast;
	this->rooms = rooms;
}
Flat::~Flat(void)
{
}

void Flat::Fillflat()
{
	cout << "Enter area!" << endl;
	cin >> area;
	cin.ignore();
	cout << "Enter coast!" << endl;
	cin >> coast;
	cin.ignore();
	cout << "Enter count of rooms!" << endl;
	cin >> rooms;
	cin.ignore();
}


void Flat::Print()
{
	cout << "area= " << area << "coast= " << coast << "rooms= " << rooms;
}

Flat& Flat::operator =(Flat& one)
{
	this->area = one.area;
	this->coast = one.coast;
	this->rooms = one.rooms;
	return *this;
}

bool Flat::operator ==(Flat& one)
{
	if (area == one.area)
		return true;
	else
		return false;
}

Flat& Flat::operator >(Flat& one)
{
	if (coast>one.coast)
		return one;
	else
		return *this;
}
