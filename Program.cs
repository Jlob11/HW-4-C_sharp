
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A} в степени {B} = {ToDegree}");


// Функция возведения в степень
int ToDegree(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}


// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
/*
int[] array = GetBinaryArray(8);
Console.WriteLine($"[{string.Join(",", array)}]");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i<size; i++){
        result[i] = new Random().Next(0,2000);
    }
return result;
}
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
/*
Console.WriteLine("Введи чило ");
int number = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма цифр в числе {number} = {sum}");

int sum(string number())
{
    int result = 1
    for(int i = 1; i <= number(); i++)
    {
        result = result + number();
    }
    return result;
}
*/