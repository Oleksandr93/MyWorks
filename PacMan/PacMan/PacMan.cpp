#include<iostream>
#include<windows.h>
#include<conio.h>
#include<ctime>
#define WoA 80
#define HoA 25
//#define X0 30
//#define Y0 5+
#define Speed 100
#define n 10
#define Maxlevel 10
using namespace std;



//	int WoA = 20;
//	int HoA = 11;
//int Wl2=WoA+10;
//int Hl2=HoA+5;
INPUT_RECORD record;
DWORD readnum;
DWORD EventCount;
int xe[n], ye[n];
int X0 = 30, Y0 = 5;
int W1 = 20, H1 = 11;
int W2 = 35, H2 = 15;
int x = X0 + W1 - 1, y = Y0 + H1 - 1;
int HoldKey, HoldKeyEnemy[n];
bool conti = true;
bool nextlv = false;
bool gameov = false;
bool tuongphai[4];
char hinhplayer = char(169);
char hinhenemy = char(176);//149
char hinhenemyngu = '#';
char hinhbom = char(164);
char tuong = 16;
char points = '*';
int life = 4;
int Pointss = 0;
int nenemy = 4;
int level = 1;

///////////manglevel1///////////
int mangBG[WoA][HoA];
int mangPoints[WoA][HoA];

//////////manglevel2///////////
int mangBG2[WoA][HoA];
int mangPoints2[WoA][HoA];



void gotoxy(int x0, int y0) {
	COORD capso = { x0,y0 };
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), capso);
}

void Objectcolor(WORD color) {
	CONSOLE_SCREEN_BUFFER_INFO thongtinbuffermanhinh;
	GetConsoleScreenBufferInfo(GetStdHandle(STD_OUTPUT_HANDLE), &thongtinbuffermanhinh);

	WORD k = thongtinbuffermanhinh.wAttributes;
	color &= 0x000f;
	k &= 0xfff0;
	k |= color;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), k);
}

void BGcolor(WORD color) {
	CONSOLE_SCREEN_BUFFER_INFO thongtinbuffermanhinh;
	GetConsoleScreenBufferInfo(GetStdHandle(STD_OUTPUT_HANDLE), &thongtinbuffermanhinh);
	WORD k = thongtinbuffermanhinh.wAttributes;
	color &= 0x000f;
	color <<= 4;
	k &= 0xff0f;
	k |= color;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), k);
}


int HoldkeyLoop() {     // vong lap cho ra Holdkey

						//			Sleep(Speed); // To slow it down!!-
	GetNumberOfConsoleInputEvents(GetStdHandle(STD_INPUT_HANDLE), &EventCount);
	while (EventCount > 0)
	{
		ReadConsoleInput(GetStdHandle(STD_INPUT_HANDLE), &record, 1, &readnum); //why?
		if (record.EventType == KEY_EVENT)
		{
			HoldKey = record.Event.KeyEvent.uChar.AsciiChar;
		}
		GetNumberOfConsoleInputEvents(GetStdHandle(STD_INPUT_HANDLE), &EventCount);
	}
	return HoldKey;
}


void vonglapsinhso(int NumofEnemy) {
	int seed = rand() % 4 + 1;

	if (seed == 1) HoldKeyEnemy[NumofEnemy] = 97;
	else if (seed == 2) HoldKeyEnemy[NumofEnemy] = 115;
	else if (seed == 3)HoldKeyEnemy[NumofEnemy] = 100;
	else HoldKeyEnemy[NumofEnemy] = 119;

}
void inramanhinh(int mang[WoA][HoA], int maxX, int maxY, WORD k, char tuonghoacdiem, int t) {
	int thd;
	bool oktuong = false;
	Objectcolor(k);

	if (t == 1)BGcolor(231);

	if (tuonghoacdiem == tuong)
	{
		thd = 9;

		oktuong = true;
	}
	else if (tuonghoacdiem == points) thd = 1;

	for (int i = 1; i <= maxX;i++)//WoA
		for (int j = 1; j <= maxY; j++)//HoA
		{

			gotoxy(i + X0, j + Y0);
			if (mang[i][j] == thd)cout << tuonghoacdiem;
			//		else if (mang[i][j]==0) cout<<' ';

			if (oktuong) {
				BGcolor(129);
				if (mang[i][j] == 8) cout << ' ';
				BGcolor(231);
				gotoxy(X0, j + Y0);
				cout << tuong;
				gotoxy(X0 + maxX + 1, j + Y0);
				cout << tuong;
			}
		}

	BGcolor(239);
}

