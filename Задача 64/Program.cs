// Составить программу, которая по данному числу (1-12) 
// выводит название соответствующего ему месяца.

Console.WriteLine("Введите номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());

if(month == 1)
Console.WriteLine("Январь.");
if(month == 2)
Console.WriteLine("Февраль.");
if(month == 3)
Console.WriteLine("Март.");
if(month == 4)
Console.WriteLine("Апрель.");
if(month == 5)
Console.WriteLine("Май.");
if(month == 6)
Console.WriteLine("Июнь.");
if(month == 7)
Console.WriteLine("Июль.");
if(month == 8)
Console.WriteLine("Август.");
if(month == 9)
Console.WriteLine("Сентябрь.");
if(month == 10)
Console.WriteLine("Октябрь.");
if(month == 11)
Console.WriteLine("Ноябрь.");
if(month == 12)
Console.WriteLine("Декабрь.");
if(month > 12)
Console.WriteLine("Введено неверный номер месяца.");
