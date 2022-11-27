// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine()); 
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);

Console.WriteLine("Сортировка по строкам: ");
int[] row = new int[columns];
for (int i = 0; i < rows; i++ )
{
    for (int j = 0; j < columns; j++)
    row[j] = array[i, j];
    BubbleSort(row);
    Insert(true, i, row, array);
}
PrintArray(array);

void Insert(bool isRow, int dim, int[] source,int[,] dest) // метод Insert — это вспомогательный метод, с помощью которого мы меняем значения в строке или столбце исходного массива на отсортированные значения
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
        dest[dim,k] = source[k];
        else
        dest[k,dim] = source[k];
    }
}
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

void BubbleSort(int[] inArray)
{
   for (int i = 0; i < inArray.Length; i++)
   {
    for (int j = 0; j < inArray.Length - i - 1; j++ )
    {
        if (inArray[j] < inArray[j+1]) // if (inArray[j] > inArray[j+1]) - упорядочит по возрастанию элементы каждой строки двумерного массива
        {
            int temp = inArray[j];
            inArray[j] = inArray[j+1];
            inArray[j+1] = temp;    
        }
    }
   } 
}

