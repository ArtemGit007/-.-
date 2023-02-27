// Подсчитать колличество положительных чисел среди чисел а, b, c.


Console.WriteLine("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c:");
int c = Convert.ToInt32(Console.ReadLine());


int t = 0;
if(a > 0)
++t;
if(b > 0)
++t;
if(c > 0)
++t;
Console.WriteLine("Положительных чисел {0}", t);

  