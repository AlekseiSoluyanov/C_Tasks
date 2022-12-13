// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

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

int VariantLog(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}

int VariantString(int num)
{
    int count = num.ToString().Length;
    return count;
}

int VariantSimple(int num)
{
    int count = 0;
    while(num>0)
    {
        count++;
        num=num/10;
    }
    return count;
}

int number = ReadData("Введите число А:");

DateTime d1 = DateTime.Now;
int lenght1 = VariantLog(number);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int lenght2 = VariantString(number);
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
int lenght3 = VariantSimple(number);
Console.WriteLine(DateTime.Now - d3);

PrintData("Колличество цифр в числе равно: " + lenght1);
PrintData("Колличество цифр в числе равно: " + lenght2);
PrintData("Колличество цифр в числе равно: " + lenght3);