//   Дано целое число k (1 <= k <= 365). 
// Написать программу определения:  каким днем недели 
//(понедельником, вторником, ..., субботой или воскресеньем) 
//является k-й день невисокосного года, в котором 1-ым января является пятница. 

Console.WriteLine("Введите число от 1 до 365:");
int weekday = Convert.ToInt32(Console.ReadLine());

if((weekday == 1|(weekday)%7 == 1)&&weekday < 366)
Console.WriteLine("Пятница.");
if((weekday == 2|(weekday)%7 == 2)&&weekday < 366)
Console.WriteLine("Суббота.");
if((weekday == 3|(weekday)%7 == 3)&&weekday < 366)
Console.WriteLine("Воскресенье.");
if((weekday == 4|(weekday)%7 == 4)&&weekday < 366)
Console.WriteLine("Понедельник.");
if((weekday == 5|(weekday)%7 == 5)&&weekday < 366)
Console.WriteLine("Вторник.");
if((weekday == 6|(weekday)%7 == 6)&&weekday < 366)
Console.WriteLine("Среда.");
if((weekday == 7|(weekday)%7 == 0)&&weekday < 366)
Console.WriteLine("Четверг.");
if(weekday > 366)
Console.WriteLine("Введено некорректное значение.");
