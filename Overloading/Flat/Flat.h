#pragma once
#include <iostream>
class Flat
{
	double area;
	double coast;
	int rooms;
public:
	Flat(void);
	Flat(double, double, int);
	~Flat(void);
	void Fillflat();
	void Print();
	Flat& operator =(Flat&);
	bool operator ==(Flat&);
	Flat& operator >(Flat&);
};

