﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int number2 = number/10;
Console.WriteLine($"Ответ: {number2%10}");
