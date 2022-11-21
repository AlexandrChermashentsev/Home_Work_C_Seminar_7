/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента,
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] InitialArray(int line, int column)
{
    Random random = new Random();
    int[,] matrix = new int[line, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 10);
        }
    }
    return matrix;
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

int GetIndexUser(string message)
{
    Console.WriteLine(message);
    int userIndex = Convert.ToInt32(Console.ReadLine());
    return userIndex;
}

Random random = new Random();
int line = random.Next(1,10);
int column = random.Next(1,10);

int userLine = GetIndexUser("Enter the searching line in matrix");
int userColumn = GetIndexUser("Enter the searching column in matrix");
int[,] matrix = InitialArray(line, column);
PrintArray(matrix);

if ((userLine <= line) && (userColumn <= column))
{
    Console.WriteLine($"на позиции ({userLine}, {userColumn}) стоит цифра: {matrix[userLine - 1, userColumn - 1]}");
}
else Console.WriteLine("Такого числа нет");