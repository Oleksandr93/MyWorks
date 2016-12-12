#include "Group.h"
#include "Student.h"

#include <iostream>
#include <string>
#include <locale>

/*На основі розробленого в класі класу Student, розробити
клас Group виходячи з наступних вимог:
a) Клас повинен містити статичний масив з 3-ох структур
“студент+оцінка” (можна без масиву)
b) Містити “спеціалізацію” типу string
c) Містити приватний член з середньою оцінкою групи,
яка рахуватиметься приватним методом
d) Метод друку всієї інформації з класу на екран
e) Описати метод який повертатиме біль успішну групу */

using namespace std;

void Menu()
{
	cout << "Create group 1 -- [1]\n";
	cout << "Show group 1 -- [2]\n";
	cout << "Create group 2 -- [3]\n";
	cout << "Show group 2 -- [4]\n";
	cout << "Comparison Two Groups -- [5]\n";
	cout << "Exit -- [0]\n";
	cout << "Your choice: ";
}


void main()
{
	Group gr1;
	Student st1;
	Group2 gr2;
	Student st2;
	int x = 0, index;
	enum option { CreateAdminsStudent = 1, ShowAdminsStudent = 2, CreateTestersStudent = 3, ShowTestersStudent = 4, ComparisonGroups = 5 };
	do {
		Menu();
		cin >> index;
		system("cls");
		switch (index)
		{
		case CreateAdminsStudent:
		{
			cout << "---Create first group---\n";
			gr1.FillStudentInGroupAdmins();
		}
		break;
		case ShowAdminsStudent:
		{
			gr1.GroupName();
			gr1.ShowStudentInGroupAdmins();
			cout << "Average of all marks admins: " << gr1.MarksT() << endl;
		}
		break;
		case CreateTestersStudent:
		{
			cout << "---Fill second group---\n";
			gr2.FillStudentInGroup();
		}
		break;
		case ShowTestersStudent:
		{
			gr2.GroupName();
			gr2.ShowStudentinGroup();
			cout << "Average of all marks testers: " << gr2.MarksP() << endl;
		}
		break;
		case ComparisonGroups:
		{
			if (gr1.MarksT() < gr2.MarksP())
			{
				cout << "Better learning " << endl;
				gr2.GroupName();
			}
			else if (gr2.MarksP() == gr1.MarksT())
			{
				cout << "Two groups are learning well " << endl;
			}
			else
			{
				cout << "Better learning " << endl;
				gr1.GroupName();
			}
		}
		break;
		}

	} while (index != 0);

	cout << endl;
}