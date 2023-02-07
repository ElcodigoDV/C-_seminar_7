/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

void ShowResult (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
    Console.WriteLine("");
    }
}

double[,] NewMatrix (int row, int col)
{
    double[,] newMatrix = new double[row, col];
    for (int i =0; i < row; i++)
    {
        for (int j =0; j< col; j++)

        {
            newMatrix[i,j] = new Random().Next(-10, 11);
        }
    }
    return newMatrix;
}

int Num(string text)

{
    Console.WriteLine(text);
    int num = Int32.Parse(Console.ReadLine());
    return num;
}

int m = Num("задайте кол-во строк массива");

int n = Num("задайте кол-во столбцов массива");

//создаем массив

double[,] matrix = NewMatrix(m, n);

//выводим рез-т
Console.WriteLine($"m = {m}, n = {n}");
ShowResult (matrix);