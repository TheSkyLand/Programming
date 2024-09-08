#include <iostream>
#include <cmath> // МАТЕМАТИКААА!!!(НЕНАВИЖУ)
// ЛАБОРАТОРНАЯ РАБОТА НОМЕР 2 ЗАДАЧА 20(ВРЕМЯ 3:10)
using namespace std; // разрешаем использовать ctd, cout, cin и прочее
int main()
{
    // Определяем переменные :D
    double a;
    double b;
    double c;
    double x;
    double y;
    double v;
    // устанавливаем русский язык
    setlocale(LC_ALL, "Russian");
    // запрашиваем а
    cout << " Введите a = ";
    cin >> a;
    // запрашиваем b
    cout << " Введите b = ";
    cin >> b;
    // запрашиваем с
    cout << " Введите c = ";
    cin >> c;
    // запрашиваем x
    cout << " Введите x = ";
    cin >> x;
    // запрашиваем y
    cout << " Введите y = ";
    cin >> y;
    double ElMin = x;
    double ElMax = pow(x, 2);

    if (x < 3 && y < 0)
    {
        v = a + b + c * ElMin;
            if (ElMin > y)
            {
                v = ElMin = y;
                cout << v << " Переменная V при минимальном элементе " << v;
                if (ElMin > (x + y / x - y))
                {
                    v = ElMin = (x + y / x - y);
                    cout << v << " Переменная V при минимальном элементе 2 " << v;
                }
            }
    }
    if (x > 0 && y > 1)
    {
        if (ElMax < pow(y, 3))
        {
           v = ElMax = pow(y, 3);
           cout << " Переменная V при максимальном элементе " << v;
        }
    }
    else
    {
        v = y * (a + b + c);
        cout << " Переменная V в противном случае " << v;
    }
}
