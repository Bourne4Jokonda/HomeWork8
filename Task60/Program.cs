// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int[,,] cube = new int[3, 3, 3];
void Main(int[,,] arr)
{
      Random r = new Random();
      for (int i = 0; i < cube.GetLength(0); i++)
      {
            for (int j = 0; j < cube.GetLength(1); j++)
            {
                  for (int k = 0; k < cube.GetLength(2); k++)
                  {
                        cube[i, j, k] = r.Next(100);
                        cube[i, j, k] = new Random().Next(10, 100);
                        if (cube[i, j, k] <= 10)
                        {
                              cube[i, j, k] = r.Next(100);
                        }
                        Console.Write("{0}\t", cube[i, j, k]);

                  }
                  Console.WriteLine();
            }
            Console.WriteLine();
      }
}
Console.WriteLine("Трехмерный массив: ");
Main(cube);
for (int i = 0; i < cube.GetLength(0); i++)
{
      for (int j = 0; j < cube.GetLength(1); j++)
      {
            Console.Write("Строка массива: ");
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                  Console.Write("{0}\t", cube[i, j, k]);
            }
      Console.WriteLine();
      }
}