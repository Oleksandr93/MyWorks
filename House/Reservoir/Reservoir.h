#pragma once
#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>

using namespace std;

class Reservoir
{
public:
	string Name;
	char * type;
	double Width;
	double Length;
	double MaxDepth;

	Reservoir();

	Reservoir(string name, double width, double length, double MaxDepth);

	void FillReservoir();

	void EstimationVolume();

	double Area();

	void Show();
};
