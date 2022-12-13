// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N. (Факториал)

//Запрос данных у пользователя

using System.Numerics;

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод вывода рузльтата
void PrintData(string res)
{
    Console.WriteLine(res);
}

BigInteger CalcFactor(int num)
{
    BigInteger count = 1;
    for(int i=1;i<=num;i++)
    {
        count *= i;
    }
    return count;
}

int number = ReadData("Введите число А:");

BigInteger lenght1 = CalcFactor(number);

PrintData("Факториал равно: " + lenght1);
