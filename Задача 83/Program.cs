﻿// Игральным картам условно присвоены следующие порядковые номера 
// в зависимости от их достоинства: "валету" – 11, "даме" – 12, "королю" – 13, 
// "тузу" – 14. Порядковые номера остальных карт соответствуют их названиям 
// ("шестерка", "девятка" и т. п.). По заданному номеру карты k (6 k 14) 
// определить достоинство соответствующей карты.

Console.WriteLine("Введите достоинство карты:");
int n = Convert.ToInt32(Console.ReadLine());

if(n > 14||n < 6)
Console.WriteLine("Вы не разбираетесь в картах, либо ввели неверный номер масти или достоинства карты, либо колода 54 карты");


if(n == 6)
Console.WriteLine("Шестерка");
if(n == 7)
Console.WriteLine("Семёрка");
if(n == 8)
Console.WriteLine("Восьмёрка");
if(n == 9)
Console.WriteLine("Девятка");
if(n == 10)
Console.WriteLine("Десятка");
if(n == 11)
Console.WriteLine("Валет");
if(n == 12)
Console.WriteLine("Дама ");
if(n == 13)
Console.WriteLine("Король");
if(n == 14)
Console.WriteLine("Туз");
