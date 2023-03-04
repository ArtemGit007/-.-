//Дата некоторого дня характеризуется двумя натуральными числами: m (порядковый номер месяца) 
// и n (число). По заданным n и m определить: дату следующего дня (принять, что n и m не характеризуют 31 декабря). 
// Примечание: принять, что год не является високосным.

Console.WriteLine("Введите поярдковый номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите порядковый номер дня:");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("  ");

if(day == 31&&month == 1)
Console.WriteLine("1 Февраля");
 if(day == 31&&month == 5)
Console.WriteLine("1 Июня.");  
 
 if(day == 31&&month == 3)
Console.WriteLine("1 Апреля.");   
 if(day == 31&&month == 7)
Console.WriteLine("1 Августа.");  
 if(day == 31&&month == 8)
Console.WriteLine("1 Сентября.");  
 if(day == 31&&month == 10)
Console.WriteLine("1 Ноября.");  
 if(day == 31&&month == 12)
Console.WriteLine("1 Января.");  

if(day == 30&&month == 4) 
Console.WriteLine("1 Мая.");
if(day == 30&&month == 6) 
Console.WriteLine("1 Июля");
if(day == 30&&month == 9) 
Console.WriteLine("1 Октября.");
if(day == 30&&month == 10) 
Console.WriteLine("1 Ноября.");
    


if(month == 2&&day == 28)
{
    Console.WriteLine("1 Марта.");
}

if(1 <= day&&day<= 30&&(month != 2&&day != 28))
{
    day = day + 1;  
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