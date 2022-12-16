// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.


int positiveSum = 0;
int negativeSum = 0;

int[] testArr = GenArr(12, -9, 9);
NegativePositiveSum(testArr);
Print1DArr(testArr);
PrintData("Сумма положительных чисел в массиве: ", positiveSum);
PrintData("Сумма отрицательных чисел в массиве: ", negativeSum);

//Метод генерации массива с заданной длиной и параметрами
int[] GenArr(int num, int limDown, int limUp)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(limDown, limUp + 1);
    }
    return arr;
}

//Метод вывода рузльтата
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

void NegativePositiveSum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positiveSum += arr[i];
        }
        else
        {
            negativeSum += arr[i];
        }
    }
}

//Метод печатает одномерный массив
void Print1DArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}