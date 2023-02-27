// Подсчитать количество целых чисел среди чисел a, b, с.

string buf1;
Console.WriteLine("Введите число а:");
buf1 =Console.ReadLine();
double a = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите число b:");
buf2 = Console.ReadLine();
double b = Convert.ToDouble(buf2);

string buf3;
Console.WriteLine("Введите число c:");
buf3 = Console.ReadLine();
double c = Convert.ToDouble(buf3);

double t = 0;
if(a%1==0)
++t;
if(b%1 == 0)
++t;
if(c%1 == 0)
++t;
Console.WriteLine("Целых чисел {0}", t);

