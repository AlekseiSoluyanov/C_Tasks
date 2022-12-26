// Задайте прямоугольный двумерный массив. Напишите программу, которая будет
//находить строку с наименьшей суммой элементов.

// Пользователь вводит входные данные
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row, column, 0, 99);
Print2DArrayColor(arr2D);
Console.WriteLine();

// Вывод в консоль результата с наименьшей суммой элементов.
int Res = MinRow(arr2D);
PrintData("Номер строки с наименьшей суммой элементов: ", Res);

//Метод вывода рузльтата.
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Запрос данных у пользователя.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод выводит массив с раскрашенными элементами произвольного цвета.
void Print2DArrayColor(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[arr[i, j] % 15];
            Console.Write(arr[i, j] + "     ".Substring(arr[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод генерирует двухмерный массив, заполненный случайными числами
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Метод находит строку с наименьшей суммой элементов.
int MinRow(int[,] arr)
{
    int minIndex = -1;
    int minRow = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (minRow > sum)
        {
            minRow = sum;
            minIndex = i + 1;
        }
    }
    return minIndex;
}