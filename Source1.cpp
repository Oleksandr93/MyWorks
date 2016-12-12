#include <iostream>
#include <ctime>
#include <stdarg.h>
using namespace std;

//const int size = 5;

/*1. Написати рекурсивну функцію, яка знаходить середнє арифметичне значення масиву. */

//
//double SerArr(double arr[], int size, int n)
//{
//	if (n == 0)
//	{
//		return arr[0] / size;
//	}
//	else
//	{
//		return SerArr(arr, size, n - 1) + arr[n] / size;
//	}
//}
//
//void main()
//{
//	double arr[] = { 1, 5, 9, 7, 11 };
//	cout << SerArr(arr, size, 8) << "\n";
//}


// 2. Написати функцію, знаходить добуток елементів масива.

//
//
//int ArrayMul(int a[], int size)
//{
//	if (size == 0)
//	{
//		return a[0];
//	}
//	else
//	{
//		return ArrayMul(a, size - 1) * a[size];
//	}
//}
//
//void main()
//{
//	int a[] = { 1, 2, 3, 4, 8, 11};
//	cout << ArrayMul(a, size) << "\n";
//}


/* 3. Написати 2 рекурсивні функції, які шукають максимальне там мінімальне значення масиву.*/

//int MaxArr(int a[5], int size)
//{
//	if (size == 1)
//		return a[0];
//	else
//	{
//		int temp = MaxArr(a, size - 1);
//
//		if (temp > a[size - 1])
//			return temp;
//		else
//			return a[size - 1];
//	}
//}
//
//
//int MinArr(int a[5], int size)
//{
//	if (size == 1)
//		return a[0];
//	else
//	{
//		int temp = MinArr(a, size - 1);
//
//		if (temp < a[size - 1])
//			return temp;
//		else
//			return a[size - 1];
//	}
//}
//
//void main()
//{
//	int array[5] = { 5, 17, 3, 10, 6 };
//
//	cout << "The max value is: " << MaxArr(array, 5) << endl;
//	cout << "The min value is: " << MinArr(array, 2) << endl;
//	
//}

/* 4. Написати функцію яка виводитиме число в двійковій формі.*/


//void Num(int number)
//{	
//	if(number != 1)
//	{
//		Num(number / 2);
//	}
//	cout << number %2;
//}
//
//
//void main()
//{
//	Num(10);
//	cout << endl;
//}


//void PrintNumber(int size, ...)
//{
//	va_list args;
//	va_start(args, size);	
//	for (int i = 0; i < size; i++)
//	{
//	int arg = va_arg(args, int);
//	cout << arg << endl;
//	}
//	va_end(args);
//}

//int SumNum (int size, ...)
//{
//	va_list args;
//	va_start(args, size);
//	int sum  = 0;
//	for (int i = 0; i < size; i++)
//	{
//		int arg = va_arg(args, int);
//		sum += arg;
//	}
//	va_end(args);
//	return sum;
//}

//int MinNum(int size, ...)
//{
//	va_list args;
//	va_start(args, size);
//	int min = va_arg(args, int);
//	for (int i = 0; i < size - 1; i++)
//	{
//		int currentEl = va_arg(args, int);
//		if (currentEl < min)
//		{
//			min = currentEl;
//		}
//	}		
//	va_end(args);
//	return min;
//}
//
//int MaxNum(int size, ...)
//{
//	va_list args;
//	va_start(args, size);
//	int max = va_arg(args, int);
//	for (int i = 0; i < size - 1; i++)
//	{
//		int currentEl = va_arg(args, int);
//		if (currentEl > max)
//		{
//			max = currentEl;
//		}
//	}		
//	va_end(args);
//	return max;
//}
//
//void main()
//{
//	/*cout << SumNum(5, 2, 4, 5, 6);
//	cout << endl;*/
//
//	cout << "Max element: " << MaxNum(7, 1, 312, 422, 5667, 600, 70, 20);
//	cout << endl;
//
//	cout << "Min element: " << MinNum(5, 180, 150, 124, 456, 154);
//	cout << endl;
//	/*PrintNumber(10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);*/
//}



void printArr(int arr[], const int size = 10)
{
	for (int i = 0; i < size; i++)
	{
		cout << arr[i] << "\t";
	}
	cout << endl;
}


void PrintArrays(int size, ...)
{
	va_list args;
	va_start(args, size);
	
	for (int i = 0; i < size; i++)
	{
		int *a = va_arg(args, int*);
		printArr(a, size);
	}

	va_end(args);

}

void SumArr(int size, ...)
{
	va_list args;
	va_start(args, size);
	int sum = 0;
	for (int i = 0; i < size; i++)
	{
		int *a = va_arg(args, int*);
		printArr(a, size);
		sum += *a;
	}
	va_end(args);
}


void main()
{
	int arr[] = {1, 2, 4, 6};
	int l[] = {5, 8, 5, 6};
	int k[] = {7, 2, 3, 5};
	int h[] = {2, 7, 5, 8};

	PrintArrays(4, arr, l, k, h);
	cout << endl;
	SumArr(4, arr, l, k, h);
}