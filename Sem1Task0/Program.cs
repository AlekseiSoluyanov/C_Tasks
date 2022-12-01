//Напишите программу, которая на вход принимает число и выдаёт его квадрат
//(число умноженное насамо себя).

//Считываем данные с консоил
string? inputLine = Console.ReadLine();

//Проверяем чтобы данные были не пустыми
if(inputLine!=null)
{
    // Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    //Находим квадрат числа
    int outNumber = inputNumber*inputNumber;
    //int outNumber = (int)Math.Pow(inputNumber,2);

    //Выводим данные в консоль
    Console.WriteLine(outNumber);
    //Console.WriteLine(Math.Pow(int.Parse(inputLine),2));
}