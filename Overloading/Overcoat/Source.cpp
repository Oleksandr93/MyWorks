#include "Overcoat.h"
#include <iostream>
#include <string>


/* Создать класс Overcoat(верхняя одежда).
Реализовать перегруженные операторы:
1.Проверка на равенство типов одежды(операция ==).
2. Операцию присваивания одного обьекта в другой(операция =).
3. Сравнение по цене двух пальто одного типа(операция >)*/
using namespace std;

void main()
{
	Overcoat ov = Overcoat(1400, "jacket", "fgfgfggffg");
	Overcoat ov2 = Overcoat(5000, "jacket", "fgfgfggffg");
	cout << "detect if 1 text is the same else 0" << endl;
	cout << (ov == ov2) << endl;
	cout << "copy" << endl;
	(ov = ov2).ShowOvercoat();
	cout << "\ncomparison price" << endl;
	(ov > ov2).ShowOvercoatPrice();
	cout << endl;
	(ov2 > ov).ShowOvercoatPrice();


}