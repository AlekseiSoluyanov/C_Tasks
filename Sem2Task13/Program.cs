// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

int number = int.Parse(Console.ReadLine()??"0");

if(number>99)
{
    //Нахождение третьего числа при помощи массива, выводим это число
    char[] digits = number.ToString().ToCharArray();
    Console.WriteLine(digits[2]);
}
//Выводим сообщение если ввели двухзначное число и меньше
else Console.WriteLine("Третьей цифры нет");