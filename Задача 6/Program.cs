// Известны две скорости: одна в километрах в час, другая – в метрах в секунду. Какая из скоростей больше?

string buf1;
Console.WriteLine("Введите значение первой скорости в км/ч:");
buf1 = Console.ReadLine();
double km = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите значение второй скорости в м/с:");
buf2 = Console.ReadLine();
double m = Convert.ToDouble(buf2);

if(km/3.6 < m)
{
    Console.WriteLine("Скорость {0} км/ч меньше, чем скорость {1} м/с", km, m);
}
else
{
     Console.WriteLine("Скорость {0} км/ч больше, чем скорость {1} м/с", km, m);
}
