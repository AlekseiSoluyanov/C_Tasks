// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.

// Запрос пользователю, переменная count = N(кол-во чисел)
// Вызов метода расчета и вывод рез-та в консоль.
int count = ReadData("Сколько чисел будет введено?: ");
int result = CountPosNum(count);
PrintData("Пользователь ввел " + result + " числа больше 0");

//Метод, считывающий данные, введенные пользователем.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю.
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод, считывает сколько чисел больше 0 ввёл пользователь.
int CountPosNum(int N)
{
    N = count;
    int res = 0;
    while(N > 0)
    {
        if(ReadData("Введите число: ")>0) res ++;
        N = N - 1;
    }
    return res;
}