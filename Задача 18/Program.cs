// Даны объемы и массы двух тел из разных материалов. 
// Материал какого из тел имеет большую  плотность?
// p = m/V

Console.WriteLine("Введите массу первого тела");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  объем первого тела");
int v1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите массу второго тела");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  объем второго тела");
int v2 = Convert.ToInt32(Console.ReadLine());


if(m1/v1 < m2/v2)
{
    Console.WriteLine("Материал второго тела имеет большую плотность");
}
else 
{
    Console.WriteLine("Материал первого тела имеет большую плотность");
}
