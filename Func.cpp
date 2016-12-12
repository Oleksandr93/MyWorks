
// # include <iostream>
// # include <ctime>
// using namespace std;
// /*
// Даний масив з 20 цілих чисел з значеннями від 1 до 20. Необхідно: 
//- написати функцію, яка розкидає елементи масиву довільним чином; 
//- створити випадкове число з того ж діапазону і знайти позицію цього випадкового числа в масиві; 
//- відсортувати елементи масиву, які знаходяться справа від знайденої позиції по спаданню, 
//а елементи масиву, які знаходяться зліва від знайденої позиції по зростанню.
// */
//
//void FillArr(int a[], int size);
//void SortArr(int a[], int size);
//void SwapArr(int a[], int size);
//
//void FillArr(int a[], int size)
//{
// 
//    for(int i = 0; i < size; i++)
//    { 
//        a[i] = i + 1;
//    }
//}
// 
//void SortArr(int a[], int size)
//{    
//	int x = 1 + rand()%21;
//    int index = 0;
//    for(int i = 0; i < size; i++)
//    {
//        if (x == a[i])
//        {
//            index = i;
//			break;
//        }
//    }
//
//	for(int i = 0; i < index - 1; i++)
//    {
//		for(int j = 0; j < index - 1; j++)
//        {
//            if(a[j] > a[j + 1])
//            {
//                int tmp = a[j];
//                a[j] = a[j + 1];
//                a[j + 1] = tmp;
//            }
//        }
//    }
//
//	for (int i = index + 1; i < size; i++)
//	{
//		for (int j = index + 1; j < size; j++)
//		{
//			if(a[j] < a[j + 1])
//            {
//                int tmp = a[j];
//                a[j] = a[j + 1];
//                a[j + 1] = tmp;
//            }
//		}
//	}
// 
//cout <<"Digit = " << x << endl;
//cout <<"Index = " << index <<endl;
//}
// 
//void PrintArr(int a[], int size)
//{
//    for(int i = 0; i < size; i++)
//    {
//        cout << a[i] <<"\t"; 
//    }
//}
//
//void SwapArr(int a[], int size)
//{
//		srand(time(0));
//		for (int i = 0; i < size; i++)
//		{
//			swap(a[i], a[rand()%size]);
//		}
//}
//void main()
//{    
//    srand(time(0));
//    const int size = 20;
//    int arr[size];
//    FillArr(arr, size);
//    PrintArr(arr,size);
//	cout << endl;
//	cout << "Swap array: " << "\n";
//	SwapArr(arr, size);
//	PrintArr(arr, size);
//	cout << endl;
//	SortArr(arr, size);
//	cout << endl;
//	cout << "Sort array: " << "\n";
//	PrintArr(arr, size);
//}
//





#include <iostream>
#include <ctime>
using namespace std;


/*1. Написати функцію сортування масиву, в яку ми в якості параметрів передаємо, масив, розмір масиву та тип сортування(enum).
По-замовчуванню, функція повинна сортувати за зростанням.*/
//
//void ASC_Sort(int a[], int n)
//{
//	int i, j, t;
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = i + 1; j < n; j++)
//		{
//			if (a[i] > a[j])
//			{
//				t = a[i];
//				a[i] = a[j];
//				a[j] = t;
//			}
//		}
//		cout << a[i] << "\n";
//	}
//}
//
//
//void DESC_Sort(int a[], int n)
//{
//	int i, j, t;
//	for (i = 0; i < n; i++)
//	{
//		for (j = i + 1; j < n; j++)
//		{
//			if (a[i] < a[j])
//			{
//				t = a[j];
//				a[j] = a[i];
//				a[i] = t;
//			}
//		}
//		cout << a[i] << "\n";
//	}
//}
//
//int main()
//{
//	int a[100], i, n;
//	cout << "Enter The number of Element: ";
//	cin >> n;
//	cout << "Enter Elements: ";
//	for (i = 0; i < n; i++)
//	{
//
//		cout << "Enter: ";
//		cin >> a[i];
//	}
//	cout << endl;
//	ASC_Sort(a, n);
//	cout << endl;
//	DESC_Sort(a, n);
//}

/*2. Написати функцію яка заповнюватиме матрицю переданим символом.*/


//char GetSymbol(char k)
//{
//	char s;
//
//	cout << "Enter symbol: ";
//	cin >> s;
//
//	return 0;
//
//}
//
//
//
//int main()
//{
//	char k;
//	const int a = 5, b = 5;
//	int arr[a][b];
//	GetSymbol('*');
//	for (int i = 0; i < 5; i++)
//	{
//		for (int j = 0; j < 5; j++)
//		{
//			cout << GetSymbol('*');
//		}
//		cout << endl;
//	}
//	
//
//}