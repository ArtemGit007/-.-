// Составить программу, которая для любого натурального числа 
// печатает количество цифр в записи этого числа.

Console.WriteLine("Введите натуральное число:");
int x = Convert.ToInt32(Console.ReadLine());

if(x> 0&&x < 10)
Console.WriteLine("В числе одна цифра.");
if(x> 10&&x < 100)
Console.WriteLine("В числе две цифры.");
if(x> 100&&x <1000)
Console.WriteLine("В числе три цифры.");
if(x> 1000&&x < 10000)
Console.WriteLine("В числе четыре цифры.");
if(x> 10000&&x < 100000)
Console.WriteLine("В числе пять цифр.");
if(x> 100000&&x < 1000000)
Console.WriteLine("В числе шесть цифр.");
if(x> 1000000&&x < 10000000)
Console.WriteLine("В числе семь цифр.");
if(x> 10000000&&x < 100000000)
Console.WriteLine("В числе восемь цифр.");
if(x> 100000000&&x < 1000000000)
Console.WriteLine("В числе девять цифр.");
if(x> 1000000000&&x < 10000000000)
Console.WriteLine("В числе десять цифр.");
if(x> 10000000000&&x < 100000000000)
Console.WriteLine("В числе одинадцать цифр.");
if(x> 100000000000&&x < 1000000000000)
Console.WriteLine("В числе двенадцать цифр.");
if(x> 1000000000000&&x < 10000000000000)
Console.WriteLine("В числе тринадцать цифр.");
if(x> 100000000000000)
Console.WriteLine("В числе более, чем 13 цифр.");

