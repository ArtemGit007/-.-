// Дано четырехзначное число. Определить: 
// кратно ли четырем произведение его цифр.

Console.WriteLine("Введите четырехзначное число:");
int x = Convert.ToInt32(Console.ReadLine());

int a = x/1000;
int b= x%1000/100;
int с = x%100/10;
int d= x%10;

int ex = a * b * с * d;

if(ex%4==0)
{
    Console.WriteLine("Произведение цифр числа {0} кратна четырем", x);
}
else
{
    Console.WriteLine("Произведение  цифр числа {0} не кратна четырем", x);
}