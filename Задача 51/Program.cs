// Составить программу, определяющую результат гадания на ромашке
// – «любит – не любит», 
// взяв за исходное данное количество лепестков n.

Console.WriteLine("Введите количество лепестков n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение соответствующее перпвому лепестку - любит - 1, не любит 2");
int firststep = Convert.ToInt32(Console.ReadLine());
 
if((firststep == 2&&n%2 == 0)||(firststep == 1&&n%2 !=2))
{
    Console.WriteLine("Любит!!!");
}
if((firststep == 1&&n%2 == 0)||(firststep == 2&&n%2 !=2))
{
    Console.WriteLine("Вообще не любит(((");
}