void vecham(int x, int y, char a, WORD k) {
	Objectcolor(k);
	gotoxy(x, y);
	cout << a;
}

void setBGcolor() {
	for (int i = 0;i < 80;i++)
		for (int j = 0; j <= 25; j++) {
			BGcolor(239);
			gotoxy(i, j);
			cout << ' ';

		}

	gotoxy(0, 0);
	for (int i = 1; i < 20; i++)Beep(i * 500, 50 - i);
}
void coutmang(int mang[WoA][HoA], int W, int H) {
	for (int i = 1; i <= W;i++)
		for (int j = 1; j <= H; j++)
		{
			gotoxy(X0 + i, Y0 + j);
			cout << mang[i][j];
		}
}
void coutmang2(int mang[WoA][HoA], int W, int H) {

	for (int i = 1; i <= W;i++)
		for (int j = 1; j <= H; j++)
		{
			gotoxy(X0 + i, Y0 + j);
			cout << mang[i][j];
		}
}
void taomangPoints(int mang[WoA][HoA], int W, int H) {
	for (int i = 1; i <= W; i++)
		for (int j = 1; j <= H; j++) {
			if (mang[i][j] == 1) {
				//		int r=rand()%2+1;
				//	if (r==1) 
				mangPoints[i][j] = 1;
			}
		}

}
void taomangBG() {
	for (int i = 1; i <= W1; i++)
		for (int j = 1; j <= H1; j++) {
			if (i == 1 || j == 1 || i == W1 || j == H1)
				mangBG[i][j] = 9;

			else mangBG[i][j] = 1;
		}
	for (int i = 2; i <= W1; i++) {
		if (i > 2 && i <= 5) {
			mangBG[i][3] = 9;
			mangBG[W1 - i + 1][3] = 9;
		}
		if (i > 3 && i < W1 - 2)
			mangBG[i][5] = 9;

		if (i < W1 - 5)mangBG[i][7] = 9;
		if (i > 5 && i < W1 - 2)mangBG[i][9] = 9;
	}
	for (int j = 2; j < H1; j++)
	{
		if (j > 5 && j < 8)mangBG[W1 - 3][j] = 9;
		if (j > 2 && j < 5)mangBG[W1 / 2 + 1][j] = 9;
	}

	/////Destination///////////////
	mangBG[2][1] = 8;


	/////taomangpoints////////////
	taomangPoints(mangBG, W1, H1);


}
void taomangBGlevel2() {
	//	int mX=WoA+10, mY=HoA+5;
	/////////////////mangtuong///////////
	for (int i = 1; i <= W2;i++)
		for (int j = 1; j <= H2; j++) {
			if (i == 1 || j == 1 || i == 35 || j == 15) {
				mangBG2[i][j] = 9;

			}

			else mangBG2[i][j] = 1;


		}
	for (int i = 2; i < W2; i++)
	{
		if ((i > 2 && i<W2 / 2) || ((i>W2 / 2 + 1) && i < W2 - 1))mangBG2[i][H2 - 2] = 9;
		if (i < W2 - 1 && i>2) mangBG2[i][H2 - 4] = 9;
		if (i > W2 / 2 - 2) mangBG2[i][H2 - 6] = 9;
		if (i > W2 / 2 - 4 && i < W2 - 4) mangBG2[i][H2 - 8] = 9;
		if (i < 8) mangBG2[i][H2 - 8] = 9;
		if (i < W2 / 2 - 6 && i>2) mangBG2[i][H2 - 6] = 9;
		if (i < W2 - 1 && i>2) mangBG2[i][H2 - 10] = 9;
		if ((i>6 && i<W2 / 2) || ((i>W2 / 2 + 1) && i < W2))mangBG2[i][3] = 9;
	}
	for (int j = 2; j < H2; j++) {
		if (j<H2 - 4 && j>H2 - 9)mangBG2[W2 / 2 - 4][j] = 9;
		if (j<H2 - 5 && j>H2 - 10)mangBG2[W2 / 2 - 6][j] = 9;
		if (j < 5) mangBG2[5][j] = 9;
		mangBG2[5][3] = 1;

	}


	mangBG2[W2 - 2][1] = 8;
	////////////////mangPoints///////////
	taomangPoints(mangBG2, W2, H2);
}


