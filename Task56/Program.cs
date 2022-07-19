// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] massive = new int[4, 3];
int []sum=new int [massive.GetLength(1)];
int sumset =0;
for (int i = 0; i < massive.GetLength(0); i++)
{
      for (int j = 0; j < massive.GetLength(1); j++)
      {
            massive[i, j] = new Random().Next(1, 10);
            Console.Write(massive[i, j] + " ");
      }
      Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < massive.GetLength(0); i++)
{
      for (int j = 0; j < massive.GetLength(1); j++)
      {
         sum[i]=sum[i]+massive[i,j];   
      }
}

for (int i = 1; i <= sum.Length; i++)
      {
      int min=sum[i-1];
      if(sum[i-1]<sum[i])
      {
            sum[i-1]=min;
      }
      Console.WriteLine($"Строка {i} с суммой {min} является наименьшей строкой");
      }