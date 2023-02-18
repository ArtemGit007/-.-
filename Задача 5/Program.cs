// Известны два расстояния: одно в километрах, другое – в футах (1 фут 0,305 м). Какое из расстояний меньше?

string buf1;
Console.WriteLine("Введите первое расстояние в км.");
buf1 = Console.ReadLine();
double km = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите второе расстояние в футах");
buf2 = Console.ReadLine();
double ft = Convert.ToDouble(buf2);

if(km/0.305 < ft)
{
    Console.WriteLine("Расстояние в {0} киллометра(ов) меньше, чем {1} фута(ов) ", km, ft);
}

else 
{
   Console.WriteLine("Расстояние в {0} киллометра(ов) больше, чем расстояние в {1} фута(ов) ", km, ft);
}