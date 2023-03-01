//Составить программу, позволяющую получить словесное описание 
// школьных отметок (1 – плохо, 2 – неудовлетворительно, 
// 3 – удовлетворительно, 4 – хорошо, 5 – отлично).

Console.WriteLine("Введите значение отметки от 1 до 5");
int mark = Convert.ToInt32(Console.ReadLine());

if(mark == 1)
Console.WriteLine("Плохо.");
if(mark == 2)
Console.WriteLine("Неудовлетворительно.");
if(mark == 3)
Console.WriteLine("Удовлетворительно.");
if(mark == 4)
Console.WriteLine("Хорошо.");
if(mark == 5)
Console.WriteLine("Отлично.");
if(mark > 5)
Console.WriteLine("Введено неверное значение отметки.");
