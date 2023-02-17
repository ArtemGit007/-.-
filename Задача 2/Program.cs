// Даны действительные числа x и у, не равные друг другу. 
// Меньшее из этих двух чисел заменить половиной их суммы, 
// а большее – их удвоенным произведением.

Console.WriteLine("Введите первое число х:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число y:");
int y = Convert.ToInt32(Console.ReadLine());
int t = x;

if(x < y)
{
    x = (x + y)/2;
    y = t*y*2;
    Console.WriteLine("{0}, {1}", x, y);
}


else
{
    
    x = x*y*2;
    y = (t + y)/2;
    Console.WriteLine("{0}, {1}", x, y);
}
   

 





