// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

// int[,] CreateRandomArray2D()
// {
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of colums: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] myArray = CreateRandomArray2D();
// Show2DArray(myArray);

// Задайте двумерный массив размера m на n,
//  каждый элемент в массиве находится по формуле: 
// Aij = i+j. 
// Выведите полученный массив на экран.

// int[,] CreateRandomArray2D(int n, int m)
// {
//     int[,] array = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             array[i, j] = i + j;;

//         }
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Write("Input a quantity of rows: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of colums: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandomArray2D(n, m);
// Show2DArray(myArray);


// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, 
// и замените эти элементы на их квадраты
// int[,] CreateRandomArray2D()
// {
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of colums: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// // Задайте двумерный массив. Найдите элементы, 
// // у которых оба индекса чётные, 
// // и замените эти элементы на их квадраты
// void FoundElements(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i += 2)
//     {
//         for (int j = 0; j < array.GetLength(1); j += 2)
//         {
//             array[i, j] = array[i, j] * array[i, j];
//         }
//     }
// }
// int[,] myArray = CreateRandomArray2D();
// Show2DArray(myArray);
// FoundElements(myArray);
// Show2DArray(myArray);


// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся 
// на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// int[,] CreateRandomArray2D()
// {
//     Console.Write("Input a side of matrix: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     // Console.Write("Input a quantity of colums: ");
//     // int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, rows];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < rows; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// // Задайте двумерный массив. 
// // Найдите сумму элементов, находящихся 
// // на главной диагонали 
// // (с индексами (0,0); (1;1) и т.д.
// int FoundElements(int[,] array)
// {int res = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     res = res+ array[i, i];
// }return res;
// }
// int[,] myArray = CreateRandomArray2D();
// Show2DArray(myArray);
// FoundElements(myArray);
// int res = FoundElements(myArray);
// Console.WriteLine(res);



//Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.
int[,] CreateRandomArray2D()
{
    Console.Write("Input a quantity of rows: ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    

    int[,] array = new int[num  , num + 1];
    for (int i = 1; i < num  ; i++)
    {
        for (int j = 1; j < num ; j++)
        {
            array[i, 0] = 1;
            array[i, j] = array[i -1 ,j] + array[i -1 ,j -1];
            
        }
    }
    return array;
}
void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandomArray2D();
Show2DArray(myArray);