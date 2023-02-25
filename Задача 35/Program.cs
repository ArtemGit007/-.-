//  Даны два угла треугольника (в градусах). Определить, 
// существует ли такой треугольник. 
// Если да, то будет ли он прямоугольным.

Console.WriteLine("Введите значение первого угла a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение второго угла b:");
int b = Convert.ToInt32(Console.ReadLine());

if((a + b) < 180)
{
    Console.WriteLine("Треугольник с такими углами существует");
}
else
{
    Console.WriteLine("Треугольника с такими углами не существует");
}

if((a + b) == 90)
{
    Console.WriteLine("Треугольник прямоугольный");
}
else
{
    Console.WriteLine("Треугольник не прямоугольный");
}
