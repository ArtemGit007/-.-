//Имеется пронумерованный список деталей: 1) шуруп, 2) гайка, 3) винт, 4) гвоздь, 5) болт. Составить программу, 
//которая по номеру детали выводит на экран её название.
Console.WriteLine("введите номер интструмента:");
int tools = Convert.ToInt32(Console.ReadLine());
if(tools == 1)
{
    Console.WriteLine("Шуруп");
}
if(tools == 2)
{
    Console.WriteLine("Гайка");
}
if(tools == 3)
{
    Console.WriteLine("Винт");
}
if(tools == 4)
{
    Console.WriteLine("Гвоздь");
}
if(tools == 5)
{
    Console.WriteLine("Болт");
}
if((tools != 1)&&(tools != 2)&&(tools != 3)&&(tools != 4)&&(tools != 5))
{
    Console.WriteLine("Введено неверное число.");
}




