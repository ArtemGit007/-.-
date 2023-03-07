// Пусть элементами прямоугольного равнобедренного треугольника являются: 
// катет а; гипотенуза b; высота, опущенная из вершины прямого угла на гипотенузу h; 
// площадь S. Составить программу, которая по заданному номеру и значению 
// соответствующего элемента вычисляла бы значение всех остальных элементов треугольника.

string buf1;
Console.WriteLine("Введите значение а катета треугольника:");
buf1 = Console.ReadLine();
double a = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите значение b гипотенузы треугольника:");
buf2 = Console.ReadLine();
double b = Convert.ToDouble(buf2);

string buf3;
Console.WriteLine("Введите значение h высоты треугольника :");
buf3 = Console.ReadLine();
double h = Convert.ToDouble(buf3);

string buf4;
Console.WriteLine("Введите значение S площади треугольника:");
buf4 = Console.ReadLine();
double s = Convert.ToDouble(buf4);

string bufnum;
Console.WriteLine("Введите значение номер элемента треугольника: катет - 1; гипотенуза - 2; высота - 3; площадь - 4");
bufnum = Console.ReadLine();
double num = Convert.ToDouble(bufnum);



if(num == 2)
{
    // S = a²·sin α·sin β/2sin(α + β)
     s = b*b*((Math.Sin(45)*Math.Sin(45))/(2*Math.Sin(90)));
    Console.WriteLine("Площадь равностороннего треугольника с заданной гипотенузой равна {0}", s);

}

if(num == 1)
{
 Console.WriteLine("По одному катету проблематично найти значения других элементов треугольника.");
}

if(num == 3)
{
    Console.WriteLine("Затруднительно найти другие элементы труугольника имея значения лишь его высоты.");
}

if(num == 4)
{
    Console.WriteLine("Затруднительно найти другие элементы труугольника имея значения лишь его площади.");
}





