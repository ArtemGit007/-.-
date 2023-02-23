// Написать программу является ли число a делителем числа b?

Console.WriteLine("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());

if(b % a == 0)
{
    Console.WriteLine("Число {0} является делителем числа {1}", a, b);
}
else
{
    Console.WriteLine("Число {0} не является делителем числа {1}", a, b);
}
