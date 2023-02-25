// Дано четырехзначное число. Определить: кратна ли трем сумма его цифр.

Console.WriteLine("Введите четырехзначное число:");
int x = Convert.ToInt32(Console.ReadLine());

int a = x/1000;
int b= x%1000/100;
int с = x%100/10;
int d= x%10;

int sum = a + b + с + d;

if(sum%3==0)
{
    Console.WriteLine("Сумма цифр числа {0} кратна трём", x);
}
else
{
    Console.WriteLine("Сумма цифр числа {0} не кратна трём", x);
}
