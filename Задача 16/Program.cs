//Дано трехзначное число. Определить, равен ли квадрат этого числа 
//сумме кубов его цифр.



Console.WriteLine("Введите трехзначное число");

int x = Convert.ToInt32(Console.ReadLine());
 
int a = x/100;
int b = x%100/10;
int c  = x%10;

int sum1 = (int)Math.Pow(a, 3);
int sum2 = (int)Math.Pow(b, 3);
int sum3 = (int)Math.Pow(c, 3);
int sum = sum1 + sum2 + sum3;

if(x*x == sum)
{
    Console.WriteLine("Квадрат числа {0} равен сумме {1} кубов его цифр", x, sum);
}
else
{
    Console.WriteLine("Квадрат числа {0} не равен сумме {1} кубов его цифр", x, sum);
}
