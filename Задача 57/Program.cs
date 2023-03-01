//Составить программу, которая в зависимости от порядкового номера 
//  месяца (1, 2, ..., 12) 
// выводит на экран время года, к которому относится этот месяц.


Console.WriteLine("Введите номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());

if(month == 12||(month == 1)||(month == 2))
Console.WriteLine("На дворе зима.");

if(month == 3||(month == 4)||(month == 5))
{
    Console.WriteLine("Весна - красна.");
}


if(month == 6||month == 7||month == 8)
Console.WriteLine("Лето на дворе.");

if(month == 9||month == 10||month == 11)
Console.WriteLine("Осень.");
if(month > 12)
Console.WriteLine("Введен неверный номер.");