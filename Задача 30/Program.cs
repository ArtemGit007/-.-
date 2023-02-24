//   Дано трехзначное число. Определить: кратна ли сумма его цифр числу а. 

Console.WriteLine("Введите трёхзначное число:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());

int i = x/100;
int b = (x%100)/10;
int c = x%10;

int y = i + b + c;

if(y%a == 0)
{
    Console.WriteLine("Сумма цифр числа {0} равна {1} и кратна числу {2}", x, y, a);
}
else
{
    Console.WriteLine("Сумма цифр числа {0} равна {1} и не кратна числу {2} ", x, y, a); 
}
