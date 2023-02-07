/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/

void Average(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    Console.WriteLine("");
    }

    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        double average = sum / array.GetLength(0);
        // Console.WriteLine($"sum is {sum}. {array.GetLength(1)}  = {average}; ");
        Console.Write($"{Math.Round(average, 2)}; ");
    }
}

int[,] NewMatrix(int row, int col)
{
    int[,] newMatrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newMatrix[i, j] = new Random().Next(0, 10);
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

//генерируем и заполняем массив
int[,] matrix = NewMatrix(m, n);

// считаем ср. арифм. и показываем
Average(matrix);