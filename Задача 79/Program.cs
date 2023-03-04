//  Напишите программу , условия следующие: дата некоторого дня характеризуется двумя натуральными числами: m 
// (порядковый номер месяца) и n (число). По заданным n и m определить дату предыдущего дня 
//(принять, что n и m не характеризуют 1 января). Примечание: принять, что год не является високосным.

Console.WriteLine("Введите поярдковый номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение числа:");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("  ");

if(day == 1&&month == 2)
Console.WriteLine("31 Января");
 if(day == 1&&month == 6)
Console.WriteLine("31 Мая.");  
 
 if(day == 1&&month == 4)
Console.WriteLine("31 Марта.");   
 if(day == 1&&month == 8)
Console.WriteLine("31 Июля.");  
 if(day == 1&&month == 9)
Console.WriteLine("31 Августа.");  
 if(day == 1&&month == 11)
Console.WriteLine("31 Октября.");  
 if(day == 1&&month == 1)
Console.WriteLine("31 Декабря.");  

if(day == 1&&month == 5) 
Console.WriteLine("30 Апреля");
if(day == 1&&month == 7) 
Console.WriteLine("30 Июля");
if(day == 1&&month == 10) 
Console.WriteLine("30 Сентября");
if(day == 1&&month == 11) 
Console.WriteLine("30 Октября");
    


if(month == 3&&day == 1)
{
    Console.WriteLine("28 Февраля.");
}

if(1 < day&&day< 32)
{
    day = day - 1;  
    Console.WriteLine("{0}", day);

if(month == 1)
Console.WriteLine("Января.");
if(month == 2)
Console.WriteLine("Февраля.");
if(month == 3)
Console.WriteLine("Марта.");
if(month == 4)
Console.WriteLine("Апреля.");
if(month == 5)
Console.WriteLine("Мая.");
if(month == 6)
Console.WriteLine("Июня.");
if(month == 7)
Console.WriteLine("Июля.");
if(month == 8)
Console.WriteLine("Августа.");
if(month == 9)
Console.WriteLine("Сентября.");
if(month == 10)
Console.WriteLine("Октября.");
if(month == 11)
Console.WriteLine("Ноября.");
if(month == 12)
Console.WriteLine("Декабря.");
}

if(month > 12|| day > 31)
Console.WriteLine("Введено неверное значение или месяца, или дня.");

