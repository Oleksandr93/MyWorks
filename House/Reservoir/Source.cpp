#include "FunctionReservoir.h"
#include "Reservoir.h"

#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>

//Разработать класс Reservoir(водоем).Класс должен обязательно иметь поле «название».Класс должен содержать :
//конструктор по умолчанию, конструктор с параметрами,при необходимости реализовать деструктор и конструктор копирования.
//Добавить методы для :
//1. Определения приблизительного объема(ширина*длина*максимальная глубина);
//2. Определения площади водной поверхности;
//3. Метод для проверки относятся ли водоемы к одному типу(море - море; бассейн - пруд);
//4. Для сравнения площади водной поверхности водоемов одного типа;
//5. Для копирования объектов;
//6. Остальные методы на усмотрение разработчика(методы set и get).
//Написать интерфейс для работы с классом. Реализовать	динамический массив объектов класса с возможностью
//добавления, удаления объектов из массива. Реализовать возможность записи информации об объектах массива	в текстовый файл, бинарный файл.

using namespace std;

void Menu()
{
	cout << left;
	cout << setw(30) << "Fill Reservoirs" << "--[1]\n";
	cout << setw(30) << "Add reservoir" << "--[2]\n";
	cout << setw(30) << "Show reservoir" << "--[3]\n";
	cout << setw(30) << "Volume reservoir" << "--[4]\n";
	cout << setw(30) << "Comparison" << "--[5]\n";
	cout << setw(30) << "Save in file" << "--[6]\n";
	cout << setw(30) << "Data in file" << "--[7]\n";
	cout << setw(30) << "Area" << "--[8]\n";
	cout << setw(30) << "Comparison area" << "--[9]\n";
	cout << setw(30) << "E-X-I-T" << "--[0]\n";
	cout << right;
	cout << endl;
}

void main()
{
	int x;
	enum menu {
		fillreservoirs = 1, AddReservoir = 2, Showreservoir = 3, volume = 4,
		comparison = 5, savedata = 6, datainfile = 7, area = 8, comparisonarea = 9
	};
	FunctionReservoir fr;
	do {
		Menu();
		cout << "Enter number button: ";
		cin >> x;
		switch (x)
		{
		case fillreservoirs:
		{
			fr.FillReservoir();
		}
		break;
		case AddReservoir:
		{
			fr.AddReservoir();
		}
		break;
		case Showreservoir:
		{
			fr.ShowReservoir();
		}
		break;
		case volume:
		{
			fr.Volume();
		}
		break;
		case comparison:
		{
			fr.Comparison();
		}
		break;
		case savedata:
		{
			fr.SaveInfoFile();
		}
		break;
		case datainfile:
		{
			fr.InfoinFile();
		}
		break;
		case area:
		{
			fr.Area1();
		}
		break;
		case comparisonarea:
		{
			fr.ComparisonArea();
		}
		}

	} while (x != 0);
}