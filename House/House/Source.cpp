#include "Flat.h"
#include "House.h"
#include "Human.h"

#include <iostream>
#include <conio.h>
#include <iomanip>


//�������� ���������, ����������� ��������������� ���.���������� ����� ������ ��������, ����������, ����.
//����� ���������� �������� ������������ ������ �������� ������ ��������. ����� ���� �������� ������ �������� ������ ����������.
//������ �� ������� �������� ���������� - ����� � ������� - �����, ������� ���������� ��� ���������� �������//������.
//�������� ���� ��������, ��� ������ ��� ��������� �������� ���������� �����������.��������, ��� ��� � ������ ��������.
//�� ��������� ���������� ������ ���������� ��������������(����������� ����������� ����������), �������������.
//� main �������������� ������ ����������� ������ �������.


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