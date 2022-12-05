// Напишите программу, которая выводит
// случайное трёхзначное число и удаляет
// вторую цифру этого числа.

//Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int number = numberSintezator.Next(100,1000);

//Выводим данные в консоль
Console.WriteLine(number);

int firsNum = number/100;       //Получаем старший разряд числа
int secondNum = number % 10;     //Получаем младший разряд числа

int result = firsNum*10 + secondNum;
//int result = (number/100)*10 + number % 10;       //2й вариант
Console.WriteLine(result);
//Console.WriteLine((number/100)*10 + number % 10);    //3й вариант
