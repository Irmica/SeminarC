// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// double Degree(double a, int b)
// {
//     double result = 1;
//     for (int i = 1; i <= b; i += 1)
//         result = result * a;
//     return result;
// }
// Console.Write("Введи число а, которое будем возводить в степень: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите натуральное число b, степень, в которую необходимо возвести число а: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Число {a} в степени {b} равно {Degree(a, b)}");

//------------------------------------------------------------------------------------------

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumDigit(int a)
// {
//     int sum = 0;
//     while (a > 1)
//     {
//         sum += a % 10;
//         a = a / 10;
//     }
// return sum;
// }

// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Сумма цифр числа {b} равна {SumDigit(b)}");

//----------------------------------------------------------------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i += 1)
        Console.Write(array[i] + " ");
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArray(size);
ShowArray(newArray);
