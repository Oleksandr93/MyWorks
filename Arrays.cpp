#include <iostream>
#include <conio.h>
#include <stdio.h>
#include <stdlib.h>
#include <ctime>
using namespace std;

int main()
{
	// 1. Ввести з клавіатури масив 7 чисел. Вивести елементи масиву у прямому і оберненому порядку. Знайти кількість едементів масиву, що кратні 3.

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



	// 2. Дано одновимірний масив. Замінити всі від’ємні елементи їх модулями

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


	/* 3. Заповнити масив випадковими оцінками студентів(числа із діапазону 1..12).
	Знайти середню оцінку студентів групи. Кількість студентів у групі – деяка константа. */


	//const int n = 15;		// кількість студентів в групі

	//double sum = 0;
	//double arr[n];

	//for (int i = 0; i < n; i++)
	//{
	//	arr[i] = rand()%12+1;
	//	sum += arr[i]; 
	//}

	//cout << sum/n << endl;



	/* 4. Утворити одновимірний масив розміром 10.
	Заповнити його числами від 0 до 9, тобто (0, 1, 2, 3, … 9). Вивести елементи масиву на екран. */

	/*const int n = 10;

	int a[n];

	for (int i = 0; i < n; i++)
	{
	a[i] = i;
	cout << a[i] << endl;
	}*/

	/* 5. Утворити одновимірний масив розміром 10. Заповнити його числами від 1 до 10. Вивести елементи масиву на екран.*/

	/*const int n = 10;

	int b[n];
	for (int i = 1; i <= n; i++)
	{
	b[i] = i;
	cout << b[i] << endl;
	}*/



	/* 6. Утворити одновимірний масив розміром 30.
	Заповнити його числами, які є степенями 2: (1, 2, 4, 8, 16, ... ).
	Вивести елементи масиву на екран. Виконати 2-ма способами.*/

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


	/* 7. Утворити одновимірний масив розміром 30. 	Заповнити його числами Фібоначі: (1, 1, 2, 3, 5, 8, 13, 21 ... ).
	Вивести елементи масиву на екран. Число Фібоначі рівне сумі двох попередніх чисел Фібоначі. Перші два числа рівні 1. */

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

	// 8. Дано одновимірний масив. Знайти найбільший та найменший елементи масиву та поміняти їх у масиві місцями.

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




	// 9. Дано одновимірний масив. Знайти суму елементів після першого нуля у масиві.

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