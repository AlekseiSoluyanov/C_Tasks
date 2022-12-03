// Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.

//Считываем данные с консоли.
string? FirstNumLine = Console.ReadLine();
string? SecomdNumLine = Console.ReadLine();

//Проверяем чтобы данные были не пустыми
if(FirstNumLine!=null && SecomdNumLine!=null)
{
    //Парсим введенное число
    int FirstNum = int.Parse(FirstNumLine);
    int SecomdNum = int.Parse(SecomdNumLine);

    // Пишем условие для вывода в консоль какое число большее, а какое меньшее.
    if(FirstNum>SecomdNum)
    {
        Console.WriteLine("FirstNum>SecomdNum");
    }
    else
    {
        Console.WriteLine("SecomdNum>FirstNum");
    }
}