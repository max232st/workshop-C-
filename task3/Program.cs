/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
5 -> Пятница */

Console.WriteLine("Введите номер для недели");
int numberWeek = int.Parse(Console.ReadLine());
 
if (numberWeek < 1 || numberWeek > 7)
    {
    Console.WriteLine("НЕКОРЕКТНЫЙ ВВОД");
    }
if (numberWeek == 1)
{
    Console.WriteLine("Monday");
}
if (numberWeek == 2)
{
    Console.WriteLine("Tuesday");
}
if (numberWeek == 3)
{
    Console.WriteLine("Wednesday");
}
if (numberWeek == 4)
{
    Console.WriteLine("Thirsday");
}

if (numberWeek == 5)
{
    Console.WriteLine("Fridai");
}
if (numberWeek == 6)
{
    Console.WriteLine("Saturday");
}
if (numberWeek == 7)
{
    Console.WriteLine("Sunday");
}
