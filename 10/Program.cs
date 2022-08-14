// Задача 10
// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456-> 5
// 782-> 8
// 918-> 1

Console.WriteLine("Введите трехзначное число.\nИ получите на выходе вторую цифру числа.");

string? indexString = Console.ReadLine();

var index = int.Parse(indexString!);

if (index < 0)
    index *= (-1);

if (index > 99 && index < 1000)

{
    index /= 10;
    long result = index % 10;
    Console.WriteLine("Результат:" + result);
}

    else
    {
        Console.WriteLine("Вы ввели не трехзначное число. Попробуйте снова.");
    }