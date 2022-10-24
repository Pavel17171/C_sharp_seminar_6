// E03 В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

// Задаем исходные данные для создания двумерного массива

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите нижнюю границу рандома: ");
int minBorder = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите верхнюю границу рандома: ");
int maxBorder = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
Console.WriteLine("Исходный двухмерный массив:");

// Создаем двухмерный массив и выводим на экран

int[,] matrix = new int[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(minBorder, maxBorder);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}


// Редактируем массив, согласно заданию и выводим на экран

Console.WriteLine();
Console.WriteLine("Двухмерный массив, соответствующий заданию:");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        } 
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}