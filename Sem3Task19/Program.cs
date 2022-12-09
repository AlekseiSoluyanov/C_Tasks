// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

int num = ReadData("Введите пятизначное число ");
bool result = PalinTest(num);
Console.WriteLine(result);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод проверки на палиндром
bool PalinTest(int num)
{
    bool result = false;
    result = (num / 10000 == num % 10) && ((num / 1000) % 10) == ((num / 10) % 10);

    return result;
}