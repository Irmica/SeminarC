// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArrayPositiveThreeDigit(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(100, 1000);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i += 1)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int CounterEvenNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < (array.Length - 1); i++)
//         if (array[i] % 2 == 0)
//             count++;
// return count;
// }

// Console.Write("Введите размер генерируемого массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreateArrayPositiveThreeDigit(size);

// Console.Write("Сгенерированный массив: ");
// ShowArray(newArray);
// Console.WriteLine($"Количество четных чисел в сгенериванном массиве: {CounterEvenNumbers(newArray)}");

//-------------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateArray(int minValue, int maxValue, int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int SumOddPositions(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//         sum += array[i];
//     return sum;
// }

// Console.Write("Введите минимальное число для генерации элементов массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимально число для генерации элементов массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер генерируемого массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array1 = CreateArray(minValue, maxValue, size);
// Console.Write("Сгенерированный массив: ");
// ShowArray(array1);
// Console.Write($"Сумма элементов массива, находящихся на нечетных позициях: {SumOddPositions(array1)} ");

//-----------------------------------------------------------------------------------------------------















// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76