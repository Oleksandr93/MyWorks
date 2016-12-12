#pragma once
#include <iostream>  
using namespace std;

class Complex
{
public:
	//Complex(double r, double i)																							
	//{
	//	this->re = r;
	//	this->im = i;
	//}   
	Complex(double r, double i) : re(r), im(i) {}
	Complex operator+(Complex &other) const;
	Complex operator-(Complex &other) const;
	void Display() const;
private:
	double re, im;
};