// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreateRandomArray2D()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
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
// int[,] SortColums(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 1; i < array.GetLength(0); i++)
//         {
//             int key = array[i, j];
//             int k = i - 1;
//             while (k >= 0 && array[k, j] > key)
//             {
//                 array[k + 1, j] = array[k, j];
//                 k = k - 1;
//             }
//             array[k + 1, j] = key;
//         }
//     }
//     return array;
// }
// int[,] SortRows(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i = 1; i < array.GetLength(1); i++)
//         {
//             int key = array[j, i];
//             int k = i - 1;
//             while (k >= 0 && array[j, k] > key)
//             {
//                 array[j, k + 1] = array[j, k];
//                 k = k - 1;
//             }
//             array[j, k + 1] = key;
//         }
//     }
//     return array;
// }
// int[,] myArray = CreateRandomArray2D();
// Show2DArray(myArray);
// Console.Write("Отсортировать по строкам - введите '0', отсортировать по столбцам - введите '1': ");
// int f = Convert.ToInt32(Console.ReadLine());
// if (f == 0)
// {
//     int[,] myArraySort = SortRows(myArray);
//     Show2DArray(myArraySort);
// }
// if (f == 1)
// {
//     int[,] myArraySort = SortColums(myArray);
//     Show2DArray(myArraySort);
// }
// if (f != 1 && f != 0)
//     Console.WriteLine("Неправильный выбор. Подумайте и запустите код повторно.");

//-------------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// int[,] CreateRandomArray2D()
// {
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, colums];
// for (int i = 0; i < rows; i++)
// {
// for (int j = 0; j < colums; j++)
// {
// array[i, j] = new Random().Next(minValue, maxValue + 1);

// }
// }
// return array;
// }
// void Show2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i, j] + " ");
// }
// Console.WriteLine();
// }
// Console.WriteLine();
// }

// int MinSumElementsRows(int[,] array)
// {
//     int k = 0;
//     int min = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int s = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             s = s + array[i, j];
//         }
//         if (i == 0) min = s;

//         if (s < min)
//         {
//             min = s;
//             k = i + 1;
//         }
//     }
//     return k;
// }
// int[,] myArray = CreateRandomArray2D();
// Show2DArray(myArray);
// Console.Write("Строка с наименьшей суммой элементов: ");
// Console.Write(MinSumElementsRows(myArray));

//---------------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] CreateRandomArray2D(int rows, int colums, int minValue, int maxValue)
// {
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

// int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
// {
//     int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
//     for (int k = 0; k < array1.GetLength(1); k++)
//     {
//         for (int i = 0; i < array1.GetLength(0); i++)
//         {
//             for (int j = 0; j < array2.GetLength(1); j++)
//             {
//                 array[i, j] += array1[i, k] * array2[k, j];
//             }
//         }
//     }
//     return array;
// }
// Console.Write("Введите количество строк первой матрицы: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов первой матрицы: ");
// int colums1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение первой матрицы: ");
// int minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение первой матрицы: ");
// int maxValue1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество строк второй матрицы: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов второй матрицы: ");
// int colums2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение второй матрицы: ");
// int minValue2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение второй матрицы: ");
// int maxValue2 = Convert.ToInt32(Console.ReadLine());

// while (colums1 != rows2)
// {
//     Console.WriteLine("Матрицы не могут быть перемножены!");
//     Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы");
//     Console.Write("Введите количество столбцов первой матрицы: ");
//     colums1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество строк второй матрицы: ");
//     rows2 = Convert.ToInt32(Console.ReadLine());
// }

// int[,] Matrix1 = CreateRandomArray2D(rows1, colums1, minValue1, maxValue1);
// int[,] Matrix2 = CreateRandomArray2D(rows2, colums2, minValue2, maxValue2);
// int[,] MatrixRes = MultiplicationMatrix(Matrix1, Matrix2);


// Show2DArray(Matrix1);
// Show2DArray(Matrix2);
// Show2DArray(MatrixRes);

//-------------------------------------------------------------------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] CreateRandomArray3D()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите глубину: ");
//     int depth = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,,] array = new int[rows, colums, depth];
//     for (int d = 0; d < depth; d++)
//     {
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < colums; j++)
//             {
//                 array[i, j, d] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     }
//     return array;
// }
// void Show3DArray(int[,,] array)
// {
//     for (int d = 0; d < array.GetLength(2); d++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j, d]}({i},{j},{d}) ");
//             }
//             Console.WriteLine();
//         }
//     }
//     Console.WriteLine();
// }

// int [,,] My3DArray = CreateRandomArray3D();
// Show3DArray(My3DArray);
//----------------------------------------------------------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

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
int[,] CreateSpiralArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];
    int k = 1;
    for (int p = 0; p < (colums / 2); p++)
    {
        for (int j = p; j < colums - p; j++)
        {
            array[p, j] = k;
            k += 1;
        }
        for (int i = p + 1; i < rows - p; i++)
        {
            array[i, colums - p - 1] = k;
            k += 1;
        }
        for (int j = colums - p - 2; j > p - 1; j--)
        {
            array[rows - p - 1, j] = k;
            k += 1;
        }
        for (int i = rows - p - 2; i > p; i--)
        {
            array[i, p] = k;
            k += 1;
        }
    }
    return array;
}

int[,] Spiral = CreateSpiralArray();
Show2DArray(Spiral);