//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindMinRow(int[,] array)
{
  int index = 0;
  int temp = 0;
  int sumNextRow = 0;
  for(int i = 0; i < 1; i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      temp += array[i, j];  
    }
  }

  for(int i = 1; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      sumNextRow += array[i, j]; 
    }
    if(sumNextRow < temp)
    {
      temp = sumNextRow;
      index = i;
      sumNextRow = 0;
    }
    else{sumNextRow = 0;}
  }
  System.Console.WriteLine($"Строка с наименьшей суммой элементов: {index}");
}

void ShowSumRows(int[,] array)
{
  int sum = 0;
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i, j];
    }
    System.Console.WriteLine($"Сумма строки {i} = {sum}");
    sum = 0;
  }
}

int[,] matrix = new int[5,5];

FillMaxtrix(matrix);
ShowMatrix(matrix);
System.Console.WriteLine();
ShowSumRows(matrix);
System.Console.WriteLine();
FindMinRow(matrix);



