﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     Console.Write($"{num1} - большее число, {num2} - меньшее число");
// }
// else Console.Write($"{num2} - большее число, {num1} - меньшее число");

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;

// if(num2 > max)
// max = num1;
// if(num3> max)
// max = num3;

// Console.Write($"{max} - большее число.");

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 2 == 0)
// Console.Write("Число четное");
// else
// Console.Write("Число нечетное");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= num)
{
    if (current % 2 == 0)
        Console.Write($"{current}, ");
    current++;
}
