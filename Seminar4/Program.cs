//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// int GetSum (int a)
// {
//     int sum = 0;
// for (int i = 1; i <= a; i += 1)
//         sum = sum + i;
// return sum;
// }
// Console.Write("Введите число а: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetSum(a)); 

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int CountDig(int k)
// {
//     int c = 1;
//     while (k > 9)
//       {  k = k / 10;
//         c += 1;
//       }
// return c;
// }
// Console.Write("Введите число а: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountDig(a)); 


// // Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int Factorial (int a)
// {
//     int fact = 1;
// for (int i = 1; i <= a; i += 1)
//          fact = fact * i;
//  return fact;
// }
// Console.Write("Введите число а: ");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine(Factorial(a)); 

//Создание и заполнение рандом массива
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i+=1)
       array[i] = new Random().Next(minValue, maxValue +1);
    return array;   
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length;i +=1)
     Console.Write(array[i] + " ");
Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]newArray = CreateRandomArray(s, min, max);
ShowArray(newArray);


