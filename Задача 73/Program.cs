//Написать программу, которая по данному натуральному числу 
// от 1 до 12 (номеру месяца) выдает все приходящиеся 
// на этот месяц праздничные дни (например, если введено число 1, 
// то: 1 января – Новый год, 7 января – Рождество).

Console.WriteLine("Введите номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());

if(month == 1&&month < 13)
Console.WriteLine("Новый Год 1 января и Рождество Христово 7 января.");
if(month == 2&&month < 13)
Console.WriteLine("День защитника Отечества	23 февраля.");
if(month == 3&&month < 13)
Console.WriteLine("Международный женский день 8 марта.");
if(month == 4&&month < 13)
Console.WriteLine("В этом месяце без официальных праздников.");
if(month == 5&&month < 13)
Console.WriteLine("Праздник Весны и Труда 1 мая и День Победы 9 мая.");
if(month == 6&&month < 13)
Console.WriteLine("День России 12 июня.");
if(month == 7&&month < 13)
Console.WriteLine("В этом месяце без официальных праздников.");
if(month == 8&&month < 13)
Console.WriteLine("В этом месяце без официальных праздников.");
if(month == 9&&month < 13)
Console.WriteLine("В этом месяце без официальных праздников.");
if(month == 10&&month < 13)
Console.WriteLine("В этом месяце без официальных праздников.");
if(month == 11&&month < 13)
Console.WriteLine("День народного единства	4 ноября.");
if(month == 12&&month < 13)
Console.WriteLine("В этом месяце без официальных праздников.");
if(month > 12)
Console.WriteLine("Введите верное значение номера месяца.");

