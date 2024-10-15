#include <iostream>
#include "Header.h"
using namespace std;



int main()
{
	setlocale(LC_ALL, "Russian");

	int WrB, WrC, WrA, WrLa;
	int Rb, Rc, Ra;
	double La;

	Rb = 5;
	Rc = 2;
	Ra = 7;

	La = operation(Rb, Rc, Ra);
	cout << "Task" << endl << endl;

	cout << " При b = " << Rb << " при c =" << Rc << " при a = " << Ra << " La(b, c, a) = " << La << endl << endl;

	//ЗАПРОС ДАННЫХ
	cout << " Введите b: ";
	cin >> WrB;

	cout << " Введите c: ";
	cin >> WrC;

	cout << " Введите a: ";
	cin >> WrA;

	La = WrLa = operation(WrB, WrC, WrB);

	cout << " При b = " << WrB << " при c =" << WrC << " при a = " << WrA << " La (b, c, a) = " << WrLa << endl << endl;
}