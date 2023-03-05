
//  Дата некоторого дня характеризуется тремя натуральными числами: 
// g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m 
// определить: дату предыдущего дня. Заданный год 
// не високосный.

Console.WriteLine("Введите год:");
int g = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите поярдковый номер месяца:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите порядковый номер дня:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("  ");

if(n == 1&&m == 2)
Console.WriteLine("31 Января {0} года.", g);
 if(n == 1&&m == 6)
Console.WriteLine("31 Мая  {0} года.", g);  
 
 if(n == 1&&m == 4)
Console.WriteLine("31 Марта {0} года.", g);   
 if(n == 1&&m == 8)
Console.WriteLine("31 Июля  {0} года.", g);  
 if(n == 1&&m == 9)
Console.WriteLine("31 Августа  {0} года.", g);  
 if(n == 1&&m == 11)
Console.WriteLine("31 Октября  {0} года.", g);  
 if(n == 1&&m == 1)
Console.WriteLine("31 Декабря  {0} года.", (g - 1));  

if(n == 1&&m == 5) 
Console.WriteLine("30 Апреля  {0} года.", g);
if(n == 1&&m == 7) 
Console.WriteLine("30 Июня {0} года.", g);
if(n == 1&&m == 10) 
Console.WriteLine("30 Сентября {0} года.", g);
if(n == 1&&m == 12) 
Console.WriteLine("30 Ноября  {0} года.", g);
    
if(m == 3&&n == 1&&(g% 4 == 1||g% 4 == 2||g% 4 == 3||g% 4 == 4||g% 4 == 5||g% 4 == 6||g% 4 == 7||g% 4 == 8||g% 4 == 9))
Console.WriteLine("28 Февраля {0} года.", g);
if(m == 3&&n == 1&&g%4 == 0) 
Console.WriteLine("29 Февраля {0} года.", g); 


if(n > 1&&n<= 31)
{
    n = n - 1;  
    Console.WriteLine(" {0} года", n);

if(m == 1)
Console.WriteLine("Января  {0} года.",  g);
if(m == 2)
Console.WriteLine("Февраля  {0} года.", g);
if(m == 3)
Console.WriteLine("Марта  {0} года.", g);
if(m == 4)
Console.WriteLine("Апреля  {0} года.", g);
if(m == 5)
Console.WriteLine("Мая  {0} года.", g);
if(m == 6)
Console.WriteLine("Июня  {0} года.", g);
if(m == 7)
Console.WriteLine("Июля  {0} года.", g);
if(m == 8)
Console.WriteLine("Августа  {0} года.", g);
if(m == 9)
Console.WriteLine("Сентября  {0} года.", g);
if(m == 10)
Console.WriteLine("Октября  {0} года.", g);
if(m == 11)
Console.WriteLine("Ноября  {0} года.", g);
if(m == 12)
Console.WriteLine("Декабря  {0} года.", g);
}

if(m > 12|| n > 31)
Console.WriteLine("Введено неверное значение или месяца, или дня.");