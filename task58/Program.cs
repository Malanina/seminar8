// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine()); 
if (columns1 != rows2);
{
    Console.WriteLine("Умножение таких матриц невозможно!");
    return;
}

int[,] arrayA = new int[rows1, columns1];
int[,] arrayB = new int[rows2, columns2];
FillArray(arrayA);
PrintArray(arrayA);
Console.WriteLine("Первая матрица:");
FillArray(arrayB);
PrintArray(arrayB);
Console.WriteLine("Вторая матрица:");
PrintArray(Mult(arrayA, arrayB));

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++ )
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

int[,] Mult(int[,] arrayA, int[,] arrayB)
{
int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
for (int i = 0; i < arrayA.GetLength(0); i++)
{
    for (int j = 0; j < arrayB.GetLength(0); j++ )
    {
        for (int k = 0; k < arrayB.GetLength(1); k++)
        {
        arrayC [i, j] += arrayA [i, k] * arrayB [k, j];
        }
    }
}
return arrayC;
}

