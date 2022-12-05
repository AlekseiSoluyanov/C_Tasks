// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.

//Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Вариант 1
int number = numberSintezator.Next(10,100);

//Выводим данные в консоль
// Console.WriteLine(number);

//Получаем первое и второе число поотдельности
int firsNumber = number/10;
int secondNumber = number%10;

//Сравниваем числа
if(firsNumber>secondNumber)
{
    //Выводим данные в консоль
    // Console.WriteLine(firsNumber);
}
else
{
    //Выводим данные в консоль
    // Console.WriteLine(secondNumber);
}

//Вариант 2
char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);

firsNumber = ((int)digits[0]-48);
secondNumber = ((int)digits[1]-48);

int resultNumber = firsNumber>secondNumber?resultNumber=
firsNumber:resultNumber=secondNumber;

Console.WriteLine(resultNumber);

//Вариант3 (с массивом)
