// Дано целое число k (1 <= k <= 365). 
// Определить, каким днем недели 
// (понедельником, вторником, ..., субботой или воскресеньем) 
// является k-й день високосного года, в котором 1 января среда.

Console.WriteLine("Введите число от 1 до 365:");
int n = Convert.ToInt32(Console.ReadLine());

if(n == 1|(n)%7 == 1)
Console.WriteLine("Среда.");
if(n == 2|(n)%7 == 2)
Console.WriteLine("Четверг.");
if(n == 3|(n)%7 == 3)
Console.WriteLine("Пятница.");
if(n == 4|(n)%7 == 4)
Console.WriteLine("Суббота.");
if(n == 5|(n)%7 == 5)
Console.WriteLine("Воскресенье.");
if(n == 6|(n)%7 == 6)
Console.WriteLine("Понедельник.");
if(n == 7|(n)%7 == 0)
Console.WriteLine("Вторник.");

if((n) > 366)
Console.WriteLine("Введено некорректное значение.");

