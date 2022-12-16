// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.

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
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Метод замены элементов массива с положительных на отрицательные, и наоборот.
int[] InverseArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i=0;i<arr.Length;i++)
    {
        outArr[i] = arr[i] * (-1);
    }
    return outArr;
}


int[] array = GenArr(10,-9,9);
Print1DArr(array);
int[] newArray = InverseArr(array);
Print1DArr(newArray);