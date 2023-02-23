// Известны год и номер месяца рождения человека, 
// а также год и номер месяца сегодняшнего дня (январь – 1 и т. д.). 
// Определить возраст человека (число полных лет). 
// В случае совпадения указанных номеров месяцев считать, 
// что прошел полный год.

DateTime date1 = new DateTime(1999, 7, 1);
DateTime datenow = DateTime.Now;
DateTime date2 = new DateTime(datenow.Subtract(date1).Ticks);
Console.WriteLine(date2);