﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
//int N = 2;

if (number >= 2)
{
    int N = 2;
    while (N <= number)
    {
        Console.Write(N);
        Console.Write(", ");
        N = N + 2;
    }
}
else Console.Write("Не верно задано число");