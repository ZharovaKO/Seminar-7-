// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Ведите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс элемента строки: ");
int indexRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс элемента столбца: ");
int indexColums = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, colums];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 100);
        Console.Write(matrix[i, j] + " | ");
    }
    Console.WriteLine();
}


if (indexRows > matrix.GetLength(0) || indexColums > matrix.GetLength(1))
{
    Console.WriteLine($"Элемента с индексом строки {indexRows} и с индексом столбца {indexColums} нет в массиве");
}
else
{
    Console.WriteLine($"число = {matrix[indexRows - 1, indexColums - 1]}");
}

