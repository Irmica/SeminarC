// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int Quadrant(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     else return -1;
// }
// Console.WriteLine("Введите x: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Quadrant(num1, num2));

// Задача 3. Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 2D пространстве.

// double Length(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
// }
// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(Length(x1, y1, x2, y2), 2));


// Задача 4. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

void Sqr (int n)
{
    int index = 1;
    while (index <= n)
    {Console.WriteLine($"{index} - {Math.Pow(index, 2)}");
    index +=1;}
}
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Sqr (n);