/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] InitialMatrix(int line, int column)
{
    Random random = new Random();
    int[,] matrix = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = random.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] Average(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    double summ = 0;
    int k = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ = summ + matrix[i, j];
        }
        average[k] = Math.Round(summ / matrix.GetLength(0), 1);
        summ = 0;
        k++;
    }
    return average;
}

void PrintArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
}

Random randomNumber = new Random();
int line = randomNumber.Next(2, 5);
int column = randomNumber.Next(2, 5);

int[,] matrix = InitialMatrix(line, column);
PrintMatrix(matrix);
double[] average = Average(matrix);
PrintArray(average);