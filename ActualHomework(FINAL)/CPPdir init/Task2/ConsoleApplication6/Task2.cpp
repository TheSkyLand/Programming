#include <iostream>
using namespace std;


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

	cout << " ��� b = " << Rb << " ��� c = " << Rc << " ��� a = " << Ra << " La(b, c, a) = " << La << endl << endl;

	//������ ������
	cout << " ������� b: ";
	cin >> WrB;

	cout << " ������� c: ";
	cin >> WrC;

	cout << " ������� a: ";
	cin >> WrA;

	WrLa = sqrt(WrB * WrC) * (pow(WrB + (WrC), 2) - pow(WrA, 2)) / (WrB + WrC);

	cout << " ��� b = " << WrB << " ��� c = " << WrC << " ��� a = " << WrA << " La (b, c, a) = " << WrLa << endl << endl;
}
