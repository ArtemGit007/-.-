//  Пусть элементами круга являются радиус (первый элемент), диаметр (второй элемент) и длина окружности (третий элемент). 
// Составить программу, которая по номеру элемента запрашивала бы его соответствующее значение и вычисляла бы площадь круга.
string bufnum;
Console.WriteLine("Введите значение номер элемента круга: радиус - 1; диаметр - 2; окружность - 3");
bufnum = Console.ReadLine();
double num = Convert.ToDouble(bufnum);

double pi = 3.14;

if(num == 1)
{
string buf;
Console.WriteLine("Введите значение r радиуса круга:");
buf = Console.ReadLine();
double r = Convert.ToDouble(buf);
double s = pi*r*r;
Console.WriteLine("Площадь круга с радиусом {0} равна {1}", r, s);
}

if(num ==2)
{
    string buf;
Console.WriteLine("Введите значение d диаметра круга:");
buf = Console.ReadLine();
double d = Convert.ToDouble(buf);
// S = d²:4*π. 
double s = d*d/4*pi;
Console.WriteLine("Площадь круга с диаметроом {0} равна {1}", d, s);

}

if(num == 3)
{
    string buf;
Console.WriteLine("Введите значение l окружности круга:");
buf = Console.ReadLine();
double l = Convert.ToDouble(buf);
double s = (l*l)/(4*pi);
Console.WriteLine("Площадь круга с окружностью {0} равна {1}", l, s);
}



 






