//  Даны два действительных положительных числа x и у. 
//Арифметические действия над числами пронумерованы 
//(1 – сложение, 2 – вычитание, 3 – умножение, 4 – деление). 
//Составить программу, которая по введенному номеру выполняет то 
//или иное действие над числами.
string buf1;
Console.WriteLine("Введите число х:");
buf1 = Console.ReadLine();
double x = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите число y:");
buf2 = Console.ReadLine();
double y = Convert.ToDouble(buf2);

string buf3;
Console.WriteLine("Введите номер арифметического действия:");
buf3 = Console.ReadLine();
double num = Convert.ToDouble(buf3);

double math1 = 0;
double math2 = 0;
if(num == 1)
{
math1 = x + y;
Console.WriteLine("х {0} + у {1} = {2}", x, y, math1);
math1 =  y + x;
Console.WriteLine("у {1} + х {0} = {2}", x, y, math2);
}

if(num == 2)
{
math1 = x - y;
Console.WriteLine("х {0} - у {1} = {2}", x, y, math1);
math2 = y - x;
Console.WriteLine("у {0} - х {1} = {2}", y, x, math2); 
}
if(num == 3)
{
math1 = x * y;
Console.WriteLine("х {0} * у {1} = {2}", x, y, math1);
math2 = x * y;
Console.WriteLine("у {0} * х {1} = {2}", y, x, math2); 
}
if(num == 4)
{
math1 = x / y;
Console.WriteLine("х {0} / у {1} = {2}", x, y, math1);
math2 = y / x;
Console.WriteLine("y {0} / x {1} = {2}", y, x, math2);
}
