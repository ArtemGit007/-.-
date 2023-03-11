// Написать программу, которая бы по введенному номеру единицы измерения 
// (1 – килограмм, 2 – миллиграмм, 3 – грамм, 4 – тонна, 5 – центнер) 
// и массе M выдавала бы соответствующее значение массы в граммах.

string buf1;
Console.WriteLine("Введите значение масссы:");
buf1 = Console.ReadLine();
double m = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите номер единицы измерения (1 – килограмм, 2 – миллиграмм, 3 – грамм, 4 – тонна, 5 – центнер):");
buf2 = Console.ReadLine();
double num = Convert.ToDouble(buf2);

if(num ==1)
{
    double gr = m*1000;
    Console.WriteLine("{0} килограмм это {1} грамм", m, gr);
}

if(num == 2)
{
    double gr = m/1000;
    Console.WriteLine("{0} миллиграм это {1} грамм", m, gr);
}

if(num == 3)
{
    double gr = m;
    Console.WriteLine("{0} грамм это {1} грамм", m, gr);
}

if(num == 4)
{
    double gr = m*1000000;
    Console.WriteLine("{0} килограмм это {1} грамм", m, gr);
}

if(num == 5)
{
    double gr = m*100000;
    Console.WriteLine("{0} килограмм это {1} грамм", m, gr);
}

if(num > 5)
Console.WriteLine("Введено неверное значение номера единицы измерения.");


