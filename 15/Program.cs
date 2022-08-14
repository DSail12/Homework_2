// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6-> да
// 7-> да
//1-> нет



Console.WriteLine("Пожалуйста введите номер дня недели, чтобы узнать является ли он выходным\nПонедельник - день 1\nВторник - день 2\nСреда - день 3\nЧетверг - день 4\nПятница - день 5\nСуббота - день 6\nВоскресение - день 7");

Console.WriteLine("Введите номер дня недели");

string? indexString = Console.ReadLine();

int index = int.Parse(indexString!);

if (index == 1)
Console.WriteLine("Понедельник");

if (index == 2)
Console.WriteLine("Вторник");

if (index == 3)
Console.WriteLine("Среда");

if (index == 4)
Console.WriteLine("Четверг");

if (index == 5)
Console.WriteLine("Пятница");

if (index == 6)
Console.WriteLine("Суббота");

if (index == 7)
Console.WriteLine("Воскресение");

if (index == 6 || index == 7)

Console.WriteLine(index + " - является выходным днем");

else

if (index > 0 && index < 6)
Console.WriteLine(index + " - не является выходным днем");

else
Console.WriteLine("Некорректно введенное число - " + index + ". Не является днем недели.");
