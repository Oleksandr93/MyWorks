#pragma once
#include <iostream>
#include <string>
#include <iomanip>

using namespace std;
class Student
{
	string studentname;
	string studentsurname;
	string studentspecialization;

public:
	Student();

	Student(string studentname, string studentsurname, string studentspecialization);

	void FillStudent();

	void ShowStudent();


	const string GetName()const;

	void SetName(const string _name);

	const string GetSurName()const;

	void SetSurName(const string _surname);

	const string GetSpecialization()const;

	void SetSpecialization(const int spec);

};