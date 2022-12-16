// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.

//Создание произвольного одномерного массива и его вывод в консоль.
int[] array = GenArray(123, 10, 99);
Print1DArray(array);
Console.WriteLine();

//Вызов метода суммы элементов, стоящих на нечётных позициях и вывод результата в консоль.
int result = SumOdd(array);
PrintData("Сумма элементов, стоящих на нечётных позициях массива в отрезке [10,99] составляет: ", result);

//Метод генерации массива с заданной длиной и параметрами.
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

//Метод печатает одномерный массив.
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

//Метод вывода рузльтата.
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Метод суммы элементов, стоящих на нечётных позициях.
int SumOdd(int[] arr)
{
    int res = 0;
    int i = 1;
    while (i < arr.Length)
    {
        res += arr[i];
        i = i + 2;
    }
    return res;
}