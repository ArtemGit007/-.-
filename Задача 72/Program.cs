// НаПисать Программу, которая По вводимому числу от 1 до 11 
// (номеру класса) выдает соответствующее сообщение 
// «Привет, k-классник». НаПример, если k = 1,
// «Привет, Первоклассник»; При k = 4: «Привет, четвероклассник».

Console.WriteLine("Введите число от 1 до 11");
int classnumber = Convert.ToInt32(Console.ReadLine());

if(classnumber == 1&&classnumber < 12)
Console.WriteLine("Привет, Первоклассник!");
if(classnumber == 2&&classnumber < 12)
Console.WriteLine("Привет, второклассник!");
if(classnumber == 3&&classnumber < 12)
Console.WriteLine("Привет, третьеклассник!");
if(classnumber == 4&&classnumber < 12)
Console.WriteLine("Привет, четвероклассник!");
if(classnumber == 5&&classnumber < 12)
Console.WriteLine("Привет, пятиклассник!");
if(classnumber == 6&&classnumber < 12)
Console.WriteLine("Привет, шестиклассник!");
if(classnumber == 7&&classnumber < 12)
Console.WriteLine("Привет, семиклассник!");
if(classnumber == 8&&classnumber < 12)
Console.WriteLine("Привет, восьмиклассник!");
if(classnumber == 9&&classnumber < 12)
Console.WriteLine("Привет, девятиклассник!");
if(classnumber == 10&&classnumber < 12)
Console.WriteLine("Привет, десятиклассник!");
if(classnumber == 11&&classnumber < 12)
Console.WriteLine("Привет, одинадцатиклассник!");
if(classnumber > 11)
Console.WriteLine("Привет, введите верное значение.");
