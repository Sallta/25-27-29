﻿// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234]-> 2


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] array = CreateArrayRndInt(10, 0, 99);
PrintArray(array);
Console.WriteLine();
FindEven(array);
void FindEven(int[] MyArray)
{
    int even = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] % 2 == 0)
        {
            even = even + 1;
        }
    }
    Console.WriteLine($"Чётных чисел {even}");
}

