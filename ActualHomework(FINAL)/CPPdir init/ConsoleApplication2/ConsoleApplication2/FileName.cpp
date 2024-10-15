#include <cmath>

double operation(double Rb, double Rc, double Ra)
{
	return sqrt(Rb * Rc) * (pow(Rb + (Rc), 2) - pow(Ra, 2)) / (Rb + Rc);;
}