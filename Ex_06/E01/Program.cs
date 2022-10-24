// E01 Показать двумерный массив размером m×n заполненный вещественными числами


// Задаем исходные данные для создания рандомного двумерного массива

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите нижнюю границу рандома: ");
int minBorder = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите верхнюю границу рандома: ");
int maxBorder = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

// Создаем рандомный двухмерный массив и выводим на экран

decimal[,] matrix = new decimal[m, n];
Random rand = new Random();
int numInt;
decimal numDecim;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        numInt = rand.Next(minBorder, maxBorder);      // Рандом целой части числа
        numDecim = (decimal)rand.NextDouble();         // Рандом дробной части числа
        numDecim = Math.Round(numDecim, 2);            // Округление дробной части числа до сотых
        matrix[i, j] = numInt + numDecim;              // Заполнение массива
        Console.Write($"{matrix[i, j]} ");             // Вывод на экран элементов массива строки
    }
    Console.WriteLine();                               // Переход на новую строку
}