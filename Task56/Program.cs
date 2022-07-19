// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] massive = new int[4, 3];
int []sum=new int [massive.GetLength(0)];
int LineSum=0;
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
            int sums = 0;
            sums = sums + massive[i, j];
            sum[i]=sums;
            Console.Write(sum[i]);
            sums =0;
      }

Console.WriteLine();
}
LineSum(int arr[a])
for (int i = 0; i < sum.Length; i++)
{
      LineSum=LineSum+sum[i];
}