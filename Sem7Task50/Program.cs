//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Программа принимает параметры двумерного массива, генерирует с произвольными
// раскрашенными элементами.

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);

// Программа принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или указывает, что такого элемента нет.
int num1 = ReadData("Введите координату X ");
int num2 = ReadData("Введите координату Y ");
int ElemPos = SerarchElement(arr2D, num1, num2);
if (ElemPos < 0) PrintDataOnlyMsg("Такого числа в массиве нет");
else PrintData("Значение элемента в заданой позиции равно: ", ElemPos);

//Запрос данных у пользователя.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string msg, int result)
{
    Console.WriteLine(msg + result);
}

void PrintDataOnlyMsg(string msg)
{
    Console.WriteLine(msg);
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

// Метод находит значение элемента массива по заданой позиции.
int SerarchElement(int[,] arr, int x, int y)
{
    int elem = -1;
    if (x < arr.GetLength(0) && y < arr.GetLength(1))
    {
        elem = arr[x, y];
    }
    return elem;
}