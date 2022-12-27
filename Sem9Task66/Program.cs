// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод вывода данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод находит сумму натуральных элементов в промежутке от M до N.
int SumRecMN(int M, int N)
{
    if (M >= N) return N;
    else return M + SumRecMN(M + 1, N);
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int result = SumRecMN(number1, number2);
PrintData("Сумма элменетов равна: " + result);
