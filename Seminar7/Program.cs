// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int [,] CreateRandom2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите min: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите max: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];
//     for(int i= 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//          array[i,j] =  new Random().Next(minValue, maxValue +1);
//         }

//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//            Console.Write(array[i, j] + " ");
//         Console.WriteLine();   
//     }
//     Console.WriteLine();

// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
// int [,] CreateRandom2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];
//     for(int i= 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//          array[i,j] =  i+j;
//         }

//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//            Console.Write(array[i, j] + " ");
//         Console.WriteLine();   
//     }
//     Console.WriteLine();

// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// // Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// int [,] CreateRandom2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите min: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите max: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];
//     for(int i= 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//          array[i,j] =  new Random().Next(minValue, maxValue +1);
//         }

//     }
//     return array;
// }

//Задайте двумерный массив. Найдите сумму элементов, находящихся 
//на главной диагонали (с индексами (0,0); (1;1) и т.д.

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