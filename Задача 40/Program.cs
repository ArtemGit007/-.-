  // Написать программу определения: 
  // делителем каких чисел a, b, с является число k.

  Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k");
int k = Convert.ToInt32(Console.ReadLine());

if(a%k == 0)
{
    Console.WriteLine("число {0} является делителем числа  {1}", k, a);
}
else
{
    Console.WriteLine("число {0} не является делителем числа  {1}", k, a);
}
if(b%k == 0)
{
    Console.WriteLine("число {0} является делителем числа  {1}", k, b);
}
else
{
    Console.WriteLine("число {0} не является делителем числа  {1}", k, b);
}
if(c%k == 0)
{
    Console.WriteLine("число {0} является делителем числа  {1}", k, c);
}
else
{
    Console.WriteLine("число {0} не является делителем числа  {1}", k, c);
}
