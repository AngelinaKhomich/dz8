/*Задача 54: Задайте двумерный массив. Напишите программу, 
 которая упорядочит по убыванию элементы каждой строки двумерного массива.*/ 
/*void FillArray(int[,] array) 
{ 
  
 for (int i =0; i<array.GetLength(0);i++) 
 for (int j =0; j<array.GetLength(1);j++) 
             
 array[i,j] = new Random().Next(0,10); 
             
} 
 
void SortToLower(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            for (int k = 0; k < array.GetLength(1) - 1; k++) 
            { 
                if (array[i, k] < array[i, k + 1]) 
                { 
                    int temp = array[i, k + 1]; 
                    array[i, k + 1] = array[i, k]; 
                    array[i, k] = temp; 
                } 
            } 
        } 
    } 
} 
void PrintArray(int[,] array) 
{ 
 for (int i =0; i<array.GetLength(0);i++) 
        { 
 for (int j =0; j<array.GetLength(1);j++) 
 Console.Write($"{array[i,j],3}\t") ; 
 Console.WriteLine(); 
        }        
} 
 
int [,] table = new int [3,4]; 
FillArray(table); 
PrintArray(table); 
SortToLower(table); 
Console.WriteLine(); 
PrintArray(table);*/ 
 
/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/ 
 
 
/*int[,] table = new int[4, 4]; 
FillArrayRandom(table); 
PrintArray(table); 
Console.WriteLine(); 
NumberRowMinSumElements(table); 
 
 
 
void NumberRowMinSumElements(int[,] array) 
{ 
    int minRow = 0; 
    int minSumRow = 0; 
    int sumRow = 0; 
    for (int i = 0; i < table.GetLength(1); i++) 
    { 
        minRow += table[0, i]; 
    } 
    for (int i = 0; i < table.GetLength(0); i++) 
    { 
        for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j]; 
        if (sumRow < minRow) 
        { 
            minRow = sumRow; 
            minSumRow = i; 
        } 
        sumRow = 0; 
    } 
    Console.Write($"{minSumRow + 1} строка"); 
} 
 
void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
} 
 
 
void FillArrayRandom(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = new Random().Next(1, 10); 
        } 
    } 
} 
 
*/ 
 
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
 
/* 
int rows = ReadInt("Введите количество строк: "); 
int columns = ReadInt("Введите количество столбцов: "); 
int[,] array = new int[rows, columns]; 
int[,] secondArray = new int[rows, columns]; 
int[,] resultArray = new int[rows, columns]; 
 
FillArrayRandom(array); 
PrintArray2D(array); 
 
Console.WriteLine(); 
 
FillArrayRandom(secondArray); 
PrintArray2D(secondArray); 
 
Console.WriteLine(); 
 
if (array.GetLength(0) != secondArray.GetLength(1)) 
{ 
    Console.WriteLine(" Нельзя перемножить "); 
    return; 
} 
for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < secondArray.GetLength(1); j++) 
    { 
        resultArray[i, j] = 0; 
        for (int k = 0; k < array.GetLength(1); k++) 
        { 
            resultArray[i, j] += array[i, k] * secondArray[k, j]; 
        } 
    } 
} 
 
PrintArray2D(resultArray); 
 
 
int ReadInt(string message) 
{ 
    Console.Write(message); 
    return Convert.ToInt32(Console.ReadLine()); 
} 
 
 
void FillArrayRandom(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = new Random().Next(1, 10); 
        } 
    } 
} 
 
 
void PrintArray2D(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
} 
*/ 
/*Задача60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
 Напишите программу, которая будет построчно выводить массив, 
 добавляя индексы каждого элемента.
 массив размером 2 x 2 x 2*/

/*int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);
