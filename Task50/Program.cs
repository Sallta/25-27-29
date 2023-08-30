// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер строки: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());


string GetArrayElement(int rowIndex, int columnIndex, int[,]array)
{
    int rows = array.GetLength(0);
    int columns=array.GetLength(1);
    if (rowIndex>=0 && rowIndex<rows && columnIndex>=0 && columnIndex<columns)
    {
        int element = array[rowIndex, columnIndex];
        return element.ToString();
    }
    else
    {
     return "Такого элемента нет";   
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
int result = GetArrayElement ();