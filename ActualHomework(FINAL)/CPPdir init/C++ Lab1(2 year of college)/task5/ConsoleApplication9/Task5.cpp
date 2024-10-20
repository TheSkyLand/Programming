#include <iostream>
using namespace std;

double operation(double, double, double);
int main()
{
	double WrB, WrC, WrA, WrLa;
	double La;

	double Rb = 5;
	double Rc = 2;
	double Ra = 7;
	//Standalone operation
	La = operation(Rc, Ra, Rb);
	cout << "Task 5" << endl << endl;

	cout << " so b = " << Rb << " so c = " << Rc << " so a = " << Ra << " La(b, c, a) = " << La << endl << endl;

	//Operation with data request
	cout << "Enter b: ";
	cin >> WrB;

	cout << " Enter c: ";
	cin >> WrC;

	cout << " Enter a: ";
	cin >> WrA;

	WrLa = operation(WrA, WrB, WrC);

	cout << " so b = " << WrB << " so c = " << WrC << " so a = " << WrA << " La (b, c, a) = " << WrLa << endl << endl;
}