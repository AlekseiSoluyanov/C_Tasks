// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double row = ReadData("Введите количество строк ");
double column = ReadData("Введите количество столбцов ");

//Вызов метода генерации массива с заданными параметрами и его печать в консоль.
double[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);

//Запрос данных у пользователя.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива вещественных чисел.
double[,] Fill2DArray(double countRow, double countColumn, int topBorder, int downBorder)
{
    Random rand = new Random();
    double[,] array2D = new double[(int)countRow, (int)countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next((int)topBorder, (int)downBorder + 1) + Math.Round(rand.NextDouble(), 1);
        }
    }
    return array2D;
}

// Метод выводит массив с раскрашенными элементами произвольного цвета.
void Print2DArrayColor(double[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + "   ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
