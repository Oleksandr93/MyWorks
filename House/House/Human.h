#pragma once
#include <iostream>
#include <string>

using namespace std;

class Human
{
public:
	Human();
	Human(const Human &h);
	~Human();
	void FillHuman();
	void Show();
private:
	char * Name;
	char * SurName;
	int Age;
	int size;
};
