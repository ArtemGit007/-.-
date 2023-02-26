//   Написать программу определения: равен ли квадрат 
// заданного трехзначного числа кубу суммы цифр этого числа.

Console.WriteLine("Введите трёхзначное число:");
int x = Convert.ToInt32(Console.ReadLine());

int a = x/100;
int b = x%100/10;
int c = x%10;

int qrt = x*x;
int sum = a + b+ c;
int cube = (int)Math.Pow(sum, 3);

if(qrt != sum)
{
    Console.WriteLine("Квадрат заданного числа {0} не равен кубу суммы его цифр", x);
}
else
{
      Console.WriteLine("Квадрат заданного числа {0} равен кубу суммы его цифр", x);
}

