#include "Complex.h"
#include <iostream>

using namespace std;


/* Создайте класс Complex(комплексное число) или используйте уже созданный вами класс. Создайте перегруженные операторы для реализации 
арифметических операция для работе с комплексными числами(операции +, -, *, /).*/

void main()
{
		Complex a = Complex(1.2, 3.4); // auto a = Complex(1.2, 3.4);
		Complex b = Complex(5.6, 7.8); // auto b = Complex(5.6, 7.8);
		Complex c = Complex(0.0, 0.0); // auto c = Complex(0.0, 0.0);
	
		c = a + b;
		c.Display();
		a = c - b;
		a.Display();
		b = c - a;
		b.Display();
}