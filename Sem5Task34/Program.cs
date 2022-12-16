// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//Создание произвольного одномерного массива и его вывод в консоль
int[] array = GenArray(123, 100, 999);
Print1DArray(array);
Console.WriteLine();

//Вызов метода поиска чётных элементов массива и вывод результата в консоль
int result = CountEven(array);
PrintData("Количество чётных элементов массива в отрезке [100,999] составляет: ", result);

//Метод генерации массива с заданной длиной и параметрами
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

//Метод печатает одномерный массив
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

//Метод вывода рузльтата
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Метод считает колличество чётных элементов массива
int CountEven(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}