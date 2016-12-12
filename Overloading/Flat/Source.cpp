#include "Flat.h"
using namespace std;
void main()
{
	Flat one = Flat(50.4, 25000, 2);
	Flat two = Flat(70.4, 35000, 3);
	cout << endl;
	(one > two).Print();
	cout << endl;
	cout << (one == two);
}