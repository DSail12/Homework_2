// Задача 10
// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число.\nИ получите на выходе вторую цифру числа.\nВыход из программы exit.");
while (true)
{
    string input = Console.ReadLine();
    if(!input.Equals("exit"))
    Console.WriteLine("{0}->{1}", input, input[1]);
    else
    break;
    
}