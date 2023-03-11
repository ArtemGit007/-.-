// Составить программу, которая по заданным году и номеру месяца определяет 
// количество дней в этом месяце. 

Console.WriteLine("Введите год:");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());

if(month ==2&&year%4 == 0)
Console.WriteLine("Февраль, 29 дней.");
if(month == 2&&year%4 !=0)
Console.WriteLine("Февраль, 28 дней.");
if(month ==1||month ==3||month ==5||month ==7||month ==8||month ==10||month ==12)
Console.WriteLine("В месяце 31 день.");
if(month ==4||month ==6||month ==9||month ==11)
Console.WriteLine("В месяце 30 дней.");
if(month > 12)
Console.WriteLine("Введено некорректное значение месяца.");



