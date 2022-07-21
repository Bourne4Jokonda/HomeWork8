// Задача 62: Заполните спирально массив 4 на 4.
int[,] square = new int[4, 4];
int[] EndPos = new int[0];
int line = square.GetLength(0);
int column = square.GetLength(1);
int size = line * column;

for (int k = 1; k < size; k++)
{
      for (int i = 0; i < line; i++)
      {
            for (int j = 0; j < column; j++)
            {


                  square[i, j] = k;
                  Console.Write("{0}\t", square[i, j]);
                  if (i <= line)
                  {
                        square[i, j] = k;
                        if (j <= column)
                        {
                              j = column - 1;
                              square[i, j] = k;
                        }


                  }
                  column--;
                  Console.WriteLine();
            }
            line--;
      }
}
Console.WriteLine();
for (int i = 0; i < square.GetLength(0); i++)
{
      for (int j = 0; j < square.GetLength(1); j++)
      {
            Console.Write("{0}\t", square[i, j]);
      }
      Console.WriteLine();
}
// void Spiral(int[,] arr)
// {
//       int sz = line * column;
//       for (int i = 0; i < line; i++)
//       {
//             for (int j = 0; j < column; j++)
//             {
//                   for (int k = 1; k < sz; k++)
//                   {
//                         arr[i, j] = k;
//                         Console.Write("{0}\t", arr[i, j]);
//                         if (i == line - 1)
//                         {

//                         }
//                   }
//                   column--;
//                   Console.WriteLine();
//             }
//             line--;
//       }
// }

// Spiral(square);