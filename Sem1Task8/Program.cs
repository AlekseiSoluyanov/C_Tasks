// Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

//Считываем данные с консоли.
string? NumLine = Console.ReadLine();

//Проверяем чтобы данные были не пустыми.
if(NumLine!=null)
{
    //Парсим введенное число.
    int Num = int.Parse(NumLine);

    //Вводим переменную первого четного числа.
    int Count = 2;
    string Result = string.Empty;

    //Создаем цикл для собирания строки из четных чисел.
    while(Count<Num)
    {
        Result = Result + Count + ", ";
        Count = Count + 2;
    }

    //Вводим переменную для проверки числа на четность. Если число четное, оно
    //добавляется в строку.
    int EvenNum = Num % 2;
    if (EvenNum == 0)
    {
        Result = Result + Num + ", " + EvenNum;
    }

    Console.WriteLine(Result);
}