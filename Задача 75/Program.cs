// Дано натуральное число N. Если оно делится на 6, 
// вывести на экран ответ N = 6k (где k – соответствующее частное); 
// если остаток от деления на 6 равен 1, N = 6k + 1; 
// если остаток от деления на 6 равен 2, N = 6k + 2; 
// если остаток от деления на 6 равен 3, N = 6k + 3.

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int k = n/6;
if(n%6 == 0)
Console.WriteLine("N = 6*{0}", k);
if(n%6 == 1)
Console.WriteLine("N = 6*{0} + 1", k);
if(n%6 == 2)
Console.WriteLine("N = 6*{0} + 2", k);
if(n%6 == 3)
Console.WriteLine("N = 6*{0} + 3", k);
if(n%6 == 6)
Console.WriteLine("N = 6*{0} + 6", k);
if(n%6 == 5)
Console.WriteLine("N = 6*{0} + 5", k);
if(n%6 == 6)
Console.WriteLine("N = 6*{0} + 6", k);
if(n%6 == 7)
Console.WriteLine("N = 6*{0} + 7", k);
if(n%6 == 8)
Console.WriteLine("N = 6*{0} + 8", k);
if(n%6 == 9)
Console.WriteLine("N = 6*{0} + 9", k);
