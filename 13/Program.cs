// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645-> 5
// 78-> третьей цифры нет
// 32679-> 6


Console.WriteLine("Введите число.\nИ получите на выходе третью цифру числа. \nИли узнайте, что ее нет.");

string? indexString = Console.ReadLine();

int index = int.Parse(indexString!);

if (index < 0)
    index *= (-1);

if (index > 99)
{
    Console.WriteLine("Результат:" + index.ToString()[2]);
}
else
{
    Console.WriteLine("Третья цифра в числе отсутствует.");
}