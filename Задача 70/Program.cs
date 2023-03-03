// Для целого числа k от 1 до 99 напечатать фразу 
// «Мне k лет», учитывая при этом, что при некоторых значениях 
// k слово «лет» надо заменить на слово «год» или «года». 
// Например, 11 лет, 22 года, 51 год.

Console.WriteLine("введите значение года рождения от 1 до 199:");
int year = Convert.ToInt32(Console.ReadLine());

if((year != 111)|(year == 3)|(year%10 == 2)|(year%10 == 3)|(year%10 == 4)|(year == 2)|(year == 4))
{
    Console.WriteLine("Мне {0} года", year);
}
if((year == 111)|(year == 5)|(year == 6)|(year == 7)|(year == 8)|(year == 9)|(year%10 == 5)|(year%10 == 6)|(year%10 == 7)|(year%10 == 8)|(year%10 == 9)|(year%10 == 0))
{
    Console.WriteLine("Мне {0} лет", year);
}
if((year == 1)|(year%10 == 1)&&(year != 111))
{
    Console.WriteLine("Мне {0} год", year);
}
