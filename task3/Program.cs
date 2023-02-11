// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillMaxtrix(int[,] array)
{
  Random rand = new Random();
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = rand.Next(0, 10);
    }
  }
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

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
  int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

  for(int i = 0; i < result.GetLength(0); i++)
  {
    for(int j= 0; j < result.GetLength(1); j++)
    {
      int tempSum = 0;
      int tempMultip = 0;
      int counterI = 0;
      int counterJ = 0;

      while(counterJ < result.GetLength(1) && counterI < result.GetLength(0))
      {
        tempMultip = (matrix1[i, counterJ] * matrix2[counterI, j]);
        tempSum += tempMultip;
        tempMultip = 0;
        counterI++;
        counterJ++;
      }
      result[i, j] = tempSum;
      tempSum = 0;
    }
  }

  return result;
} 

int[,] matrix1 = new int[3,3];
int[,] matrix2 = new int[3,3];

FillMaxtrix(matrix1);
FillMaxtrix(matrix2);

int[,] result = MultiplicationMatrix(matrix1, matrix2);

ShowMatrix(matrix1);
System.Console.WriteLine("\t*");
ShowMatrix(matrix2);
System.Console.WriteLine("\t=");
ShowMatrix(result);