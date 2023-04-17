//Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.**Любые строки массива

// int[,] CreateRandom2DArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue+ 1);

//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if (row1 >= 0 && row1 < array.GetLength(0) &&
//         row2 >= 0 && row2 < array.GetLength(0) &&
//         row1 != row2)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 int temp = array[row1, j];
//                 array[row1, j] = array[row2, j];
//                 array[row2, j] = temp;
//             }
//         }
//     else
//     {
//         Console.Write("Вы ввели некорректный номер строк.");
//     }
// }

// int[,] myArray = CreateRandom2DArray();
// Show2DArray(myArray);

// Console.Write("Введите номер первой строки, которую вы хотите заменить: ");
// int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите номер второй строки, которую вы хотите заменить: ");
// int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

// ChangeRows(myArray, r1, r2);
// Show2DArray(myArray);

//------------------------------------------------------------------------------------------------------
// Задача 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

// int[,] CreateRandom2DArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue+ 1);

//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeRowsColumns(int[,] array)
// {
//     if (array.GetLength(0) == array.GetLength(1))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
// }

// int[,] myArray = CreateRandom2DArray();
// Show2DArray(myArray);
// ChangeRowsColumns(myArray);
// Show2DArray(myArray);

//-----------------------------------------------------------------------------------------------------------


//Задача 3. Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.
//найти индексы наименьшего элемента и вывести новый массив, игнорируя те самые найденные строку и солбец

// int[,] CreateRandom2DArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue+ 1);

//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] SearchElement(int[,] array)
// {
//     int[] indexes = {0, 0};
//     // int min = array[0, 0];
//     // int rowElement = 0;
//     // int columnsElement = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array[i, j] < array[indexes[0], indexes[1]])
//             {
//                 // min = array[i, j];
//                 // rowElement = i;
//                 // columnsElement = j;
//                 indexes[0] = i;
//                 indexes[1] = j;
//             }
//         }
//     }
//     return indexes;
// }

// int[,] DeleteRowsColumns(int[,] array, int[] indexes)
// {
//     int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];


//     for (int i = 0, m = 0; i < array.GetLength(0); i++)
//     {
//         if (i != indexes[0])
//         {
//             for (int j = 0, n = 0; j < array.GetLength(1); j++)
//             {
//                 if (j != indexes[1])
//                 {
//                     result[m, n] = array[i, j];
//                     n++;
//                 }
//             }
//             m++;
//         }
//     }
//     return result;
// }

// int[,] myArray = CreateRandom2DArray();
// Show2DArray(myArray);
// int[,] endResult = DeleteRowsColumns(myArray, SearchElement(myArray));
// Show2DArray(endResult);