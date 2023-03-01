// Написать программу, которая по номеру дня недели 
//(натуральному числу от 1 до 7) выдает 
//в качестве результата количество дней, оставшихся до выходных.

Console.WriteLine("введите номер дня недели:");
int daynum = Convert.ToInt32(Console.ReadLine());
if(daynum == 2)
{
    Console.WriteLine("Вторник. До выходных три дня");
}
if(daynum == 3)
{
    Console.WriteLine("Среда. До выходных два дня");
}
if(daynum == 4)
{
    Console.WriteLine("Четверг. До выходных один день");
}
if(daynum == 5)
{
    Console.WriteLine("Завтра выходной!");
}
if(daynum == 1)
{
    Console.WriteLine("Понедельник. До выходных четыре дня");
}
if((daynum == 6)||(daynum == 7))
{
    Console.WriteLine("Сегодня выходной!");
}
if((daynum != 6)&&(daynum != 7)&&(daynum != 5)&&(daynum != 4)&&(daynum != 3)&&(daynum != 2)&&(daynum != 1))
{
    Console.WriteLine("Такого дня недели нет.");
}
