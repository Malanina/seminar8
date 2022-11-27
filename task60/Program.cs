// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных 
// чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
static class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int[,,] myArray = new int[2, 2, 2];

        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                for (int k = 0; k < myArray.GetLength(2); k++)
                {
                    myArray[i, j, k] = random.Next(10, 99);
                }
            }
        }


        for (int i = 0; i < myArray.GetLength(0); i++) 
    {
       for (int j = 0; j < myArray.GetLength(1); j++)
       {
        for (int k = 0; k < myArray.GetLength(2); k++) 
        {
            Console.Write("myArray[i, j, k]");
        }
        Console.WriteLine();
       }
    Console.ReadLine();
    }
}
}


//void WriteArray(int[,,] array)
//{
    //for (int i = 0; i < array.GetLength(0); i++)
    //{
        //for (int j = 0; j < array.GetLength(1); j++)
        //{
            //for (int k = 0; k < array.GetLength(2); k++)
            //{
                //Console.WriteLine("array[i, j, k]");
            //}
            //Console.WriteLine();
        //}
        //Console.WriteLine();
    //}
//}