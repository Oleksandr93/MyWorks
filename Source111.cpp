#include <iostream>
#include <conio.h>
#include <ctime>
using namespace std;
//
//
///*1. �������� ������������(overload) ������� ��� ����������� ������ ������� (ax + b =0) �� ����������� (ax2+ b x + c =0) 
//�������.*/
//
////double res(double a, double b);
////double res(double a, double b, double c);
////
////
////void main()
////{
////	setlocale(LC_CTYPE, "ukr");
////	cout << "�1�1��� �1������ ax + b = 0 " << endl;
////	cout << "����1�� ��������[a, b]: ";
////
////	int x, y;
////	cin >> x >> y;
////	
////	cout << "\n" << "����'����: " << res(x, y) << endl;
////
////	cout << "\n=-=-=-=-=-=-=-=-=-=-=-=-=-</>-=-=-=-=-=-=-=-=-=-=-=-=-=" << endl;
////	cout << "��������� �1������ ax^2 + bx + c = 0 " << endl;
////	cout << "����1�� �������� [a, b, c]: ";
////
////	int a, b, c;
////	cin >> a >> b >> c;
////
////	cout << "����'����: " << res(a, b, c) << endl;
////
////	_getch();
////}
////
////double res(double a, double b)
////{
////	return (-b) / a;
////}
////double res(double a, double b, double c)
////{
////	double D;
////	D = (b*b) - 4 * a*c;
////
////	if (D < 0)
////		return -1;
////	else if (D == 0)
////		return (-b + sqrt(D)) / 2 * a;
////	else {
////		cout << (-b - sqrt(D)) / 2 * a;
////		return (-b + sqrt(D)) / 2 * a;
////	}
////}
//
//
///* 2. �������� ������ ������� ��� ������ �������� ��������  � ������������ �����. �������� ������� ������� ��������� ������ 
//�������� �������� ��� -1, ���� ������� �� ��������*/


template <typename T>
 int MyDigit(T arr[], const int size, T digit)
{
	
	 	for (int i = 0; i < size; i++)
	 	{
	 		if (digit == arr[i])
	 		{
				return i;
	 		
	 		}
	 	
	 	}
	 	return -1;
}
 void main()
 {
 	setlocale(LC_ALL, " ");
 	const int size = 10;
	int a[size] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
 	float b[size]={1.1,1.2,1.3,1.4,1.5, 1.6, 1.7, 1.8, 1.9, 2.0 };
 	char c[size]={'M','A','R','K','S', 'L', 'W', 'Q', 'F' };
 	for(int i=0; i<size; i++)
 	{
 		cout<<a[i]<<"\t"<<b[i]<<"\t"<<c[i]<<endl;
 	}
 	cout<<MyDigit(a,5,3)<<endl;
	cout <<MyDigit(b,5,28.5f) << endl;
	cout <<MyDigit(c,5,'A') << endl;
 }
