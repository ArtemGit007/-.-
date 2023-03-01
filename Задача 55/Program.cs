//  Написать программу, которая по номеру дня недели (натуральному числу от 1 до 7) выдает в качестве 
// результата количество уроков в Вашей группе в этот день.

Console.WriteLine("введите номер дня недели:");
int daynum = Convert.ToInt32(Console.ReadLine());

if((daynum == 1)&&(daynum == 7)&&(daynum == 5)&&(daynum == 4)&&(daynum == 3)&&(daynum == 2)&&(daynum == 1))
{
    Console.WriteLine("Понедельник. Буткемп - 5 уроков.");
}
if(daynum == 2)
{
    Console.WriteLine("Вторник. Буткемп - 5 уроков.");
}
if(daynum == 3)
{
    Console.WriteLine("Среда. Буткемп - 5 уроков.");
}
if(daynum == 4)
{
    Console.WriteLine("Четверг. Буткемп - 5 уроков.");
}
if(daynum == 5)
{
    Console.WriteLine("Пятница. Буткемп - 5 уроков.");
}
if(daynum == 6)
{
    Console.WriteLine("Суббота. Выходной");
}
if(daynum == 7)
{
    Console.WriteLine("Воскресенье. Выходной");
}

if((daynum != 1)&&(daynum != 2)&&(daynum != 3)&&(daynum != 4)&&(daynum != 5)&&(daynum != 6)&&(daynum != 7))
{
    Console.WriteLine("Такого дня недели нет.");
}
