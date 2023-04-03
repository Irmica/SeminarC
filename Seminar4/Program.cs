//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int GetSum (int a)
{
    int sum = 0;
for (int i = 1; i <= a; i += 1)
        sum = sum + i;
return sum;
}
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSum(a)); 
