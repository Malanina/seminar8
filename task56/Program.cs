// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] array = new int[4, 4];
FillArray(array);

void FillArray(int[,] array)
{
  for (int i = 0; i < 4; i++)
  {
    for (int j = 0; j < 4; j++ )
    {
        array[i, j] = new Random().Next(0, 10);
    }
  }

}

void PrintArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
 {
     for (int j = 0; j < array.GetLength(1); j++ )
     {
         Console.Write($"{array[i, j]} ");
     }
     Console.WriteLine();
 }
}

    int row = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minsum += array[0, i];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            row = i;
        }
    }

Console.WriteLine($"Строка с наименьшей суммой элементов = {row+1}");
Console.WriteLine();
PrintArray(array);

