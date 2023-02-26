// Дано трехзначное число N. Написать программу проверки, 
// будет ли сумма его цифр четным числом. 

Console.WriteLine("Введите трехзначное число:");
int x = Convert.ToInt32(Console.ReadLine());


int b= x/100;
int с = x/10;
int d= x%10;

int ex =  b + с + d;

if(ex%2==0)
{
    Console.WriteLine("Сумма цифр числа {0} - четное число", x);
}
else
{
    Console.WriteLine("Сумма цифр числа {0} - не четное число", x);
}
