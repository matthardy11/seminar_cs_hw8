// Напишите программу, которая заполнит спирально массив 4 на 4.

void FillMaxtrix(int[,] array)
{
  int number = 1;
  int counterI = 0;
  int counterJ = 0;
  int startI = 0;
  int finishI = 0;
  int startJ = 0;
  int finishJ = 0;

  while(number  <= array.GetLength(0) * array.GetLength(1))
  {
    array[counterI, counterJ] = number;
    if(counterI == startI && counterJ < array.GetLength(1) - finishJ -1 )
      {counterJ++;}
    else if(counterJ == array.GetLength(1) - finishJ -1 && counterI < array.GetLength(0) - finishI -1)
      {counterI++;}
    else if(counterI == array.GetLength(0) - finishI - 1 && counterJ > startJ)
      {counterJ--;}
    else
      {counterI--;}
      
    if((counterI == startI +1) && (counterJ == startJ) && (startJ != array.GetLength(1) - finishJ -1))
    {
      startI++;
      startJ++;
      finishI++;
      finishJ++;  
    }
    number++;
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

int[,] matrix = new int[4,4];

FillMaxtrix(matrix);
ShowMatrix(matrix);

            
