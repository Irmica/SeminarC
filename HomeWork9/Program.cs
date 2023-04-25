// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
// void ShowNums(int num)
// {
//     Console.Write(num + " ");
//     if(num > 1) ShowNums(num - 1);    
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowNums(num);
//-----------------------------------------------------------------------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int Total(int m, int n)
// {
//     if (n > m) return Total(m+1, n)+m;
//     else if (m > n ) return Total(n+1, m) + n;
//     else return m;
// }
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Сумма натуральных элементов: {Total(m,n)}");
//-----------------------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m!=0 ) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Ackermann(m, n));