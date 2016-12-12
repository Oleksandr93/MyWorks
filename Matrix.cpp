#include <iostream>
#include <ctime>
using namespace std;

void main()
{
	/* 1. Знайти і вивести найменший елемент матриці, та вивести повідомлення про його розташування.
	("Вище головної діагоналі", "Нище головної діагоналі", "На головній діагоналі").*/

	//const int ROWS = 5, COLS = 5;

	//int a[ROWS][COLS];
	//srand(time(NULL));
	//for (int i = 0; i < ROWS; i++)
	//{
	//for (int j = 0; j < COLS; j++)
	//{
	//a[i][j] = rand() % 10 + 1;
	//cout << a[i][j] << "\t";
	//}
	//cout << endl;
	//}

	//int min = a[0][0], Mini = 0, Minj = 0;
	//for (int i = 0; i < ROWS; i++)
	//{
	//for (int j = 0; j < COLS; j++)
	//{
	//if (a[i][j] < min)
	//{
	//min = a[i][j];
	//Mini = i;
	//Minj = j;
	//}
	//}
	//}

	//cout << "Min: " << min << endl;
	//
	//cout << min << endl << Mini << ":" << Minj << endl;
	//if (Mini > Minj)
	//{
	//	cout << "Nujche golovnoi diagonali" << endl;
	//}
	//if (Mini < Minj)
	//{
	//	cout << "Vushe golovnoi diagonali" << endl;
	//}
	//if (Mini = Minj)
	//{
	//	cout << "Na golovnii diagonali" << endl;
	//}


	/* 2. Утворити та заповнити матрицю M x N випадковими числами із інтервалу -20.. 20.
	Ввести з клавіатури позицію елементу матриці, вивести вказаний елемент з рядком і стовпцем в якому він знаходиться.
	Наприклад, матриця:
	1 4 3 2
	3 2 1 3
	2 3 4 5
	1 2 3 4
	вводимо з клавіатури 1 i 2, отримуємо
	3
	3 2 1 3
	4
	3*/

	/*const int ROWS = 5;
	const int COLS = 5;

	int a[ROWS][COLS];

	for (int i = 0; i < ROWS; i++)
	{
	for (int j = 0; j < COLS; j++)
	{
	a[i][j] = rand() % 41 - 20;
	cout << a[i][j] << "\t";
	}
	cout << endl;
	}

	int position1 = 0, position2 = 0;
	cout << "Enter position: ";
	cin >> position1 >> position2;

	for (int i = 0; i < ROWS; i++)
	{
	for (int j = 0; j < COLS; j++)
	{
	if (i == position1 || j == position2)
	{
	cout << a[i][j] << " ";
	}
	else
	{
	cout << " ";
	}

	}
	cout << endl;
	}
	*/

	/* 3. Утворити матрицю, що містить натуральні числа 1, 2, ..., розташовані змійкою.
	Початок "змійки" - лівий верхній кут матриці. Рух змійки по рядках чи по стовпцях на замовлення користувача.*/

	/*const int ROWS = 5;
	const int COLS = 5;
	int a[ROWS][COLS];
	int counter = 1;

	for (int i = 0; i < ROWS; i++)
	{
		for (int j = 0; j < COLS; j++)
		{
			a[i][j] = counter++;
			cout << a[i][j] << "\t";
		}
		cout << endl;
	}
	cout << endl;
	int napryamok = 0;
	cout << "Enter  napryamok:\n 1-po ryadkah\n 2-po stovpcyah" << endl;
	cin >> napryamok;
	if (napryamok == 1)
	{
		for (int i = 0; i < ROWS; i++)
		{
			for (int j = 0; j < COLS; j++)
			{
				if (i % 2)
				{
					cout << a[i][COLS - j - 1] << "\t";
				}
				else
				{
					cout << a[i][j] << "\t";
				}
			}
			cout << endl;
		}
	}
	cout << endl;
	if (napryamok == 2)
	{
		for (int i = 0; i < ROWS; i++)
		{
			for (int j = 0; j < COLS; j++)
			{
				if (j % 2)
				{
					cout << a[j][ROWS - i - 1] << "\t";
				}
				else
				{
					cout << a[j][i] << "\t";
				}

			}
			cout << endl;
		}
	}*/



	/*1. Дана позиція офіцера на шаховій дошці. Відмітити клітинки на дошці, що знаходяться під загрозою офіцера. Офіцер може ходити по діагоналях,
	які перетинаються на клітинці, у якій він розміщений.*/


	const int ROWS = 8;
	const int COLS = 8;

	char a[ROWS][COLS];

	for (int i = 0; i < ROWS; i++)
	{
		for (int j = 0; j < COLS; j++)
		{
			a[i][j] = '.';
			cout << a[i][j];
		}
		cout << endl;
	}

	int posX, posY;
	cout << "Enter position: ";
	cin >> posX >> posY;
		
	for (int i = 0; i < ROWS; i++)
	{
		for (int j = 0; j < COLS; j++)
		{
			int dX = abs(i - posX);
			int dY = abs(j - posY);

			if (dX == 0 && dY == 0) {
				a[i][j] = 'O';
			}
			else if (dX == dY) {
				a[i][j] = 'A';
			}
		}
	}

	for (int i = 0; i < ROWS; i++)
	{
		for (int j = 0; j < COLS; j++)
		{
			cout << a[i][j];
		}
		cout << endl;
	}


	system("PAUSE");
}