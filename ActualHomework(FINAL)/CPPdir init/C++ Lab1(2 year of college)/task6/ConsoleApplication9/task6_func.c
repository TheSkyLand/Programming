extern double WrA;
extern double WrB;
extern double WrC;
extern double WrLa;
void operation()
{
	WrLa = sqrt(WrB * WrC) * (pow(WrB + (WrC), 2) - pow(WrA, 2)) / (WrB + WrC);
}