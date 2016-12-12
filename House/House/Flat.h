#pragma once
#include "Human.h"
#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

class Flat
{
public:
	Flat();
	~Flat();
	void FillFlat();
	void ShowFlat();



private:
	Human * h;
	int counter;
};