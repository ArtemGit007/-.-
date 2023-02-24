//  Дано трехзначное число. Определить, есть ли среди его цифр одинаковые.



Console.WriteLine("Введите трёхзначное число:");
int x = Convert.ToInt32(Console.ReadLine());

int a = x/100;
int b = (x%100)/10;
int c = x%10;

if(a==b||a==c||b==c)
{
    Console.WriteLine("Среди цифр числа {0} есть одинаковые", x);
}
else
{
    Console.WriteLine("Все цифры числа {0} разные", x);
}
