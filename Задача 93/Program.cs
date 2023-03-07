//Написать программу, позволяющую по последней цифре числа
//  определить последнюю цифру его квадрата.

string buf;
Console.WriteLine("Введите k-значное число:");
buf = Console.ReadLine();
double x = Convert.ToDouble(buf);


//double c = x%10;
double a = Math.Pow(x%10, 2);
Console.WriteLine("Квадрат последней цифры заданного числа равен {0}", a);