bool vungdichuyenduoc(int x0, int y0, bool laenemy, int mang[WoA][HoA]) {

	if (laenemy) {

		if (mang[x0 - X0][y0 - Y0] == 1)
			return true;
		else
			return false;
	}
	else {
		if (mang[x0 - X0][y0 - Y0] == 1 || mang[x0 - X0][y0 - Y0] == 8)
			return true;
		else
			return false;
	}
}

void dieukhien(int &HoldKeyn, int &x0, int &y0, char hinhn, WORD k, int mang[WoA][HoA]) {
	bool laenemy;
	if (hinhn == hinhplayer) laenemy = false;
	else laenemy = true;
	switch (HoldKeyn) {
	case 97: {


		if (!vungdichuyenduoc(x0 - 1, y0, laenemy, mang))
		{
			HoldKeyn = 0;
		}
		else {
			vecham(x0, y0, ' ', k);
			x0--;
			vecham(x0, y0, hinhn, k);
		}
		break;
	}
	case 115: {
		if (!vungdichuyenduoc(x0, y0 + 1, laenemy, mang))
		{
			HoldKeyn = 0;

		}
		else
		{
			vecham(x0, y0, ' ', k);
			y0++;
			vecham(x0, y0, hinhn, k);
		}
		break;
	}
	case 100: {
		if (!vungdichuyenduoc(x0 + 1, y0, laenemy, mang)) {
			HoldKeyn = 0;

		}
		else
		{
			vecham(x0, y0, ' ', k);
			x0++;
			vecham(x0, y0, hinhn, k);
		} 	break;
	}
	case 119: {

		if (!vungdichuyenduoc(x0, y0 - 1, laenemy, mang))
		{

			HoldKeyn = 0;
		}
		else
		{
			vecham(x0, y0, ' ', k);
			y0--;
			vecham(x0, y0, hinhn, k);

		}
		break;
	}
	}
}
////////////////////////////////////////////////////
void enemyngu1(int mang[WoA][HoA], int &xe, int &ye, bool &tp) {

	if (!vungdichuyenduoc(xe + 1, ye, true, mang))
	{
		tp = true;
	}
	else if (!vungdichuyenduoc(xe - 1, ye, true, mang))
		tp = false;
	if (tp)
	{
		vecham(xe, ye, ' ', 137);
		xe--;
		vecham(xe, ye, hinhenemyngu, 137);
	}
	else {
		vecham(xe, ye, ' ', 137);
		xe++;
		vecham(xe, ye, hinhenemyngu, 137);
	}
}

//////////////////////////////////////////////////


void xoabang(int x1, int y1, int x2, int y2) {
	string xau[25];
	for (int i = y1;i < y2;i++) {

		for (int j = x1; j < x2; j++)
		{
			xau[i] += " ";
			//cout << xau[i];
		}
		gotoxy(x1, i);

	}
}
void Gameover() {
	conti = false;
	gameov = true;



	xoabang(15, 1, 75, 23);
	gotoxy(35, 10);
	Objectcolor(240);
	cout << '$' << Pointss;
	gotoxy(35, 11);
	Objectcolor(240);
	cout << "GAME OVER";

	gotoxy(1, 21);
	Beep(1568, 200);
	Beep(1568, 200);
	Beep(1568, 200);
	Beep(1245, 1000);
	Beep(1397, 200);
	Beep(1397, 200);
	Beep(1397, 200);
	Beep(1175, 1000);

	gotoxy(35, 10);
	cout << "				";
}
void die() {

	Sleep(Speed);
	Beep(100, 200);
	life--;

	gotoxy(X0 + W1 - 4, Y0 - 1);cout << "		";
	if (life >= 1)
		for (int f = 1; f <= life; f++) {


			vecham(X0 + W1 - 4 + f, Y0 - 1, char(169), 220);

		}

	else Gameover();

}
void collision(bool &vuachet, int NumofEnemyexist) {
	for (int f = 1; f <= NumofEnemyexist;f++)
		if ((x == xe[f] && y == ye[f]) && (vuachet == false)) {
			vecham(x, y, hinhbom, 220);
			die();
			vuachet = true;
		}
}

void displayPoints() {
	Objectcolor(182);
	gotoxy(X0, Y0 - 1);
	cout << "$" << Pointss;
}

void nextlevel(int mang[WoA][HoA]) {
	if (mang[x - X0][y - Y0] == 8)
	{
		Beep(2580, 300);
		level++;
		conti = false;
		nextlv = true;
	}
}

