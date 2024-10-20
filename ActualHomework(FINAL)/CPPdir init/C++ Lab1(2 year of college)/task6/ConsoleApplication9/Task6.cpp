#include <iostream>
using namespace std;

void operation();
int main()
{
	setlocale(LC_ALL, "Russian");

	//Data request
	cout << " enter b: ";
	cin >> WrB;

	cout << " enter c: ";
	cin >> WrC;

	cout << " enter a: ";
	cin >> WrA;

    operation();

	cout << " so b = " << WrB << " so c = " << WrC << " so a = " << WrA << " La (b, c, a) = " << WrLa << endl << endl;
}
