 // Известны год и номер месяца рождения человека, 
// а также год и номер месяца сегодняшнего дня (январь – 1 и т. д.). 
// Определить возраст человека (число полных лет). 
// В случае совпадения указанных номеров месяцев считать, 
// что прошел полный год.

Console.WriteLine("Введите год рождения человека:");
int year1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц рождения человека:");
int month1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите текущий год:");
int year2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите текущий месяц:");
int month2 = Convert.ToInt32(Console.ReadLine());

if((month2 - month1) < 0)
{
    int year = (2000 - year1) + ((year2 - 1 )- 2000);
    Console.WriteLine(year);
}

else 
{
    Console.WriteLine((2000 - year1) + (year2 - 2000));
}






