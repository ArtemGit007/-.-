// Пусть элементами прямоугольного равнобедренного треугольника являются: 
// катет а; гипотенуза b; высота, опущенная из вершины прямого угла на гипотенузу h;
// площадь S. Составить программу, которая по заданному номеру 
//и значению соответствующего элемента вычисляла бы значение 
// всех остальных элементов треугольника.

string buf1;
Console.WriteLine("Введите значение элемента:");
buf1 = Console.ReadLine();
double x = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите номер элемента (1 – катет, 2 – гипотенуза, 3 – высота, 4 – площадь):");
buf2 = Console.ReadLine();
double num = Convert.ToDouble(buf2);

if(num == 1)
{
    double s = 0.5*(x*x);
    double h = x*x/Math.Sqrt((x*x) + (x*x));
    double b = Math.Sqrt((x*x) + (x*x));
    Console.WriteLine("Площадь треугольника с катетом {0} равна {1}, высота равна {2}, гипотенуза равна {3}.", x, s, h, b);

}


if(num == 2)
{
    double a = Math.Sqrt((x*x)/2);
    double s = (a*a)/4;
    double h = x/2;
    
    Console.WriteLine("Площадь треугольника с гипотенузой {0} равна {1}, высота равна {2}, катеты равны {3}.", x, s, h, a);

}

if(num == 3)
{
    double a =  Math.Sqrt((x*x) + (x*x));
    double s = 0.5*(a*a);
    double b = x*2;
    
    Console.WriteLine("Площадь треугольника с высотой {0} равна {1}, высота равна {2}, катеты равны {3}, гипотенуза равна {4}", x, s, x, a, b);

}

if(num == 4)
{
    double a =  Math.Sqrt((x*2));
    double b = Math.Sqrt(x*4);
    double h = (a*a)/b;
    
    Console.WriteLine("Катет треугольника с площадью {0} равен  {1}, высота равна {2}, гипотенуза равна {3}.", x, a, h, b);

}

