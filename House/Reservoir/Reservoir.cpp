#include "Reservoir.h"
#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

Reservoir::Reservoir()
{
	type = new char[20];
}

Reservoir::Reservoir(string name, double width, double length, double maxDepth)
{
	this->Name = name;
	this->Width = width;
	this->Length = length;
	this->MaxDepth = maxDepth;
}

void Reservoir::FillReservoir()
{
	cout << "Enter reservoir name: ";
	cin >> Name;
	cout << "Enter reservoir type: ";
	cin >> type;
	cout << "Enter Width: ";
	cin >> Width;
	cout << "Enter Length: ";
	cin >> Length;
	cout << "Enter MaxDepth: ";
	cin >> MaxDepth;
}

void Reservoir::EstimationVolume()
{
	double result;
	result = Width * Length * MaxDepth;
	cout << "Estimated Volume this reservoir: " << result << endl;
}

double Reservoir::Area()
{
	double result;
	result = Width * Length;
	cout << "Area of reservoir: " << result << endl;
	return result;
}

void Reservoir::Show()
{
	cout << "Name: " << Name << endl << "Type: " << type << endl << "Width: " << Width  << endl << "Length: " << endl << "MaxDepth: " << MaxDepth << endl;
}