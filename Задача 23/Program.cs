// Дано натуральное число. Верно ли, что оно заканчивается нечетной цифрой?

Console.WriteLine("Введите натуральное число:");
int a = Convert.ToInt32(Console.ReadLine());

if(a%2 == 0)
{
    Console.WriteLine("Число {0} заканчивается четной цифрой", a);
}
else
{
    Console.WriteLine("Число заканчивается нечетной цифрой");
}