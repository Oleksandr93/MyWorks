#include <iostream>
#include <conio.h>
#include <stdio.h>
#include <stdlib.h>
#include <ctime>
using namespace std;

int main()
{
	// 1. ������ � ��������� ����� 7 �����. ������� �������� ������ � ������� � ���������� �������. ������ ������� �������� ������, �� ����� 3.

	/*const int n = 7;

	int arr[n], counter = 0;

	for (int i = 0; i < n; i++)
	{
	cin >> arr[i];
	if(!(arr[i]%3))
	{
	counter++;
	}
	}

	for(int i = 0; i < n; i++)
	{
	cout << arr[i] << "\t";
	}
	cout << endl;
	for (int  i = n - 1;  i >= 0; i--)
	{
	cout << arr[i]<< "\t";
	}
	cout << endl;
	cout << counter << endl;*/



	// 2. ���� ����������� �����. ������� �� �䒺�� �������� �� ��������

	//const int n = 10;

	//int array[n];

	//for(int i = 0; i < n; i++)
	//{
	//	cin >> array[i];

	//	if(array[i] < 0)
	//	{
	//		array[i] *= -1;
	//	}			
	//}
	//cout << endl;
	//for(int i = 0; i < n; i++)
	//{
	//	cout << array[i] << endl;
	//}


	/* 3. ��������� ����� ����������� �������� ��������(����� �� �������� 1..12).
	������ ������� ������ �������� �����. ʳ������ �������� � ���� � ����� ���������. */


	//const int n = 15;		// ������� �������� � ����

	//double sum = 0;
	//double arr[n];

	//for (int i = 0; i < n; i++)
	//{
	//	arr[i] = rand()%12+1;
	//	sum += arr[i]; 
	//}

	//cout << sum/n << endl;



	/* 4. �������� ����������� ����� ������� 10.
	��������� ���� ������� �� 0 �� 9, ����� (0, 1, 2, 3, � 9). ������� �������� ������ �� �����. */

	/*const int n = 10;

	int a[n];

	for (int i = 0; i < n; i++)
	{
	a[i] = i;
	cout << a[i] << endl;
	}*/

	/* 5. �������� ����������� ����� ������� 10. ��������� ���� ������� �� 1 �� 10. ������� �������� ������ �� �����.*/

	/*const int n = 10;

	int b[n];
	for (int i = 1; i <= n; i++)
	{
	b[i] = i;
	cout << b[i] << endl;
	}*/



	/* 6. �������� ����������� ����� ������� 30.
	��������� ���� �������, �� � ��������� 2: (1, 2, 4, 8, 16, ... ).
	������� �������� ������ �� �����. �������� 2-�� ���������.*/

	/*const int n = 30;

	int a[n];
	for (int i = 0; i < 30; i++)
	{

	if(!i)
	{
	a[i] = 1;
	}
	else
	{
	a[i] = a[i - 1] * 2;
	}

	cout << a[i] << endl;
	}*/


	/* 7. �������� ����������� ����� ������� 30. 	��������� ���� ������� Գ������: (1, 1, 2, 3, 5, 8, 13, 21 ... ).
	������� �������� ������ �� �����. ����� Գ������ ���� ��� ���� ��������� ����� Գ������. ����� ��� ����� ��� 1. */

	//const int n = 30;

	// int a[n];

	//for (int i = 0; i < n; i++)
	//{
	//	if(i < 2)
	//	{
	//		a[i] = 1;
	//	}
	//	else
	//	{
	//		a[i] = a[i - 2] + a[i - 1]; //* a[i + 2];
	//	}

	//	cout << a[i] << endl;
	//}

	// 8. ���� ����������� �����. ������ ��������� �� ��������� �������� ������ �� ������� �� � ����� ������.

	const int n = 10;
	int min, max, imax = 0, imin = 0, counter;
	int arr[n];
	srand(time(NULL));

	for (int i = 0; i < n; i++)
	{
		arr[i] = rand() % 10 + 1;

		max, min = arr[0];
		cout << arr[i] << endl;
	}
	cout << endl;

	min = max = arr[0];

	for (int i = 0; i < n; i++)
	{
		if (arr[i] < min)
		{
			min = arr[i];
		}
		if (arr[i] > max)
		{
			max = arr[i];
		}
	}
	cout << "Min: " << min << endl;
	cout << "Max: " << max << endl;

	int t = arr[n];
	arr[imin] = arr[imax];
	arr[imax] = arr[n];

	cout << arr[n] << endl;




	// 9. ���� ����������� �����. ������ ���� �������� ���� ������� ���� � �����.

	//const int n = 15;
	//int arr[n];
	//int sum = 0;
	//bool zero = false;

	//srand(time(NULL));
	//for (int i = 0; i < n; i++)
	//{
	//	arr[i] = rand() % 15 + 1;
	//	cout << arr[i] << endl;
	//
	//	if (arr[i] == 0)
	//	{
	//		zero = true;
	//	}

	//	if (zero == true)
	//	{
	//		sum = sum + arr[i];
	//	}		
	//}
	//cout << "Summa = " << sum << endl;
	

	system("PAUSE");
}