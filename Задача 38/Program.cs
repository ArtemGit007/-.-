// Даны целые числа m, n. Если числа не равны, то заменить каждое из них 
// одним и тем же числом, равным большему из исходных, 
// а если равны, то заменить числа нулями. 

Console.WriteLine("Введите значение числа m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение числа n:");
int n = Convert.ToInt32(Console.ReadLine());


if( n !=  m)
if(n > m)
{
    m = n;
    Console.WriteLine("Большее из исходных число {0}", n);
}
else 
{
    n = m;
    Console.WriteLine("Большее из исходных число {0}", m); 
}

else
{
    n = 0;
    m = 0;
    Console.WriteLine("Числа равны, им  присвоено значение {0}.", n);
}











