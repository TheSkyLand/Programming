#include <iostream>
using namespace std;

double operation(double, double, double);
int main()
{
	setlocale(LC_ALL, "Russian");

	double WrB, WrC, WrA, WrLa;
	double La;

	double Rb = 5;
	double Rc = 2;
	double Ra = 7;

	La = sqrt(Rb * Rc) * (pow(Rb + (Rc), 2) - pow(Ra, 2)) / (Rb + Rc);
	cout << "Task" << endl << endl;

	cout << " Ïðè b = " << Rb << " ïðè c = " << Rc << " ïðè a = " << Ra << " La(b, c, a) = " << La << endl << endl;

	//ÇÀÏÐÎÑ ÄÀÍÍÛÕ
	cout << " Ââåäèòå b: ";
	cin >> WrB;

	cout << " Ââåäèòå c: ";
	cin >> WrC;

	cout << " Ââåäèòå a: ";
	cin >> WrA;

	WrLa = sqrt(WrB * WrC) * (pow(WrB + (WrC), 2) - pow(WrA, 2)) / (WrB + WrC);

	cout << " Ïðè b = " << WrB << " ïðè c = " << WrC << " ïðè a = " << WrA << " La (b, c, a) = " << WrLa << endl << endl;
}
