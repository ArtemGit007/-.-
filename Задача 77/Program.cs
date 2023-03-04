// Дано натуральное число N. Если оно делится на 7, вывести на экран ответ 
// N = 7k (где k – соответствующее частное); если остаток от деления на 7 равен 1, 
// N = 7k + 1; если остаток от деления на 7 равен 2, N = 7k + 


Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int k = n/7;
if(n%7 == 0)
Console.WriteLine("N = 7*{0}", k);
if(n%7 == 1)
Console.WriteLine("N = 7*{0} + 1", k);
if(n%7 == 2)
Console.WriteLine("N = 7*{0} + 2", k);
if(n%7 == 3)
Console.WriteLine("N = 7*{0} + 3", k);
if(n%7 == 4)
Console.WriteLine("N = 7*{0} + 4", k);
if(n%7 == 5)
Console.WriteLine("N = 7*{0} + 5", k);
if(n%7 == 6)
Console.WriteLine("N = 7*{0} + 6", k);
if(n%7 == 7)
Console.WriteLine("N = 7*{0} + 7", k);
if(n%7 == 8)
Console.WriteLine("N = 7*{0} + 8", k);
if(n%7 == 9)
Console.WriteLine("N = 7*{0} + 9", k);

