// Даны две точки А(х1, y1) и В(х2, у2). Написать программу алгоритма, определяющего, 
// какая из точек находится дальше от начала координат.


Console.WriteLine("Введите координату x точки А:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки А:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x точки B:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки B:");
int y2 = Convert.ToInt32(Console.ReadLine());

int t1 = (int)Math.Sqrt((x1 - 0)*2 + (y1 - 0)*2);
int t2 = (int)Math.Sqrt((x2 - 0)*2 + (y2 - 0)*2);

if(t1 < t2)
{
    Console.WriteLine("Точка В дальше oт  начала координат");
}

else
{
    Console.WriteLine("Точка В ближе, либо в таком же расстоянии от начала координат");
}
