#include "Flat.h"
#include "House.h"
#include "Human.h"

#include <iostream>
#include <conio.h>
#include <iomanip>


//Создайте программу, имитирующую многоквартирный дом.Необходимо иметь классы “Человек”, “Квартира”, “Дом”.
//Класс “Квартира” содержит динамический массив объектов класса “Человек”. Класс “Дом” содержит массив объектов класса “Квартира”.
//Каждый из классов содержит переменные - члены и функции - члены, которые необходимы для предметной области//класса.
//Обращаем ваше внимание, что память под строковые значения выделяется динамически.Например, для ФИО в классе “Человек”.
//Не забывайте обеспечить классы различными конструкторами(конструктор копирования обязателен), деструкторами.
//В main протестировать работу полученного набора классов.


using namespace std;

void Menu()
{
	cout << "Add flat: " << "[1]\n";
	cout << "Show Flat: " << "[2]\n";
	cout << "Show all house: " << "[3]\n";
	cout << "Exit " << "[0]\n";
}

void main()
{
	enum Menu	{AddFlat = 1, ShowFlat = 2, ShowAllHouses = 3	};
	int n;
	House h;

	do
	{
		Menu();
		cout << "Enter number: ";
		cin >> n;

		switch (n)
		{
		case AddFlat:
		{
			h.AddFlat();
		}
		break;
		case ShowFlat:
		{
			h.ShowHouse();
		}
		break;
		case ShowAllHouses:
		{
			for (int i = 0; i < h.count; i++)
			{
				h.flat[i].ShowFlat();
			}
		}

		}
	} while (n != 0);
}