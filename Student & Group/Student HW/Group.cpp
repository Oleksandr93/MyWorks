#include "Student.h"
#include "Group.h"
#include <iostream>
#include <string>

using namespace std;

Group::Group()
{
	count = 0;
	st = new Student[count];
	this->marks = new int[count];
	this->NameOfGroup = new char[50];
}
void Group::FillStudentInGroupAdmins()
{
	cout << "Enter name of group: ";
	cin >> NameOfGroup;
	cout << "Enter count of student: ";
	cin >> count;
	st = new Student[count];
	for (int i = 0; i < count; i++)
	{
		st[i].FillStudent();
		cout << "Enter student final mark: ";
		cin >> marks[i];
	}
}
void Group::ShowStudentInGroupAdmins()
{
	cout << "Group name: " << NameOfGroup << endl;
	for (int i = 0; i < count; i++)
	{
		st[i].ShowStudent();
	}
}
void Group::GroupName()
{
	cout << NameOfGroup << endl;
}
double Group::MarksT()
{
	double sum = 0;
	double result = 0;
	for (int i = 0;i < count;i++)
	{
		sum += marks[i];
		result = sum / count;
	}
	return result;
}




Group2::Group2()
{
	count = 0;
	st = new Student[count];
	this->marks = new int[count];
	this->NameOfGroup = new char[50];
}
void Group2::FillStudentInGroup()
{
	cout << "Enter name of group: ";
	cin >> NameOfGroup;
	cout << "Enter count of student: ";
	cin >> count;
	st = new Student[count];
	for (int i = 0; i < count; i++)
	{
		st[i].FillStudent();
		cout << "Enter student final mark: ";
		cin >> marks[i];
	}
}
void Group2::ShowStudentinGroup()
{
	cout << "Group name: " << NameOfGroup << endl;
	for (int i = 0; i < count; i++)
	{
		st[i].ShowStudent();
	}
}
void Group2::GroupName()
{
	cout << NameOfGroup << endl;
}
double Group2::MarksP()
{
	double sum = 0;
	double result = 0;
	for (int i = 0; i < count; i++)
	{
		sum += marks[i];
		result = sum / count;
	}
	return result;
}
