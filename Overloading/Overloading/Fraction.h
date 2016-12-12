#pragma once
#include <iostream>
class Fraction
{
	int numerator;
	int denominator;
	int cile;
public:
	Fraction(void);
	Fraction(int, int);
	~Fraction(void);
	void Fillfraction();
	void Print();
	void Prav();
	void Neprav();
	Fraction& operator +(Fraction&);
	Fraction& operator -(Fraction&);
	Fraction& operator *(Fraction&);
	Fraction& operator /(Fraction&);
};

