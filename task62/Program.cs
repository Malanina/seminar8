//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.Clear();
int n = 4;
int[,] array = new int[n, n];

int num = 1;
PrintArray(array);

        for (int delta = 0; delta < n - 2; delta++)
        {
            for (int i = 0 + delta; i < n - delta; i++)
            {
                array[0 + delta, i] = num;
                num++;
            }
            num--;
            for (int i = 0 + delta; i < n - delta; i++)
            {
                array[i, 4 - delta] = num;
                num++;
            }
            num--;
            for (int i = n - 1 - delta; i >= 0 + delta; i--)
            {
                array[4 - delta, i] = num;
                num++;
            }
            num--;
            for (int i = n - 1 - delta; i >= 1 + delta; i--)
            {
                array[i, 0 + delta] = num;
                num++;
            }
        }


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
         Console.Write($"{array[i, j]}");
        }
    Console.WriteLine();
    }
}



