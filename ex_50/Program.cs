/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
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

 double[,] NewMatrix(int row, int col)
{
    double[,] newMatrix = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newMatrix[i, j] = new Random().Next(-10, 101);
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

//задаем строки и столбцы

int m = Num("задайте кол-во строк массива");
int n = Num("задайте кол-во столбцов массива");

//генерируем и заполняем массив
double[,] matrix = NewMatrix(m, n);

//Какую позицию ищем
Console.WriteLine("ИНДЕКС СТРОКИ позиции");
int rowPosition = Int32.Parse(Console.ReadLine());
Console.WriteLine("ИНДЕКС СТОЛБЦА позиции");
int colPosition = Int32.Parse(Console.ReadLine());

//Показываем матрицу

ShowResult(matrix);

//поиск позиции
if (rowPosition < 0 | rowPosition > matrix.GetLength(0) - 1 |
    colPosition < 0 | colPosition > matrix.GetLength(1) - 1)
{
    Console.WriteLine($"{rowPosition}{colPosition}-> такого числа в массиве нет");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[rowPosition, colPosition]);
}