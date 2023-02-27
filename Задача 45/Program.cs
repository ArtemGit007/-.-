// Написатьпрограмму определения - является ли 
// треугольник со сторонами a, b, с равнобедренным.

Console.WriteLine("Введите значение стороны а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стороны b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стороны c:");
int c = Convert.ToInt32(Console.ReadLine());


if(a == b|b == c|c == a)
{
    Console.WriteLine("Треугольник равнобедренный");
}
else
{
    Console.WriteLine("Треугольник не равнобедренный");
}
