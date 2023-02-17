// Даны два различных вещественных числа. Определить:
//  а) какое из них больше; б) какое из них меньше.

string buf1;
Console.WriteLine("Введите первое вещественное число х");
buf1 = Console.ReadLine();
double x = Convert.ToDouble(buf1); 

string buf2;
Console.WriteLine("Введите второе вещественное число у");
buf2 = Console.ReadLine();
double y = Convert.ToDouble(buf2);
if(x > y)
{
Console.WriteLine("х больше чем у");
}
else 
Console.WriteLine("x меньше, либо равен y");
