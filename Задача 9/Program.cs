// Задача 9.  Написать программу, которая по заданным трем числам определяет, 
// является ли сумма каких-либо двух из них положительной.

Console.WriteLine("Введите первое число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число c:");
int c = Convert.ToInt32(Console.ReadLine());

int x = a + b;
int y = a + c;
int i = c + b;

if(x > 0)
{
    Console.WriteLine(" Сумма чисел {0} и {1} равна {2}, что больше нуля.", a, b, x);
}

if(y > 0)
{
    Console.WriteLine("Сумма чисел {0} и {1} равна {2}, что  больше нуля.", a, c, y);
}
if(i > 0)
{
    Console.WriteLine("Сумма чисел {0} и {1} равна {2}, что больше нуля.", c, b, i);
}
else
{
    Console.WriteLine("Сумма чисел отрицательна.");
}

