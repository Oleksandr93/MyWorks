#include "Fraction.h"
using namespace std;

Fraction::Fraction(void)
{
}

Fraction::Fraction(int numerator, int denominator)
{
	this->numerator = numerator;
	this->denominator = denominator;
	cile = 0;
}
Fraction::~Fraction(void)
{
}

void Fraction::Fillfraction()
{
	cout << "Enter cily 4astuny: " << endl;
	cin >> cile;
	cin.ignore();
	cout << "Enter numerator: " << endl;
	cin >> numerator;
	cin.ignore();
	cout << "Enter denominator: " << endl;
	cin >> denominator;
	cin.ignore();
	if (denominator == 0)
	{
		cout << "Error !!! the value must be > or <" << endl;
	}
}


void Fraction::Prav()
{
	numerator += denominator*cile;
	cile = 0;
}

void Fraction::Neprav()
{
	while (true)
	{
		if (numerator > denominator)
		{
			numerator -= denominator;
			cile++;
		}
		else
		{
			break;
		}
	}
	for (int i = numerator; i >= 2; i--)
	{
		if (numerator%i == 0 && denominator%i == 0)
		{
			numerator /= i;
			denominator /= i;
		}
	}
}

void Fraction::Print()
{
	if (cile == 0 && numerator == 0)
	{
		cout << 0 << endl;
	}
	else if (cile != 0 && numerator == 0)
	{
		cout << cile << endl;
	}
	else if (cile == 0 && numerator != 0)
	{
		cout << numerator << "/" << denominator << endl;
	}
	else
	{
		cout << cile << " " << numerator << "/" << denominator << endl;
	}
}

Fraction& Fraction::operator+(Fraction& one)
{
	Fraction tmp = Fraction(0, 0);
	int first, second;
	first = numerator*one.denominator;
	second = one.numerator*denominator;
	tmp.numerator = first + second;
	tmp.denominator = denominator*one.denominator;
	tmp.Neprav();
	tmp.Print();
	return tmp;
}

Fraction& Fraction::operator-(Fraction& one)
{
	Fraction tmp = Fraction(0, 0);
	int first, second;
	first = numerator*one.denominator;
	second = one.numerator*denominator;
	tmp.numerator = first - second;
	tmp.denominator = denominator*one.denominator;
	tmp.Neprav();
	tmp.Print();
	return tmp;
}

Fraction& Fraction::operator*(Fraction& one)
{
	Fraction tmp = Fraction(0, 0);
	int first, second;
	tmp.numerator = numerator*one.numerator;
	tmp.denominator = denominator*one.denominator;
	tmp.Neprav();
	tmp.Print();
	return tmp;
}
Fraction& Fraction::operator /(Fraction& one)
{
	Fraction tmp = Fraction(0, 0);
	int first, second;
	tmp.numerator = numerator*one.denominator;
	tmp.denominator = denominator*one.numerator;
	tmp.Neprav();
	tmp.Print();
	return tmp;
}