// Мастям игральных карт условно присвоены следующие 
//порядковые номера: масти  пики" – 1, масти "трефы" – 2, 
//масти "бубны" – 3, масти "червы" – 4, а достоинству карт: "валету"
// – 11, "даме" – 12, "королю" – 13, "тузу" – 14 
//(порядковые номера карт остальных достоинств соответствуют 
//их названиям: "шестерка", "девятка" и т. п.). 
//По заданным номеру масти m (1 m 4) и номеру достоинства карты 
//k (6 k 14) определить полное название (масть и достоинство) 
//соответствую пикей карты в виде "Дама пикей", "Шестерка бубен" и т. п

Console.WriteLine("Введите номер масти:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите достоинство карты:");
int n = Convert.ToInt32(Console.ReadLine());

if(m > 4||n > 14||n < 6)
Console.WriteLine("Вы не разбираетесь в картах, либо ввели неверный номер масти или достоинства карты, либо колода 54 карты.");


if(m == 1&&n == 6&&(m < 5&&n < 15))
Console.WriteLine("Шестерка пикей");
if(m == 1&&n == 7&&(m < 5&&n < 15))
Console.WriteLine("Семёрка пикей");
if(m == 1&&n == 8&&(m < 5&&n < 15))
Console.WriteLine("Восьмёрка пикей");
if(m == 1&&n == 9&&(m < 5&&n < 15))
Console.WriteLine("Девятка пикей");
if(m == 1&&n == 10&&(m < 5&&n < 15))
Console.WriteLine("Десятка пикей");
if(m == 1&&n == 11&&(m < 5&&n < 15))
Console.WriteLine("Валет пикей");
if(m == 1&&n == 12&&(m < 5&&n < 15))
Console.WriteLine("Дама  пикей");
if(m == 1&&n == 13&&(m < 5&&n < 15))
Console.WriteLine("Король пикей");
if(m == 1&&n == 14&&(m < 5&&n < 15))
Console.WriteLine("Туз пикей");

if(m == 2&&n == 6&&(m < 5&&n < 15))
Console.WriteLine("Шестерка крестей");
if(m == 2&&n == 7&&(m < 5&&n < 15))
Console.WriteLine("Семёрка треф");
if(m == 2&&n == 8&&(m < 5&&n < 15))
Console.WriteLine("Восьмёрка треф");
if(m == 2&&n == 9&&(m < 5&&n < 15))
Console.WriteLine("Девятка треф");
if((m == 2&&n == 10)&&(m < 5&&n < 15))
Console.WriteLine("Десятка треф");
if(m == 2&&n == 11&&(m < 5&&n < 15))
Console.WriteLine("Валет треф");
if(m == 2&&n == 12&&(m < 5&&n < 15))
Console.WriteLine("Дама  треф");
if(m == 2&&n == 13&&(m < 5&&n < 15))
Console.WriteLine("Король треф");
if(m == 2&&n == 14&&(m < 5&&n < 15))
Console.WriteLine("Туз крестей");



if((m == 3&&n == 6)&&(m < 5&&n < 15))
Console.WriteLine("Шестерка бубей");
if(m == 3&&n == 7&&(m < 5&&n < 15))
Console.WriteLine("Семёрка бубей");
if(m == 3&&n == 8&&(m < 5&&n < 15))
Console.WriteLine("Восьмёрка буби");
if(m == 3&&n == 9&&(m < 5&&n < 15))
Console.WriteLine("Девятка буби");
if(m == 3&&n == 10&&(m < 5&&n < 15))
Console.WriteLine("Десятка буби");
if(m == 3&&n == 11&&(m < 5&&n < 15))
Console.WriteLine("Валет бубей");
if(m == 3&&n == 12&&(m < 5&&n < 15))
Console.WriteLine("Дама  бубей");
if(m == 3&&n == 13&&(m < 5&&n < 15))
Console.WriteLine("Король бубей");
if(m == 3&&n == 14&&(m < 5&&n < 15))
Console.WriteLine("Туз бубей");


if(m == 4&&n == 6&&(m < 5&&n < 15))
Console.WriteLine("Червовая шестёрка");
if(m == 4&&n == 7&&(m < 5&&n < 15))
Console.WriteLine("Червовая семёрка");
if(m == 4&&n == 8&&(m < 5&&n < 15))
Console.WriteLine("ВЧервовая восьмёрка");
if(m == 4&&n == 9&&(m < 5&&n < 15))
Console.WriteLine("Червовая девятка");
if(m == 4&&n == 10&&(m < 5&&n < 15))
Console.WriteLine("Червовая Десятка");
if(m == 4&&n == 11&&(m < 5&&n < 15))
Console.WriteLine("Червовый Валет");
if(m == 4&&n == 12&&(m < 5&&n < 15))
Console.WriteLine("Червовая Дама");
if(m == 4&&n == 13&&(m < 5&&n < 15))
Console.WriteLine("Червовый Король");
if(m == 4&&n == 14&&(m < 5&&n < 15))
Console.WriteLine("Червовый Туз");

