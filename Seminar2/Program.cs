// Задача 1. Напишите программу, которая выводит случайное трёхзначное
//  число и удаляет вторую цифру этого числа.

// int CutNumber(int num )
// {
//     int h = num /100;
//     int u = num % 10;

//     return h*10 + u;
// }

// int randNumber = new Random().Next(100, 1000);
// int result = CutNumber(randNumber);
// Console.WriteLine(randNumber);
// Console.WriteLine(result);
//-----------------------------------------------------------------------------
// Задача 2. Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int MaxDigit(int num)
// {
//     int d1 = num % 10;
//     int d2 = num/10;
//     int max = d1;
//     if (d2 > max) max = d2;
//     return max;
// }
// int num = new Random().Next(10, 100);
// int result = MaxDigit(num);
// Console.WriteLine(num);
// Console.WriteLine(result);
//---------------------------------------------------------------
// Задача 3. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно одновременно a и b.

// bool Multiplicity(int n, int a, int b)
// {
//     bool res = false;
//     if (n % a == 0 && n % b == 0)
//         res = true;
//     return res;
// }
// Console.Write("Введите проверяемое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первый делитель: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второй делитель: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Multiplicity(n, a, b));
//-------------------------------------------------------------------

// Задача 4. Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

bool Square(int a, int b)
{
    bool res = false;
    if ((a*a == b) || (b*b == a))
    res = true;
    return res;
}
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(a, b));