void vonglapchinh(int mang[WoA][HoA]) {



	int countdown = 5;
	bool vuachet = false;
	while (conti == true) {

		Sleep(Speed);

		enemyngu1(mang, xe[7], ye[7], tuongphai[1]);

		enemyngu1(mang, xe[8], ye[8], tuongphai[2]);

		for (int f = 1; f <= nenemy; f++) {
			if (HoldKeyEnemy[f] == 0)vonglapsinhso(f);
			dieukhien(HoldKeyEnemy[f], xe[f], ye[f], hinhenemy, 245, mang);
		}

		collision(vuachet, 8);
		if (vuachet&&countdown > 0) {
			countdown--;
			HoldKey = 0;
		}
		else if (countdown == 0) {
			vuachet = false;
			countdown = 5;
			vecham(x, y, hinhplayer, 220);
		}

		//////////nguoichoi//////
		HoldkeyLoop();
		dieukhien(HoldKey, x, y, hinhplayer, 220, mang);
		/////////////////////////
		collision(vuachet, 8);//vacham doi voi hai enemy

							  ////////////////tinh diem//////////////////
		if (mangPoints[x - X0][y - Y0] == 1) {
			Pointss++;
			Beep(900, 50);
			mangPoints[x - X0][y - Y0] = 0;
			displayPoints();
		}
		for (int kk = 1; kk <= 8; kk++)
			if (mangPoints[xe[kk] - X0][ye[kk] - Y0] == 1) {
				mangPoints[xe[kk] - X0][ye[kk] - Y0] = 0;
			}
		nextlevel(mang);
	}//END OF THE FIRST LOOP
}

void ShowSide() {
	for (int j = 1; j <= life; j++)
		vecham(X0 + W1 - 4 + j, Y0 - 1, char(169), 220);
	gotoxy(x, y);
	cout << hinhplayer;
	displayPoints();

}

void settoado() {
	X0 = 30;
	Y0 = 5;
	xe[1] = X0 + 2;
	ye[1] = Y0 + 2;// enemy
	xe[2] = X0 + 4;
	ye[2] = Y0 + 2;
	xe[3] = X0 + 6;//3
	ye[3] = Y0 + 2;
	xe[4] = X0 + 5;//4
	ye[4] = Y0 + 2;
	xe[7] = X0 + 8;//enemyngu
	ye[7] = Y0 + 2;
	xe[8] = X0 + 4;
	ye[8] = Y0 + 4;
}

void Phadao() {
	int z, nn = 0, xxx, yyy;
	xoabang(10, 1, 70, 24);
	if (level == 4) {
		do {
			nn++;

			xxx = rand() % 80;
			yyy = rand() % 25;
			z = rand() % 225 + 1;
			gotoxy(xxx, yyy);
			Objectcolor(z);
			cout << '+';
			Beep(xxx * 100, 20);
			gotoxy(23, 13);
			Objectcolor(180);
			cout << "CHUC MUNG BAN DA PHA DAO GAME CUA TUI";

		} while (nn < 300);
		HoldKey = 27;
	}
}


//////////////////MENU////////////////////////
void menu() {



	int num = 3;
	bool exit = false;
	bool play = false;
	gotoxy(35, 12);
	Objectcolor(188);
	cout << "PLAY";
	gotoxy(35, 13);
	Objectcolor(180);
	cout << "designer";
	gotoxy(35, 14);
	cout << "exit";

	do {
		HoldKey = _getch();
		switch (HoldKey) {

		case 72: {//up
			Beep(300, 30);
			if (num == 3)num = 1;
			else num++;

			break;

		}
		case 80: {//down
			Beep(100, 30);
			if (num == 1) num = 3;
			else num--;
			break;
		}
		case 13: {
			gotoxy(45, 13);
			cout << " 									";
			Beep(200, 30);
			if (num == 3) {
				play = true;
				HoldKey = 0;
				if (gameov == true) {

					//////////////reset/////////////////////////
					X0 = 30; Y0 = 5;
					x = X0 + W1 - 1;
					y = Y0 + H1 - 1;
					gameov = false;
					level = 1;
					life = 4;
					Pointss = 0;
					settoado();
					/////////////////////////////////////////////

				}

			}
			else if (num == 2) {
				gotoxy(45, 13);
				cout << " BAN QUYEN THUOC VE VUDUYDU";

			}
			else {
				exit = true;
				HoldKey = 27;
			}
			break;
		}
		}

		if (num == 3) {
			gotoxy(35, 12);
			Objectcolor(188);
			cout << "PLAY";
			gotoxy(35, 13);
			Objectcolor(180);
			cout << "designer";
			gotoxy(35, 14);
			cout << "exit";
		}
		else if (num == 2) {
			Objectcolor(188);
			gotoxy(35, 13);
			cout << "DESIGNER";
			gotoxy(35, 12);
			Objectcolor(180);
			cout << "play";

			gotoxy(35, 14);
			cout << "exit";
		}
		else {
			gotoxy(35, 14);
			Objectcolor(188);
			cout << "EXIT";
			gotoxy(35, 12);
			Objectcolor(180);
			cout << "play";
			gotoxy(35, 13);
			cout << "designer";

		}

	} while (exit == false && play == false);

}

