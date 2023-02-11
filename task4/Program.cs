// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillMaxtrix(int[,,] array)
{
  Random rand = new Random();
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      for(int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = rand.Next(10, 100); 
      }
    }
  }
}

void ShowMatrix(int[,,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
       for(int k = 0; k < array.GetLength(2); k++)
      {
        System.Console.Write(array[i,j,k] + $" Индекс элемента ({i},{j},{k}) \t");
        
      }
      System.Console.WriteLine();
    }
    System.Console.WriteLine();
  }
}

int[,,] matrix = new int[3, 3, 3];

FillMaxtrix(matrix);
ShowMatrix(matrix);