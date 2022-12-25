//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.

// Программа принимает параметры двумерного массива, генерирует с произвольными
// раскрашенными элементами.
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row, column, 1, 9);
Print2DArrayColor(arr2D);

// Вызов метода расчета среднее арифметического и вывод рез-та в консоль.
int[] array = AwgCol(arr2D);
Console.Write("Среднее арифметическое каждого столбца: ");
Print1DArray(array);

//Запрос данных у пользователя.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
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

// Метод выводит массив с раскрашенными элементами произвольного цвета.
void Print2DArrayColor(int[,] matrix)
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
            Console.Write(matrix[i, j] + "   ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//Метод печатает одномерный массив.
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// Метод расчета среднее арифметического элемента в каждом столбце двумерного массива.
int[] AwgCol(int[,] arr)
{
    int[] awr = new int[arr.GetLength(1)];
    for(int j = 0; j<arr.GetLength(1);j++)
    {
        for(int i = 0;i< arr.GetLength(0); i++)
        {
            awr[j] += arr[i,j];
        }
        awr[j] = awr[j]/awr.GetLength(0);
    }
    return awr;
}