void nextlevels() {
	int xx = 1;
	xoabang(10, 1, 60, 23);
	for (int t = 0; t < 20; t++) {
		if (t % 5 == 0)xx = t;

		if (t % 2 == 0) {
			gotoxy(30, 12);
			Objectcolor(xx + 6);
			cout << "    LEVEL " << level << "            ";
		}



		Beep(xx * 100, 50 - t);

	}



}

int main() {

	setBGcolor();

	menu();
	gotoxy(35, 11);
	cout << "A Left";
	gotoxy(35, 12);
	cout << "D Right";
	gotoxy(35, 13);
	cout << "W Up";
	gotoxy(35, 14);
	cout << "S Down";
	Sleep(1500);
	xoabang(34, 10, 40, 15);
	while (HoldKey != 27) {
		for (int i = 0; i < 5; i++)
			tuongphai[i] = rand() % 1;
		settoado();
		/////////////////////
		if (!gameov)conti = true;

		gotoxy(0, 0);
		srand(time(0));
		gotoxy(xe[1], ye[1]);
		cout << hinhenemy;


		switch (level) {
		case 1: {
			taomangBG();
			inramanhinh(mangPoints, W1, H1, 123, points, 0);
			inramanhinh(mangBG, W1, H1, 240, tuong, 1);



			ShowSide();


			vonglapchinh(mangBG);
			break;
		}
		case 2: {
			nextlevels();
			HoldKey = 0;
			X0 -= 5;
			Y0 -= 3;
			taomangBGlevel2();
			inramanhinh(mangPoints, W2, H2, 123, points, 0);
			inramanhinh(mangBG2, W2, H2, 240, tuong, 1);
			xe[1] = X0 + 2;
			ye[1] = Y0 + 2;// enemy
			xe[2] = X0 + 15;
			ye[2] = Y0 + 6;
			xe[3] = X0 + 6;//3
			ye[3] = Y0 + 2;
			xe[4] = X0 + 6;
			ye[4] = Y0 + 6;
			xe[7] = X0 + 13;//enemyngu
			ye[7] = Y0 + 2;
			xe[8] = X0 + 2;
			ye[8] = Y0 + 8;
			conti = true;
			x = X0 + W2 - 1;
			y = Y0 + H2 - 1;
			ShowSide();
			vonglapchinh(mangBG2);
			/////mua do
			//				muado;		
			break;
		}

		case 3: {
			nextlevels();
			HoldKey = 0;
			taomangBGlevel2();
			inramanhinh(mangPoints, W2, H2, 123, points, 0);
			inramanhinh(mangBG2, W2, H2, 240, tuong, 1);
			nenemy += 2;
			xe[5] = X0 + 2;
			ye[5] = Y0 + H2 - 1;
			xe[6] = X0 + 6;
			ye[6] = Y0 + H2 - 5;
			gotoxy(5 + X0, Y0 + 7);
			cout << tuong;
			conti = true;


			xe[1] = X0 + 2;
			ye[1] = Y0 + 3;// enemy
			xe[2] = X0 + 15;
			ye[2] = Y0 + 6;
			xe[3] = X0 + 6;//3
			ye[3] = Y0 + 3;
			xe[4] = X0 + 3;
			ye[4] = Y0 + H2 - 3;
			xe[8] = X0 + 6;
			xe[7] = X0 + 13;
			x = X0 + W2 - 1;
			y = Y0 + H2 - 1;
			ShowSide();
			vonglapchinh(mangBG2);

			break;
		}
		}

		Phadao();
		if (gameov) {

			xoabang(10, 1, 30, 24);
			menu();

		}


	}

	return 0;
}