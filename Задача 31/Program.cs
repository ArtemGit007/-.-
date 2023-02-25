// Заполнить массив случайными рандомными числами от 0 до 36, длина массива 10
Random r = new Random();
int size = 10;
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    arr[i] = r.Next(0, 36);
    Console.Write(arr[i] + " ");
}


