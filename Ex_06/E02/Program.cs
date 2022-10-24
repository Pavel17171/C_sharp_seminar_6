// E02 Задать двумерный массив следующим правилом: Aₘₙ = m+n


// Задаем исходные данные для создания двумерного массива

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");


// Создаем двухмерный массив и выводим на экран

int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = i + j;
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}