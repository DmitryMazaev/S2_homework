﻿/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
if (a>99 && a<1000)
{
    int b = a%100;
    int c = b/10;
    Console.WriteLine("Вторая цифра числа: "+c);
}
else 
{
    Console.WriteLine("Число не трехзначное, попробуйте еще раз");
}