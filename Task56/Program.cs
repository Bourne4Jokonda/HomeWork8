// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] massive = new int[4, 3];
int[] sum = new int[massive.GetLength(0)];

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
            sum[i] = sum[i] + massive[i, j];
            Console.Write(sum[i]+" ");
      }
      Console.WriteLine();
}

int MinElement(int[] array)
        {
            int minElement = array[0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                    if (minElement > array[i])
                    {
                        minElement = array[i];
                    }
            }
            // Console.WriteLine(minElement);
            Console.WriteLine($"Строка с суммой {minElement} является наименьшей строкой");
            return minElement;
        }
MinElement(sum);
