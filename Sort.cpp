#include<iostream>
#include<ctime>
using namespace std;

//1. Написати шаблонну функцію яка сортує матрицю по рядках і по стовпцях. Створити 2 enum, для регулювання параметрів сортування.

const int Cols = 3;
enum SortType{ Asc, Desc };
enum target{Row, Col};
template<typename T>
void SortMass(T y[], const int size, SortType mode)
{
	if (mode == SortType::Asc)
	{

		for (int i = 1; i < size; i++)
		{
			int temp = y[i], li = i - 1;
			while (li >= 0 && y[li] > temp)
			{
				y[li + 1] = y[li];
				y[li] = temp;
				li--;
			}
		}
		for (int i = 0; i < size; i++)
		{
			cout << y[i] << "\t";
		}
		cout << endl;
	}
	else
	{
		for (int i = 1; i < size; i++)
		{
			int temp = y[i], li = i - 1;
			while (li >= 0 && y[li] < temp)
			{
				y[li + 1] = y[li];
				y[li] = temp;
				li--;
			}
		}
		for (int i = 0; i < size; i++)
		{
			cout << y[i] << "\t";
		}
		cout << endl;
	}
}
template<typename T>
void SortMass(T y[][Cols], const int Rows, SortType mode, target target)
{
	if (target == target::Row)
	{
		for (int i = 0; i < Rows; i++)
		{
			SortMass(y[i], Rows, mode);
		}
	}
	else if (target == target::Col && mode == SortType::Asc)
	{
		for (int h = 0; h < Rows * Cols; h++)
		{
			for (int i = 0; i < Rows; i++)
			{
				for (int j = 0; j < Cols; j++)
				{
					if (y[i][j] > y[i + 1][j] && i != Rows - 1)
					{
						swap(y[i][j], y[i + 1][j]);
					}
				}
			}
		}
	}
	else if (target == target::Col && mode == SortType::Desc)
	{
		for (int h = 0; h < Rows * Cols; h++)
		{
			for (int i = 0; i < Rows; i++)
			{
				for (int j = 0; j < Cols; j++)
				{
					if (y[i][j] < y[i + 1][j] && i != Rows - 1)
					{
						swap(y[i][j], y[i + 1][j]);
					}
				}
			}
		}
	}
		for (int i = 0; i < Rows; i++)
		{
			for (int j = 0; j < Cols; j++)
			{
				cout << y[i][j] << "\t";
			}
			cout << endl;
		}
	
}
void main()
{
	const int size = 3;
	const int Rows=3;
	int y[size] = { 5, 9, 3 };
	int r[Rows][Cols]={8,5,4,9,1,3,5,8,7};
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			cout << r[i][j] << "\t";
		}
		cout << endl;
	}
	cout << endl;
	SortMass(y, size, Desc);
	cout<<endl;
	SortMass(r, Rows, Desc, Col);
}



//2. Написати функцію яка шукає найлівіший від`ємний елемент матриці та найлівіший правий елемент матриці та сортує між ними елементи.

//int SortArr(int k[], const int size, int w[])
//{
//	setlocale(LC_ALL, " ");
//	int min = 0, max = 0, counter = 0;
//	srand(time(0));
//	for (int i = 0; i < size; i++)
//	{
//		k[i] = rand() % 50 - 10;
//		cout << k[i] << "\t";
//	}
//	for (int i = 0; i < size; i++)
//	{
//		if(k[i] < 0)
//		{
//			counter++;
//			if (counter == 1)
//			{
//				min = i;
//			}
//			w[i] = i;
//		}
//	}
//		cout <<"К1льк1сть в1д`ємних елемент1в = "<< counter << endl;
//		if (counter < 2)
//		{
//			cout <<"В масив1 меньше 2 елемент1в меньших 0 " << endl;
//		return 0;
//		}
//		for (int i=0; i < size; i++)
//		{
//		if (max < w[i])
//		{
//			max = w[i];
//		}
//	}
//		cout <<endl;
//		cout <<" Найменша позиц1я від`ємного елемента: " << min << "\n" <<" Найб1льша позиц1я в1д`ємного елемента: " << max;
//		cout << endl;
//		for (int i = min + 1; i < max; i++)
//		{
//		for (int j = min + 1; j < max; j++)
//		{
//		if (k[i] < k[j])
//		{
//			swap(k[i], k[j]);
//		}
//		}
//		}
//		for (int i = 0; i < size; i++)
//		{
//		cout<< k[i] << "\t";
//		}
//	cout << endl;
//	return 0;
//}
//int main()
//{
//	const int size = 10;
//	int k[size];
//	int w[size];
//	SortArr(k, size, w);
//	return 0;
//}