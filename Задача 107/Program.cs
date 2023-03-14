// Составить программу, позволяющую по последней цифре данного числа определить 
// последнюю цифру куба этого числа.

string buf;
Console.WriteLine("Введите число:");

buf =Console.ReadLine();
double x = Convert.ToDouble(buf);

double a = Math.Pow((x%10), 3);
Console.WriteLine("Куб последней цифры числа {0} равен {1}", x, a);
