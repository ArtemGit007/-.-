// Даны три стороны одного и три стороны другого треугольника.
// Написать программу определения , будут ли эти треугольники равновеликими, 
// т.е. имеют ли они равные площади.
//  S = √(p·(p - a)·(p - b)·(p - c)), P = (a+b+c)/2

Console.WriteLine("Введите значение стиороны а первого треугольника:");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стиороны b первого треугольника:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стиороны c первого треугольника:");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение стиороны а первого треугольника:");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стиороны b первого треугольника:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение стиороны c первого треугольника:");
int c2 = Convert.ToInt32(Console.ReadLine());


int p1 = (a1 + b1 + c1)/2;
int sque1 = (int)MathF.Sqrt(p1*(p1 - a1)*(p1 - b1)*(p1 - c1));

int p2 = (a2 + b2 + c2)/2;
int sque2 = (int)MathF.Sqrt(p2*(p2 - a2)*(p2 - b2)*(p2 - c2));

if(sque1 !=sque2)
{
    Console.WriteLine("Треугольники не равновеликие");
}
else 
{
    Console.WriteLine("Треугольники являются равновеликими");
}