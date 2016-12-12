#include "Complex.h"
#include <iostream>

using namespace std;

Complex Complex::operator+(Complex &other) const
{
	return Complex(re + other.re, im + other.im);
}
Complex Complex::operator-(Complex &other) const
{
	return Complex(re - other.re, im - other.im);
}
 void Complex::Display() const
{ 
	cout << re << "  " << im << "i" << endl; 
}
