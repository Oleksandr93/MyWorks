#pragma once
#include "Flat.h"
#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

class House 
{
public:
	Flat * flat;
	Flat k;
	int count;
	House();
	~House();
	void AddFlat();
	void ShowHouse();


private:

};