#include "Human.h"
#include "Flat.h"
#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

Flat::Flat()
{
	counter = 0;
	h = new Human[counter];
}

Flat::~Flat()
{

}

void Flat::FillFlat()
{
	cout << "Enter counter of Human: ";
	cin >> counter;
	h = new Human[counter];
	for (int i = 0; i < counter; i++)
	{
		h[i].FillHuman();
	}
}

void Flat::ShowFlat()
{
	cout << "Human name:\t " << "Human SurName:\t " << "Human Age: " << endl;
	for (int i = 0; i < counter; i++)
	{
		h[i].Show();
	}
}

