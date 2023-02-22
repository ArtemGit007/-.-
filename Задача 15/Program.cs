// Дано натуральное число. Определить: а) является ли оно четным;
// б) оканчивается ли оно цифрой 7.

Console.WriteLine("Введите натуральное число");
int x = Convert.ToInt32(Console.ReadLine());

if(x % 2 == 0)
{
    Console.WriteLine("Введенное число четное");
}
else 
{
    Console.WriteLine("Введенное число нечетное");
}

if(x%10 == 7|x == 7)
{
    Console.WriteLine("Введенное число заканчивается цифрой 7");
}
else 
{
    Console.WriteLine("Введенное число не заканчивается цифрой 7"); 
}
