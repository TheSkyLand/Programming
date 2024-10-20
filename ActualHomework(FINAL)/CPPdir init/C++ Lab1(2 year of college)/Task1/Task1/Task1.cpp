#include <iostream>
using namespace std;


int main()
{
	setlocale(LC_ALL, "Russian");

	double WrB, WrC, WrA, WrLa;
	double Rb, Rc, Ra;
	double La;

	double Rb = 5;
	double Rc = 2;
	double Ra = 7;

	La = sqrt(Rb * Rc) * (pow(Rb + (Rc), 2) - pow(Ra, 2)) / (Rb + Rc);
	cout << "Task" << endl << endl;

	cout << " При b = " << Rb << " при c =" << Rc << " при a = " << Ra << " La(b, c, a) = " << La << endl << endl;

	//ЗАПРОС ДАННЫХ
	cout << " Введите b: ";
	cin >> WrB;

	cout << " Введите c: ";
	cin >> WrC;

	cout << " Введите a: ";
	cin >> WrA;

	WrLa = operation(WrA, WrB, WrC);

	cout << " При b = " << WrB << " при c =" << WrC << " при a = " << WrA << " La (b, c, a) = " << WrLa << endl << endl;
}
double operation(double Rb, double Rc, double Ra)
{
	return sqrt(Rb * Rc) * (pow(Rb + (Rc), 2) - pow(Ra, 2)) / (Rb + Rc);
}