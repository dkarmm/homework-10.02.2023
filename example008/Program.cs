﻿//Задача 8: Напишите программу, которая на вход принимает число 
//(N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int first_digit = 1;
while (first_digit <= number)
{
    if (first_digit % 2 == 0)
    {
        Console.Write(first_digit + " ");
    }
    first_digit = first_digit + 1;
}