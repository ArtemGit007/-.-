 // Дано двузначное число. Определить: а) кратна ли трем сумма его цифр; 
// б) кратна ли сумма его цифр числу а.

Console.WriteLine("Введите двузначное число i:"); 
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите двузначное число a:"); 
int a = Convert.ToInt32(Console.ReadLine());

int b = i/10;
int c = i%10;

if((c + b)%3 == 0)
{
    Console.WriteLine("Сумма цифр числа кратно трем");
}

else 
{
    Console.WriteLine("Сумма цифр не кратна трем");
}

if((b + c)%a == 0)
{
    Console.WriteLine("Сумма цифр кратна {0}", a);
}

else 
{
    Console.WriteLine("Сумма цифр не кратна {0}", a);
}
