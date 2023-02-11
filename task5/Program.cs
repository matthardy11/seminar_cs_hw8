// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] FillMaxtrix(int[,] array, int row, int col)
{
  int number = 00;
  if (array[0,0] == null)
  {
    array[0,0] = number;
    number++;
    FillMaxtrix(row, col+1);
    FillMaxtrix(row+1, col);
    FillMaxtrix(row, col-1);
    FillMaxtrix(row-1, col);
  }
  return array;
}

void ShowMatrix(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i,j] + "\t");
    }
    System.Console.WriteLine();
  }
}

int[,] matrix = FillMaxtrix(matrix, 0, 0);

ShowMatrix(Matrix);

