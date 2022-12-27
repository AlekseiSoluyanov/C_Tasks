// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int result = AkkerFunk(numM, numN);
PrintData("Функция Аккермана равна: "+result);

// Функция Аккермана
int AkkerFunk(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AkkerFunk(m - 1, 1);
    else
      return AkkerFunk(m - 1, AkkerFunk(m, n - 1));
}

// Метод вывода данных.
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Чтение данных из консоли.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}