﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();

Console.Write("Введите число: ");

string? number = Console.ReadLine();

void CheckNumber(string number)
{
    if (number[0] == number[4] || number[1]==number[3])
    {
        Console.WriteLine($"{number} - палиндром");
    }
    
    else Console.WriteLine($"{number} - не палиндром");

}

if (number!.Length == 5)
{
    CheckNumber(number);
}

else Console.WriteLine("Введи пятизначное число");