// Написать программу, которая бы по введенному номеру единицы измерения
// (1 – килограмм, 2 – миллиграмм, 3 – грамм, 4 – тонна, 5 – центнер) 
// и массе M выдавала бы соответствующее значение массы в килограммах.

string buf1;
Console.WriteLine("Введите номер единицы измерения:");
buf1 = Console.ReadLine();
double a = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите массу:");
buf2 = Console.ReadLine();
double m = Convert.ToDouble(buf2);

double kg = 0;
if(a == 1)
Console.WriteLine(kg = m);
if(a == 2)
Console.WriteLine(kg = m/1000000);
if(a == 3)
Console.WriteLine(kg = m/1000);
if(a == 4)
Console.WriteLine(kg = m*1000);
if(a == 5)
Console.WriteLine(kg = m*100);

if(a > 5)
Console.WriteLine("Вы ввели неверный номер единицы измерения, либо некорректное значение массы.");
