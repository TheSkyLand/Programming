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

	La = operation(Rc, Rb, Ra);
	cout << "Task" << endl << endl;

	cout << " so b = " << Rb << " so c = " << Rc << " so a = " << Ra << " La(b, c, a) = " << La << endl << endl;

	//Data request
	cout << " enter b: ";
	cin >> WrB;

	cout << " enter c: ";
	cin >> WrC;

	cout << " enter a: ";
	cin >> WrA;

	WrLa = operation(WrA, WrB, WrC);

	cout << " so b = " << WrB << " so c = " << WrC << " so a = " << WrA << " La (b, c, a) = " << WrLa << endl << endl;
}
