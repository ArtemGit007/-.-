// Написать программу определения имеется ли среди чисел а, b, с 
// хотя бы одна пара взаимно противоположных чисел.

Console.WriteLine("введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число c:");
int c = Convert.ToInt32(Console.ReadLine());

int b1 = b*(-1);

if(a != b1)
{
    Console.WriteLine("{0} и {1} - не пара взаимно противоположных чисел", a, b);
}
else
{
    Console.WriteLine("{0} и {1} - пара взаимно противоположных чисел", a, b);
}

int c1 = c*(-1);
if(a != c1)
{
    Console.WriteLine("{0} и {1} - не пара взаимно противоположных чисел", a, c);
}
else
{
    Console.WriteLine("{0} и {1} - пара взаимно противоположных чисел", a, c);
}

if(b != c1)
{
    Console.WriteLine("{0} и {1} - не пара взаимно противоположных чисел", b, c);
}
else
{
    Console.WriteLine("{0} и {1} - пара взаимно противоположных чисел", b, c);
}