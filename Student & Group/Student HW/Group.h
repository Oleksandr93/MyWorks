#pragma once
#include "Student.h"
#include <iostream>
#include <string>

using namespace std;

class Group
{
	Student * st;
	int count;
	int *marks;
	char *NameOfGroup;
public:
	Group();

	void FillStudentInGroupAdmins();

	void ShowStudentInGroupAdmins();

	void GroupName();

	double MarksT();
};


class Group2
{
	Student * st;
	int count;
	int * marks;
	char * NameOfGroup;
public:
	Group2();

	void FillStudentInGroup();

	void ShowStudentinGroup();

	void GroupName();

	double MarksP();

};







