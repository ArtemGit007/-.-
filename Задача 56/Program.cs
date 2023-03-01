// Написать программу, которая по номеру месяца 
// выдает название следующего за ним месяца 
// (при m = 1 получаем февраль, 4 – май).

Console.WriteLine("Введите номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());

if(month == 1)
Console.WriteLine("Февраль.");

if(month == 2)
Console.WriteLine("Март.");
if(month == 3)
Console.WriteLine("Апрель.");
if(month == 4)
Console.WriteLine("Май.");
if(month == 5)
Console.WriteLine("Июнь.");
if(month == 6)
Console.WriteLine("Июль.");
if(month == 7)
Console.WriteLine("Август.");
if(month == 8)
Console.WriteLine("Сентябрь.");
if(month == 9)
Console.WriteLine("Октябрь.");
if(month == 10)
Console.WriteLine("Ноябрь.");
if(month == 11)
Console.WriteLine("Декабрь.");
if(month == 12)
Console.WriteLine("Январь.");
if(month > 12)
{
    Console.WriteLine("Введен неверный  номер.");
}
