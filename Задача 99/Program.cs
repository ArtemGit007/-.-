// Дано целое число k (1 <= k <= 365). Написать программу определения, каким днем недели 
//(понедельником, вторником, ..., субботой или воскресеньем) является k-й день 
// невисокосного года, в котором 1 января вторник.

Console.WriteLine("Введите номер дня:");
int day = Convert.ToInt32(Console.ReadLine());
day = 0;

if(day ==1||day%7 ==0)
Console.WriteLine("Понедельник.");
if(day ==2||day%7 ==1)
Console.WriteLine("Втоник.");
if(day ==3||day%7 ==2)
Console.WriteLine("Среда.");
if(day ==4||day%7 ==3)
Console.WriteLine("Четверг.");
if(day ==5||day%7 ==4)
Console.WriteLine("Пятница.");
if(day ==6||day%7 ==5)
Console.WriteLine("Суббота.");
if(day ==7||day%7 ==4)
Console.WriteLine("Воскресенье.");

if(day > 7||day< 0)
Console.WriteLine("Введен неверый номер.");





