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
void BubbleSort(int[,] Array)
      {
            for (int i = 0; i < Array.GetLength(1); i++)
            {
                for (int j = 0; j < Array.GetLength(1) - 1; j++)
                  {
                    for (int k = 0; k < Array.GetLength(1)-1; k++)
                    {
                        if(Array[k,j]>Array[k,j+1])
                        {
                              int temp=Array[k,j+1];
                              Array[k,j+1]=Array[k,j];
                              Array[k,j]=temp;
                              temp=0;
                        }
                    }
                    
                       
                  }
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