#include "Student.h"
#include "Group.h"
#include <iostream>
#include <string>

using namespace std;

Student::Student()
{

}
Student::Student(string Name, string Surname, string Specialization)
{
	this->studentname = Name;
	this->studentsurname = Surname;
	this->studentspecialization = Specialization;
}
void Student::FillStudent()
{
	cout << "Enter name: ";
	cin >> studentname;
	cout << "Enter surname: ";
	cin >> studentsurname;
	cout << "Enter specialization: ";
	cin >> studentspecialization;
}
void Student::ShowStudent()
{
	cout << "Student specialization: " << studentspecialization << endl;
	cout << "Student name: " << studentname << endl;
	cout << "Student surname: " << studentsurname << endl;
}

const string Student::GetName()const
{
	return studentname;
}
void Student::SetName(const string _name)
{
	studentname = _name;
}
const string Student::GetSurName()const
{
	return studentsurname;
}
void Student::SetSurName(const string _surname)
{
	studentsurname = _surname;
}
const string Student::GetSpecialization()const
{
	return studentspecialization;
}
void Student::SetSpecialization(const int spec)
{
	studentspecialization = spec;
}