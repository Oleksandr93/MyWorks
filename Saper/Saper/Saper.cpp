#include <glut.h>
#include <freeglut.h>
#include <stdlib.h>
#include <time.h>




class setings {
public:
	int width;
	int height;
	int mines;
	setings() {
		width = 40;
		height = 40;
		mines = 100;
	}
}set;

class quads {
public:
	int figure;
	int number;
	bool open;
	bool mine;
	quads() {
		open = false;
		figure = 0;
		mine = false;
		number = 0;
	}
	void draw();
};

quads *pole = new quads[set.width*set.height];

class game {
public:
	bool generated;
	int number_selected;
	game() {
		generated = false;
		number_selected = 0;
	}
	void generator();
	void figures();
	void grid();
	void draw_selected();
}saper;

void game::draw_selected() {
	glBegin(GL_QUADS);
	glColor3f(0.7, 0, 0);
	glVertex2f(16 * (number_selected%set.width) - 2, 16 * int(number_selected / set.width) - 2);
	glVertex2f(16 * (number_selected%set.width) + 10, 16 * int(number_selected / set.width) - 2);
	glVertex2f(16 * (number_selected%set.width) + 10, 16 * int(number_selected / set.width) + 10);
	glVertex2f(16 * (number_selected%set.width) - 2, 16 * int(number_selected / set.width) + 10);
	glEnd();
}

void game::grid() {
	glColor3f(1, 0, 0);
	glBegin(GL_LINES);
	for (int i = 0; i <= set.height; i++) {
		glVertex2f(-4, i * 16 - 4);
		glVertex2f(16 * set.width - 4, i * 16 - 4);
	}
	for (int i = 0; i <= set.width; i++) {
		glVertex2f(i * 16 - 4, -4);
		glVertex2f(i * 16 - 4, 16 * set.height - 4);
	}
	glEnd();
}

void quads::draw() {
	if (open)
		if (!mine) {
			glColor3f(0, 1, 0);
			glRasterPos2i(16 * (number%set.width), 16 * int(number / set.width));
			unsigned char figure[2] = { '0' + this->figure };
			glutBitmapString(GLUT_BITMAP_9_BY_15, figure);
		}
		else {
			glColor3f(0, 1, 0);
			glRasterPos2i(16 * (number%set.width), 16 * int(number / set.width));
			unsigned char mine[2] = { char(1) };
			glutBitmapString(GLUT_BITMAP_9_BY_15, mine);
		}
}

void game::generator() {
	int number;
	for (int i = 0;i < set.mines; i++) {
		do {
			number = rand() % (set.height*set.width);
		} while (pole[number].mine);
		pole[number].mine = true;
	}
}

void game::figures() {
	for (int i = 0; i < set.height*set.width; i++) {
		pole[i].number = i;
		if ((i%set.width != set.width - 1) && (i + 1 < set.height*set.width) && (pole[i + 1].mine == true))pole[i].figure++;

		if ((i%set.width != 0) && (i - 1 > 0) && (pole[i - 1].mine == true))pole[i].figure++;

		if ((i%set.width != 0) && (i - set.width - 1>0) && (pole[i - set.width - 1].mine == true))pole[i].figure++;

		if ((i - set.width > 0) && (pole[i - set.width].mine == true))pole[i].figure++;

		if ((i%set.width != set.width - 1) && (i - set.width + 1 > 0) && (pole[i - set.width + 1].mine == true))pole[i].figure++;

		if ((i%set.width != set.width - 1) && (i + set.width + 1 < set.height*set.width) && (pole[i + set.width + 1].mine == true))pole[i].figure++;

		if ((i + set.width < set.height*set.width) && (pole[i + set.width].mine == true))pole[i].figure++;

		if ((i%set.width != 0) && (i - set.height*set.width + 10 < 0) && (pole[i + set.width - 1].mine == true))pole[i].figure++;
	}
}

void Timer(int) {
	glutPostRedisplay();
	glutTimerFunc(50, Timer, 0);
}

void skeyboard(int key, int x, int y) {
	switch (key) {
	case GLUT_KEY_UP:if (saper.number_selected + set.width < set.height*set.width)saper.number_selected += set.width;
		break;
	case GLUT_KEY_LEFT:if (saper.number_selected - 1 >= 0)saper.number_selected--;
		break;
	case GLUT_KEY_DOWN:if (saper.number_selected - set.width >= 0)saper.number_selected -= set.width;
		break;
	case GLUT_KEY_RIGHT:if (saper.number_selected + 1 < set.height*set.width)saper.number_selected++;
		break;
	case GLUT_KEY_INSERT:
		if (!saper.generated) {
			saper.generator();
			saper.figures();
			saper.generated = true;
		}
		pole[saper.number_selected].open = true;
		if (pole[saper.number_selected].mine)exit(0);
	}
}

void draw() {
	glClear(GL_COLOR_BUFFER_BIT);
	glPushMatrix();
	saper.grid();
	saper.draw_selected();
	for (int i = 0; i < set.height*set.width; i++)pole[i].draw();
	glPopMatrix();
	glutSwapBuffers();
	glFlush();
}

void Initialization(double WinWid, double WinHei) {
	glClearColor(0, 0, 0, 0);
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
	glOrtho(-5, WinWid - 5, -5, WinHei - 5, -1, 1);
}

int main(int argc, char ** argv) {
	srand(time(NULL));
	double WinWid = 800;
	double WinHei = 650;
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutInitWindowSize(WinWid, WinHei);
	glutInitWindowPosition(0, 0);
	glutCreateWindow("SAPER");
	glutSpecialFunc(skeyboard);
	glutTimerFunc(50, Timer, 0);
	glutDisplayFunc(draw);
	Initialization(WinWid, WinHei);
	glutMainLoop();
}