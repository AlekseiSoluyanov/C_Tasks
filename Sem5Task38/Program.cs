// Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.

//Переменные для нахождения максимального и минимального элемента массива.
double min = double.MaxValue;
double max = double.MinValue;

//Создание произвольного одномерного массива и его вывод в консоль.
double[] array = GenArray(16, 10, 99);
Print1DArray(array);
Console.WriteLine();

//Вызов метода для расчета разницы между максимальным и минимальным элементов массива. Вывод рез-та в консоль.
MinMax(array);
PrintData("Разница между максимальным и минимальным элементов массива = ");

//Метод генерации массива вещественных чисел с заданной длиной и параметрами.
double[] GenArray(int len, double limDown, double limUp)
{
    Random rnd = new Random();
    double[] outArray = new double[len];
    for (int i = 0; i < len; i++)
    {
        //Math.Round(rnd.NextDouble(),1) - Округление элементов массива до 1 числа после запятой.
        outArray[i] = new Random().Next((int)limDown, (int)limUp)+ Math.Round(rnd.NextDouble(),1);
    }
    return outArray;
}

//Метод печатает одномерный массив.
void Print1DArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

//Метод вывода рузльтата. С округлением до 1 числа после запятой.
void PrintData(string res)
{
    Console.Write(res);
    Console.WriteLine("{0:f1}", (max - min));
}

// Метод для расчета разницы между максимальным и минимальным элементов массива.
void MinMax(double[]arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        if(arr[i]>max) max = arr[i];
        if(arr[i]<min) min = arr[i];
    }
}