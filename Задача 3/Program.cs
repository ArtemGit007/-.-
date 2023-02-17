// Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
// Площадь круга равна pi*r^2.
// Пдлощадь квадрата равна s*s.

string buf1;
Console.WriteLine("Введите значение радиуса круга r:");
buf1 = Console.ReadLine();
double r = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите значение стороны квадрата s:");
buf2 = Console.ReadLine();
double s = Convert.ToDouble(buf2);


double pi = 3.14;
double O = (pi*r)*(pi*r);
double S = s*s;

if(O > S)
{
    Console.WriteLine(" Площадь круга {0} больше площади квадрата {1}", O, S);
}

else
{
    Console.WriteLine("Площадь квадрата {0} бюольше площади круга {1}", S, O);
}
