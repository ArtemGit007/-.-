// Дано двузначное число. Определить: а) какая из его цифр больше: 
// первая или вторая; б) одинаковы ли его цифры.

Console.WriteLine("Введите первое двузначное число а:");  
int a = Convert.ToInt32(Console.ReadLine());

int i = a%10;
int j = a/10;

if(j < i)
{
    Console.WriteLine("Первая цифра {0} меньше второй {1}", j, i);
}
else
{
    Console.WriteLine("Первая цифра {0} больше второй1 {1}", j, i);

}

if(i == j)
{
    Console.WriteLine("Цифры {0} и {1} равны", j, i);
}
