// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.

//Считываем данные с консоли.
string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();
string? Num3Line = Console.ReadLine();

//Проверяем чтобы данные были не пустыми.
if(Num1Line!=null && Num2Line!=null && Num3Line!=null)
{
    //Парсим введенное число
    int Num1 = int.Parse(Num1Line);
    int Num2 = int.Parse(Num2Line);
    int Num3 = int.Parse(Num3Line);

    //Пишем условие для сравнения 3х чисел и вывод в консоль значение
    //наибольшего числа.
     
    if(Num1>Num2)
    {
        if(Num1>Num3)
        {
            Console.WriteLine("Max = " + Num1);
        }
        else
        {
            Console.WriteLine("Max = " + Num3);
        }
    }
    else
    {
            if(Num2>Num3)
        {
            Console.WriteLine("Max = " + Num2);
        }
        else
        {
            Console.WriteLine("Max = " + Num3);
        } 
    }
}