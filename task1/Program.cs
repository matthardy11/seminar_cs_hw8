//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillMaxtrix(int[,] array)
{
  Random rand = new Random();
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = rand.Next(0, 100);
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

void SortMatrixString(int[,] array)
{
  int temp = 0;
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      for(int e = j+1; e < array.GetLength(1); e++)
      {  
        if (array[i,j] < array[i, e])
        { 
          temp = array[i,j];
          array[i,j] = array[i, e];
          array[i, e] = temp;
        }
      }  
    }
  }
}

int[,] matrix = new int[5,5];

FillMaxtrix(matrix);
ShowMatrix(matrix);

System.Console.WriteLine();

SortMatrixString(matrix);
ShowMatrix(matrix);