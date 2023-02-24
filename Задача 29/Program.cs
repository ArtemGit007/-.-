//  Дано трехзначное число. Определить: кратна ли пяти сумма его цифр. 

Console.WriteLine("Введите трёхзначное число:");
int x = Convert.ToInt32(Console.ReadLine());

int a = x/100;
int b = (x%100)/10;
int c = x%10;

int y = a + b + c;

if(y%5 == 0)
{
    Console.WriteLine("Сумма цифр числа {0} равна {1} и кратна 5", x, y);
}
else
{
    Console.WriteLine("Сумма цифр числа {0} равна {1} и не кратна 5", x, y); 
}
