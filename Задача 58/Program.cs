/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


//КОД ОСНОВНОЙ ПРОГРАММЫ
int rows = GetNumberFromConsole("Введите количество строк");
int columns = GetNumberFromConsole("Введите количество столбцов");
int[,] array = new int[rows, columns];
int[,] SecondArray = new int[rows, columns];
int[,] result = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(SecondArray);
PrintArray(SecondArray);
Console.WriteLine();



for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < SecondArray.GetLength(1); j++)
    {
        result[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            result[i, j] += array[i, k] * SecondArray[k, j];
        }
    }
  }

PrintArray(result);


//МЕТОДЫ

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue()
{
    int array = new Random().Next(1,10);
    return array;
}


void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = GetRandomValue();
        }
    }
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}








