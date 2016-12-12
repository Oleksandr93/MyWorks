#include "Fraction.h"
#include <iostream>

using namespace std;

/* —оздайте класс ƒробь(или используйте уже ранее созданный вами). »спользу€ перегрузку операторов реализуйте дл€ него арифметические
операции дл€ работы с дроб€ми(операции +, -, *, /)*/


void main()
{
	Fraction one=Fraction (27, 5);
	Fraction two=Fraction(10,5);
	one+two;
	one-two;
	one*two;
	one/two;

	one=two;
	one.Print();
}