// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.

int[] array = GenArr(10, -9, 10);
Print1DArr(array);
int num = ReadData("Введите число: ");
int result = SearchElem(array, num);
if (result >= 0)
{
    PrintData("Элкмент найден в позиции: " + result);
}
else
{
    PrintData("В массиве элемент не найден!");
}

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

//Метод печатает одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Метод вывода рузльтата
void PrintData(string res)
{
    Console.WriteLine(res);
}

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int SearchElem(int[] arr, int elem)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            res = i;
            break;
        }
    }
    return res;
}

