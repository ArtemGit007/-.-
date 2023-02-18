// Даны три действительных числа. Возвести в квадрат те из них, 
// значения которых неотрицательны, и в четвертую степень – отрицательные.

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число:");
int c = Convert.ToInt32(Console.ReadLine());

if(a > 0)
{
   a = a * a;
   Console.WriteLine(a);
}
else
{
    Console.WriteLine("Отрицательное число в 4 степени = "  + Math.Pow(a, 4));
}

if( b > 0)
{
   Console.WriteLine("Квадрат числа = " + Math.Pow(b, 2));
}
else
{
    Console.WriteLine("Отрицательное число в 4 степени = " + Math.Pow(b, 4));
}

if(c > 0)
{
   Console.WriteLine("Квадрат числа = " + Math.Pow(c, 2));
}
else
{
    Console.WriteLine("Отрицательное число в 4 степени = " + Math.Pow(c, 4));

}
