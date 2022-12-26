// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int dep = ReadData("Введите глубину массива: ");

// Список двухзначных чисел
List<int> num = new List<int>();
for (int i = 0; i < 90; i++)
{
    num.Add(10 + i);
}

int[,,] arr3D = Fill3DArray(row, column, dep);
Print3DArray(arr3D);

// Метод генерирует трехмерный массив, заполненный случайными числами.
int[,,] Fill3DArray(int countRow, int countColumn, int countDep)
{

    int[,,] array3D = new int[countRow, countColumn, countDep];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < countDep; k++)
            {
                int rand = GenNum(num);
                array3D[i, j, k] = rand;
            }
        }
    }
    return array3D;
}

// Метод выводит массив в консоль.
void Print3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write("|");
            for (int k = 0; k < array3D.GetLength(2); k++) { Console.Write($"{array3D[i, j, k],1}({i},{j},{k})|"); }
            Console.WriteLine();
        }
    }
}

//Запрос данных у пользователя.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод генерации случайных уникальных чисел
int GenNum(List<int> num)
{
    int index = new Random().Next(0, num.Count);
    int outNum = num[index];
    num.RemoveAt(index);
    return outNum;
}