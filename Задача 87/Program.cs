// Написать программу по следующим условиям: 
//с начала 1990 года по некоторый день прошло n месяцев и 2 дня. 
// Определить название месяца (январь, февраль и т. п.) этого дня.

Console.WriteLine("Введите число прошедших месяцев:");
int month  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер этого некоторого дня месяца:");
int day = Convert.ToInt32(Console.ReadLine());




if((day == 28)||(day == 27)&&((month == 1)||(month%12 == 1))&&((month - 25)%48 != 0))
Console.WriteLine("Март.");

if(day < 28&&(month == 1||month%12 ==1))
Console.WriteLine("Февраль.");

if((day > 29&&day<32)&&(month == 2||month%12 ==2))
{
   Console.WriteLine("Апрель.");
}
if((day < 29||day == 29)&&(month == 2||month%12 == 2))
Console.WriteLine("Март.");

if((day > 28&&day<31)&&(month == 3||month%12 ==3))
{
   Console.WriteLine("Май.");
}
if(day < 29&&(month == 3||month%12 ==3))
Console.WriteLine("Апрель.");


if((day > 29&&day<32)&&(month == 4||month%12 ==4))
{
   Console.WriteLine("Июнь.");
}
if((day < 29||day == 29)&&(month == 4||month%12 ==4))
Console.WriteLine("Май.");


if((day > 29&&day<32)&&(month == 5||month%12 ==5))
{
   Console.WriteLine("Июль.");
}
if((day < 29||day == 29)&&(month == 5||month%12 ==5))
Console.WriteLine("Июнь.");


if((day > 29&&day<32)&&(month == 6||month%12 ==6))
{
   Console.WriteLine("Август.");
}
if((day < 29||day == 29)&&month == 6||month%12 ==6)
Console.WriteLine("Июль.");


if((day > 29&&day<32)&&(month == 7||month%12 ==7))
{
   Console.WriteLine("Сентябрь.");
}
if((day < 29||day == 29)&&(month == 7||month%12 ==7))
Console.WriteLine("Август.");


if((day > 29&&day<32)&&(month == 8||month%12 == 8))
{
   Console.WriteLine("Октябрь.");
}
if((day < 29||day == 29)&&(month == 8||month%12 == 8))
Console.WriteLine("Сентябрь.");

if((day > 28&&day < 31)&&(month == 9||month%12 == 9))
{
   Console.WriteLine("Ноябрь.");
}
if((day < 29||day == 29)&&(month == 9||month%12 == 9))
Console.WriteLine("Октябрь.");


if((day > 29&&day<31)&&(month == 10||month%12 ==10))
{
   Console.WriteLine("Декабрь.");
}
if((day < 29||day == 29)&&(month == 10||month%12 ==10))
Console.WriteLine("Ноябрь.");


if((day > 29&&day<32)&&(month == 11||month%12 ==11))
{
   Console.WriteLine("Январь.");
}
if((day < 29||day == 29)&&(month == 11||month%12 ==11))
Console.WriteLine("Декабрь.");


if((day > 29&&day<32)&&(month == 12||month%12 ==0))
{
   Console.WriteLine("Февраль.");
}
if((day < 29||day == 29)&&(month == 12||month%12 ==0))
Console.WriteLine("Январь.");

if((day == 29||day >29)&&(month%12 ==1||month == 1)&&((month - 25)%48 != 0))
Console.WriteLine("Введено неверное значение дня месяца.");

if(day > 30&&(month ==4||month == 6||month == 9||month == 11))
Console.WriteLine("Введено неверное значение дня месяца.");
if(day > 31&&(month == 3||month == 5||month == 7||month ==8||month ==10||month == 12))
Console.WriteLine("Введено неверное значение дня месяца.");


