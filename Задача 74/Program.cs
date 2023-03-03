// Напишите программу: Дано натуральное число N. 
// Если оно делится на 4, вывести на экран ответ N = 4k 
// (где k – соответствующее частное); если остаток от деления 
// на 4 равен 1, N = 4k + 1; если остаток от деления на 4 равен 2, 
//N = 4k + 2; если остаток от деления на 4 равен 3, N = 4k + 3.

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int k = n/4;
if(n%4 == 0)
Console.WriteLine("N = 4*{0}", k);
if(n%4 == 1)
Console.WriteLine("N = 4*{0} + 1", k);
if(n%4 == 2)
Console.WriteLine("N = 4*{0} + 2", k);
if(n%4 == 3)
Console.WriteLine("N = 4*{0} + 3", k);
if(n%4 == 4)
Console.WriteLine("N = 4*{0} + 4", k);
if(n%4 == 5)
Console.WriteLine("N = 4*{0} + 5", k);
if(n%4 == 6)
Console.WriteLine("N = 4*{0} + 6", k);
if(n%4 == 7)
Console.WriteLine("N = 4*{0} + 7", k);
if(n%4 == 8)
Console.WriteLine("N = 4*{0} + 8", k);
if(n%4 == 9)
Console.WriteLine("N = 4*{0} + 9", k);
