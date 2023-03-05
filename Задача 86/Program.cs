// Написать программу которая бы по введенному номеру единицы измерения 
//(1 –дециметр 2 – километр 3 – метр 4 – миллиметр 5 – сантиметр) 
//и длине отрезка l, выдавала бы соответствующее значение длины отрезка в метрах.

string buf1;
Console.WriteLine("Введите значение единицы измерения:");
buf1 = Console.ReadLine();
double x = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите длину отрезка L:");
buf2 = Console.ReadLine();
double l = Convert.ToDouble(buf2);

double metrs = 0;

if(x == 1)
{
    metrs = l/10;
Console.WriteLine("Длина отрезка равного {0} дц. соответствует {1} м.", l, metrs);
}

if(x == 2)
{
 metrs = l *1000;
Console.WriteLine("Длина отрезка равного {0} км. соответствует {1} м.", l, metrs); 
}

if(x == 3)
{
 metrs = l;
Console.WriteLine("Длина отрезка равного {0} м. соответствует {1} м.", l, metrs); 
}

if(x == 4)
{   
 metrs = l/1000;
Console.WriteLine("Длина отрезка равного {0} мл. соответствует {1} м.", l, metrs); 
}

if(x == 5)
{
 metrs = l/100;
Console.WriteLine("Длина отрезка равного {0} см. соответствует {1} м.", l, metrs); 
}

if(x > 5)
{
    Console.WriteLine("Введён неверный номер единицы измерения или некорректное значение длины отрезка.");
}