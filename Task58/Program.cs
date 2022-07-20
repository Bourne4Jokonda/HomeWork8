// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

int[,] matrix1 = new int[4, 4];
int[,] matrix2 = new int[4, 4];

void FillArray(int[,] arr)
{
      for (int i = 0; i < 4; i++)
      {
            for (int j = 0; j < 4; j++)
            {
                  arr[i, j] = new Random().Next(1, 10);
                  Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine();
      }
}
Console.WriteLine("Первый массив:");
FillArray(matrix1);
Console.WriteLine();
Console.WriteLine("Второй массив:");
FillArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение первого и второго массива:");
int[,] matrix3 = new int[4,4];
for (int i = 0; i < matrix3.GetLength(0); i++)
{
      for (int j = 0; j < matrix3.GetLength(1); j++)
      {
            matrix3[i,j]=matrix1[i,j]*matrix2[i,j];
            Console.Write("{0}\t", matrix3[i, j]);
      }
      Console.WriteLine();
}

