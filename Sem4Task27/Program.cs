// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.

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

// Метод суммы цифр в числе через остаток
int VariantSumDigits(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

// Метод суммы цифр в числе через строку
int VariantString(int num)
{
    String str = num.ToString();
    char[] chars = str.ToCharArray();
    int[] numbers = new int[chars.Length];
    for(int i = 0; i < chars.Length; ++i) numbers[i] = int.Parse(chars[i].ToString());
    int result = 0;
    foreach(int number in numbers)
    {
        result += number;
    }
    return result;
}

int num = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = VariantString(num);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumDigits(num);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма цифр в числе равна(Метод String): " + res1);
PrintData("Сумма цифр в числе равна(Метод через остаток): " + res2);