#include <iostream>
using namespace std;

void operation();
double WrC;
double WrA;
double WrB;
double WrLa;
int main()
{
	setlocale(LC_ALL, "Russian");

	//ÇÀÏÐÎÑ ÄÀÍÍÛÕ
	cout << " Ââåäèòå b: ";
	cin >> WrB;

	cout << " Ââåäèòå c: ";
	cin >> WrC;

	cout << " Ââåäèòå a: ";
	cin >> WrA;

	operation();

	cout << " Ïðè b = " << WrB << " ïðè c = " << WrC << " ïðè a = " << WrA << " La (b, c, a) = " << WrLa << endl << endl;
}
void operation()
{
	WrLa = sqrt(WrB * WrC) * (pow(WrB + (WrC), 2) - pow(WrA, 2)) / (WrB + WrC);
}