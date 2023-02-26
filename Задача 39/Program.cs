// Написать программу Определения правильности даты, введенной с клавиатуры (число – от 1 до 31, месяц – от 1 до 12). 
// Если введены некорректные данные, то сообщить об этом.

Console.WriteLine("Введите месяц от 1 до 12");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день от 1 до 31");
int day = Convert.ToInt32(Console.ReadLine());

if(month > 12|day>31)
{
    Console.WriteLine("Введены некорректные данные");
}
else 
{
    Console.WriteLine("Введены корректные данные");
}