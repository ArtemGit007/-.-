// Составить программу, которая в зависимости 
// от порядкового номера дня недели (1, 2, ..., 7) 
// выводит на экран его название (понедельник, вторник, 
// ..., воскресенье).

Console.WriteLine("Введите номер дня недели:");
int weekday = Convert.ToInt32(Console.ReadLine());

if(weekday == 1)
Console.WriteLine("Понедельник.");
if(weekday == 2)
Console.WriteLine("Вторник.");
if(weekday == 3)
Console.WriteLine("Среда.");
if(weekday == 4)
Console.WriteLine("Четверг.");
if(weekday == 5)
Console.WriteLine("Пятница.");
if(weekday == 6)
Console.WriteLine("Суббота.");
if(weekday == 7)
Console.WriteLine("Воскресенье.");
if(weekday > 7)
Console.WriteLine("Введён неврный номер дня недели.");
