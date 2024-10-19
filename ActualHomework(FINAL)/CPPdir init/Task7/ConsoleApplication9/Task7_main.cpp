#include <iostream>
#include <cmath>
#include "Task7_Func.h"
using namespace std;


int main()
{
	//Operation with data request
	cout << "Enter b: ";
	cin >> WrB;

	cout << " Enter c: ";
	cin >> WrC;

	cout << " Enter a: ";
	cin >> WrA;

	operation();

	cout << " so b = " << WrB << " so c = " << WrC << " so a = " << WrA << " La (b, c, a) = " << WrLa << endl << endl;
}
