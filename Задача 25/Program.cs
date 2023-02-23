// Дано трехзначное число. Верно ли, что все его цифры одинаковые?

Console.WriteLine("Введите трёхзначное число:");
int x = Convert.ToInt32(Console.ReadLine());

int a = x/100;
int b = (x%100)/10;
int c = x%10;

if(a == b&&b == c)
{
    Console.WriteLine("Все цифры числа {0} равны", x);
}
else

{
    Console.WriteLine("Цифры числа {0} различны", x);
}