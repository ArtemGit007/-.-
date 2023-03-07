// Для каждой введенной цифры (0-9) вывести соответствующее ей название 
// на английском языке (0 – zero, 1 – one, 2 – two, ...).

Console.WriteLine("Введите цифру от 0 до 9:");
int x = Convert.ToInt32(Console.ReadLine());

if(x == 0)
Console.WriteLine("Zero.");
if(x == 1)
Console.WriteLine("One.");
if(x == 2)
Console.WriteLine("Two.");
if(x == 3)
Console.WriteLine("Three.");
if(x == 4)
Console.WriteLine("Four.");
if(x == 5)
Console.WriteLine("Five.");
if(x == 6)
Console.WriteLine("Six.");
if(x == 7)
Console.WriteLine("Seven.");
if(x == 8)
Console.WriteLine("Eight.");
if(x == 9)
Console.WriteLine("Nine.");
if(x > 10)
Console.WriteLine("Mistake.");


