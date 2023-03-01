// Составить программу, которая в зависимости от порядкового 
// номера месяца (1, 2, ..., 12) выводит на экран количество дней 
// в этом месяце. Рассмотреть случай, 
// когда год не является високосным.

Console.WriteLine("Введите номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());

if(month == 1||month == 3||month == 5||month == 7||month == 8||month == 10||month == 12)
Console.WriteLine("В месяце 31 день.");
if(month == 4||month == 6||month == 9||month == 11)
Console.WriteLine("В месяце 30 дней.");
if(month == 2)
Console.WriteLine("В месяце 28 дней.");
if(month > 12)
Console.WriteLine("Введен неверный номер месяца.");
