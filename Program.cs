// Задача 54: Задайте двумерный массив. DONE!!!!!!!!!!!!
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Console.WriteLine("введите количество строк и стобцов матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,]matrix = new int[m,n];
void FillArray(int [,] matr)
{
for (int i=0; i < matr.GetLength(0); i++)
{
    for (int j=0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(0,10);
    }
   }
}
void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Select(matrix);
PrintArray(matrix);
void Select(int [,] arra)
{
for (int i=0; i <matrix.GetLength(0); i++)
{
    for (int j=0; j < matrix.GetLength(1); j++)
    {
        for (int u = 0; u<matrix.GetLength(1)-1; u++ )
        {
            if (matrix[i,u]<matrix [i, u+1])
            {
                int count = matrix[i, u+1];
                matrix[i, u+1] = matrix[i,u];
                matrix[i,u] = count;
            }
        }
        
    }
}
}

    //Задача 56: Задайте прямоугольный двумерный массив. DONE /////////////////////////////////////////////////////////////////////////////
        //Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        Console.WriteLine("введите количество строк и стобцов матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,]matrix = new int[m,n];
void FillArray(int [,] matr)
{
for (int i=0; i < matr.GetLength(0); i++)
{
    for (int j=0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(0,10);
    }
   }
}
void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}
FillArray(matrix);
PrintArray(matrix);
int Sum(int[,] arr, int i)
{
  int sumLine = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sumLine += arr[i,j];
  }
  return sumLine;
}
int minSum = 0;
int sumLine = Sum(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int u = Sum(matrix, i);
  if (sumLine > u)
  {
    sumLine = u;
    minSum = i;
  }
}
Console.Write($"{minSum+1} - строка, cумма-({sumLine})");*/



        
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц./////////////////////////
Console.WriteLine("введите количество стобцов и строк");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,]matrix = new int[m,n];
int[,]matrix2 = new int[m,n];
void FillArray(int [,] matr)
{
for (int i=0; i < matr.GetLength(0); i++)
{
    for (int j=0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(0,10);
    }
   }
}
void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}
int[,] result = new int[m,n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
matr(matrix, matrix2, result);
PrintArray(result);

void matr(int[,] matrix, int[,] matrix2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
        sum = matrix[i,j] * matrix2[i,j];
        result[i,j] = sum;
    }
  }
}     