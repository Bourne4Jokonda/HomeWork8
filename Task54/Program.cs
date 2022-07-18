// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива

int[,] massive = new int[3, 4];
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

void BubbleSort(int[,] arr)
      {
	for (int i = 0; i < arr.GetLength(0); i++)
		for (int j = 0; j < arr.GetLength(1) - 1; j++)
			if (arr[i,j] > arr[i,j + 1])
				{
                              int max = arr[i,j];
					arr[i,j] = arr[i,j+1];
					arr[i,j+1] = max;
                              Console.WriteLine(arr[i,j]);
				}
                  else
                  {
                        j++;
                  }
	}
 
BubbleSort(massive);

for (int i = 0; i < massive.GetLength(0); i++)
{
      for (int j = 0; j < massive.GetLength(1); j++)
      {
            Console.Write(massive[i, j] + " ");
      }
      Console.WriteLine();
}
Console.WriteLine();