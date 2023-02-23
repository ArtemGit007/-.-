// Написать программу нахождения суммы большего и меньшего из 3-xчисел.

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число:");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b&&a > c&&c < b)
{
    int x = a + c;
    Console.WriteLine("Сумма большего и меньшего из 3-x чисел равна {0}", x);
}
if(a > b&&a > c&&b < c)
{
    int x = a + b;
    Console.WriteLine("Сумма большего и меньшего из 3-x чисел равна {0}", x); 
}
if(b > a&&b > c&&c < a)
{
    int x = b + c;
    Console.WriteLine("Сумма большего и меньшего из 3-x чисел равна {0}", x); 
}
if(b > a&&b > c&&a < c)
{
    int x = b + a;
    Console.WriteLine("Сумма большего и меньшего из 3-x чисел равна {0}", x); 
}

if(c > b&&c > a&&b < a)
{
    int x = b + c;
    Console.WriteLine("Сумма большего и меньшего из 3-x чисел равна {0}", x); 
}
if(c > b&&c > a&&a < b)
{
    int x = c + a;
    Console.WriteLine("Сумма большего и меньшего из 3-x чисел равна {0}", x); 
}



