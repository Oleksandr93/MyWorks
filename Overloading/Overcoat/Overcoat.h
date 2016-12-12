#include <iostream>
#include <string>

using namespace std;

class Overcoat
{
public:
	int price;
	char * typeOvercoat;
	char * mark;

	Overcoat();
	Overcoat(int price, char * typeOvercoat, char * mark);
	~Overcoat();
	void FillOvercoat();
	void ShowOvercoat() const;
	void ShowOvercoatPrice() const;
	char operator ==(Overcoat &);
	Overcoat& operator =(Overcoat &);
	Overcoat& operator >(Overcoat &);



};