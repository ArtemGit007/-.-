//  Написать программу определени: является ли треугольник со сторонами a, b, с равносторонним.

Console.WriteLine("Введите значение стороны а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стороны b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стороны c:");
int c = Convert.ToInt32(Console.ReadLine());


if(a == b&&b == c&&c == a)
{
    Console.WriteLine("Треугольник равносторонний.");
}
else
{
    Console.WriteLine("Треугольник не равносторонний.");
}
