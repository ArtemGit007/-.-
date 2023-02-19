// Определить максимальное и минимальное значения 
// из двух различных вещественных чисел.

string buf1;
Console.WriteLine("Введите первое вещественное число а:"); 
buf1 = Console.ReadLine();
double a = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите первое вещественное число b:"); 
buf2 = Console.ReadLine();
double b = Convert.ToDouble(buf2);

if(a > b)
{
    Console.WriteLine("Число {0} больше числа {1}.", a, b);
}
else
{
    Console.WriteLine("Число {0} больше числа {1}.", b, a);
}



 
