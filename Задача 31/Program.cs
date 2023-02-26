// Заполнить массив случайными рандомными числами от 0 до 36, длина массива 10
Console.WriteLine("Введите число спинов:");
int size = Convert.ToInt32(Console.ReadLine());
Random r = new Random();
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    arr[i] = r.Next(0, 36);
    Console.Write(arr[i] + " ");
}

