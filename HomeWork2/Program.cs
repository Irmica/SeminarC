// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// int SecondDigit(int n)
// {
//     int d2 = ((n/10) % 10);
//     return d2;
// }

// Console.WriteLine("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SecondDigit(n));
//---------------------------------------------------------------------
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int n)
{
    if (n < 100) return -1;
    else
    {
        while ((n/1000)>1)
    {
        n = n/10;
        }
    int d3  = n % 10;
    return d3;
    }
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (ThirdDigit(num) == -1) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine(ThirdDigit(num));


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.


