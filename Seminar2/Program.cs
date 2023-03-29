// Задача 1. Напишите программу, которая выводит случайное трёхзначное
//  число и удаляет вторую цифру этого числа.

int CutNumber(int num )
{
    int h = num /100;
    int u = num % 10;
    
    return h*10 + u;
}

int randNumber = new Random().Next(100, 1000);
int result = CutNumber(randNumber);
Console.WriteLine(randNumber);
Console.WriteLine(result);

