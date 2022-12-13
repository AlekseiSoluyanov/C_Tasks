// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Запрос данных у пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод вывода рузльтата
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

//Метод генерации массива с заданной длиной и параметрами
int[] GenArr(int num, int limDown, int limUp)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(limDown, limUp);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Введите длину массива: ");
int arrNum1 = ReadData("Введите нижний лимит массива: ");
int arrNum2 = ReadData("Введите верхний лимит массива: ");

int[] arr = GenArr(arrLen, arrNum1, arrNum2);

PrintData("Сгенерированный массив: ", arr);