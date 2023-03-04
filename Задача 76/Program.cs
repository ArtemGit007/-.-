// Дано натуральное число N. Если оно делится на 5, вывести на экран ответ 
// N = 5k (где k – соответствующее частное); если остаток от деления на 5 равен 1, 
// N = 5k + 1; если остаток от деления на 5 равен 2, N = 5k + 


Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int k = n/5;
if(n%5 == 0)
Console.WriteLine("N = 5*{0}", k);
if(n%5 == 1)
Console.WriteLine("N = 5*{0} + 1", k);
if(n%5 == 2)
Console.WriteLine("N = 5*{0} + 2", k);
if(n%5 == 3)
Console.WriteLine("N = 5*{0} + 3", k);
if(n%5 == 4)
Console.WriteLine("N = 5*{0} + 4", k);
if(n%5 == 5)
Console.WriteLine("N = 5*{0} + 5", k);
if(n%5 == 6)
Console.WriteLine("N = 5*{0} + 6", k);
if(n%5 == 7)
Console.WriteLine("N = 5*{0} + 7", k);
if(n%5 == 8)
Console.WriteLine("N = 5*{0} + 8", k);
if(n%5 == 9)
Console.WriteLine("N = 5*{0} + 9", k);
