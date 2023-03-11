// Составить программу, которая по заданным году и номеру месяца определяет 
// количество дней в этом месяце. 

Console.WriteLine("Введите год:");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());
if(year < 0) year = year*(-1);
if(month > 12)
Console.WriteLine("Введено некорректное значение месяца.");
if(month ==2&&year%4 == 0)
Console.WriteLine("Февраль, 29 дней.");
if(month == 2&&year%4 !=0)
Console.WriteLine("Февраль, 28 дней.");
if(month ==1)
Console.WriteLine("Январь 31 день.");
if(month ==3)
Console.WriteLine("Март 31 день.");
if(month ==5)
Console.WriteLine("Май 31 день.");
if(month ==7)
Console.WriteLine("Июль 31 день.");
if(month ==8)
Console.WriteLine("Август 31 день.");
if(month ==10)
Console.WriteLine("Октябрь 31 день.");
if(month ==12)
Console.WriteLine("Декабрь 31 день.");


if(month ==4)
Console.WriteLine("Апрель 30 дней.");
if(month ==6)
Console.WriteLine("Июнь 30 дней.");
if(month ==9)
Console.WriteLine("Сентябрь 30 дней.");
if(month ==11)
Console.WriteLine("Ноябрь 30 дней.");