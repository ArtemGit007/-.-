// Дано трехзначное число. Определить: больше ли числа а произведение его цифр.

Console.WriteLine("Введите трёхзначное число:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());

int y = x/100;
int b = (x%100)/10;
int c = x%10;

int i = y*b*c;

if(i > a)
{
    Console.WriteLine("Произведение цифр числа {0} больше числа {1}", x, a);
}
else
{
    Console.WriteLine("Произведение цифр числа {0} меньше числа {1}", x, a);
}

