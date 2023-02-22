//Дано двузначное число. Определить: 
// а) является ли сумма его цифр двузначным числом; 
// б) больше ли числа а сумма его цифр.

Console.WriteLine("Введите двузначное число:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число a:");
int a = Convert.ToInt32(Console.ReadLine());

int b = i/10;
int c = i%10;
int x = b + c;

if(x > 9&&x< 100)
{
    Console.WriteLine("Сумма цифр введенного числа - двузначная");
}

else 
{
    Console.WriteLine("Сумма цифр введенного числа не  двузначная");
}
if(x > a)
{
    Console.WriteLine("Сумма цифр введенного числа больше {0}", a);
}
else 
{
    Console.WriteLine("Сумма цифр введенного числа меньше {0}", a);
}

