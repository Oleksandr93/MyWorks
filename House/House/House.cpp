#include "Flat.h"
#include "House.h"
#include <iostream>
#include <conio.h>
#include <string>
#include <iomanip>

using namespace std;


House::House()
{
	count = 0;
	flat = new Flat[count];
}

House::~House()
{

}

void House::AddFlat()
{
	Flat * t = new Flat[count + 1];
	for (int i = 0; i < count; i++)
	{
		t[i] = flat[i];
	}
	t[count].FillFlat();
	t = flat;
	count++;
}

void House::ShowHouse()
{
	int l;
	system("cls");
	cout << "Flat: " << endl;
	for (int i = 0; i < count; i++)
	{
		cout << "Number in data: " << "\t" << i + 1 << endl;
	}

	cout << "Enter flat number: ";
	cin >> l;
	flat[l - 1].ShowFlat();
	cout << endl;
}

