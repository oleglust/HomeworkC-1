﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Enter num1: ");
  int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter num2: ");
  int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter num3: ");
  int num3 = int.Parse(Console.ReadLine());
  int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
    Console.WriteLine(+max);  
