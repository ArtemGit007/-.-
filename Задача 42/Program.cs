// Написать программу определения,
// является ли целое число N четным двузначным числом.
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

if(n > 9&&n < 100&&n%2 == 00)
{
    Console.WriteLine("Число {0} - четное двузначное", n);
}
else 
{
    Console.WriteLine("Число {0} - не четное двузначное", n);
}
