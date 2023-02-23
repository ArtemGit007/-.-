// Если целое число m делится нацело на целое число n, то вывести на экран частное от деления, 
// в противном случае вывести сообщение «m на n нацело не делится».

Console.WriteLine("Введите целое число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число n:");
int n = Convert.ToInt32(Console.ReadLine());

int c  = m/n;

if(m % n == 0)
{
    Console.WriteLine("Частное от деления {0} на {1} раввно {2}", m, n, c);
}
else 
{
    Console.WriteLine("{0} на {1} без остатка не делится", m, n);
}