// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.

//Запрос данных у пользователя
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

//Метод возведения числа А в натуральную степень В.
int Pow(int num1, int num2)
{
    int result = 1;
    for(int i=1;i<=num2;i++)
    {
        result = num1 * result;
    }
    return result;
}

int numberA = ReadData("Введите число А: ");
int numberB = ReadData("Введите число В: ");

int result = Pow(numberA, numberB);

PrintData("А в степени В равно: " + result);