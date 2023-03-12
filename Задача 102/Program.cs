// Написать программу, которая бы по введенному номеру единицы измерения 
//(1 –дециметр, 2 – километр, 3 – метр, 4 – миллиметр, 5 – сантиметр) 
//и длине отрезка D выдавала бы соответствующее значение длины отрезка в сантиметрах.

string buf1;
Console.WriteLine("Введите значение длины отрезка:");
buf1 = Console.ReadLine();
double length = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine("Введите номер единицы измерения (1 –дециметр, 2 – километр, 3 – метр, 4 – миллиметр, 5 – сантиметр)");
buf2 = Console.ReadLine();
double num = Convert.ToDouble(buf2);




if(num == 1)
Console.WriteLine("Длина {0} дц. равна {1} cm", + length, (length*10));

if(num == 2)
Console.WriteLine("Длина {0} km. равна {1} cm", + length, length*100000);

if(num == 3)
Console.WriteLine("Длина отрезка {0} m. равна {1} cm", + length, length*100);

if(num == 4)
Console.WriteLine("Длина отрезка {0} mlm. равна  {1} cm", + length, length/10);

if(num == 5)
Console.WriteLine("Длина отрезка {0} sm. равна  {1} cm", + length, length);

if(num > 6)
Console.WriteLine("Введено неверное значение номера единицы измерения.");

