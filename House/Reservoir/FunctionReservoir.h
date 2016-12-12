#pragma once
#include "Reservoir.h"
#include <iostream>
#include <string>
#include <fstream>

using namespace std;

class FunctionReservoir
{
	Reservoir *r;
	int count;

public:
	FunctionReservoir();
	void FillReservoir();
	void AddReservoir();
	void ShowReservoir();
	void Volume();
	void Area1();
	void Comparison();
	void ComparisonArea();
	void InfoinFile();
	void SaveInfoFile();
};
