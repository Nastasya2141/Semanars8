/*Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

//КОД ОСНОВНОЙ ПРОГРАММЫ
int rows = GetNumberFromConsole("Введите количество строк");
int columns = GetNumberFromConsole("Введите количество столбцов");
int [,] array = new int [rows,columns];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortingArrayRows (array);
PrintArray(array);



//МЕТОДЫ

void SortingArrayRows (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int GetRandomValue()
{
    int array = new Random().Next(1,100);
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





