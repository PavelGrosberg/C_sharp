﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

System.Console.WriteLine("Введите А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int exp = 1;
for (int i = 0; i < numberB; i++)
{
    exp *= numberA;
}

System.Console.WriteLine($"{numberA}, {numberB} -> {exp}");