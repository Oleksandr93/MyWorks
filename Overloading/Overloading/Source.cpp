#include "Fraction.h"
#include <iostream>

using namespace std;

/* �������� ����� �����(��� ����������� ��� ����� ��������� ����). ��������� ���������� ���������� ���������� ��� ���� ��������������
�������� ��� ������ � �������(�������� +, -, *, /)*/


void main()
{
	Fraction one=Fraction (27, 5);
	Fraction two=Fraction(10,5);
	one+two;
	one-two;
	one*two;
	one/two;

	one=two;
	one.Print();
}