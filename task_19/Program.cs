// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 10000 || number > 99999)
{
    Console.WriteLine("Ввели НЕпятизначное число.");
}
else
{
int numberA = number / 10000;
int numberB = number /1000 %10;
int numberC = number /10 %10;
int numberD = number %10;

if(numberA == numberD && numberB ==numberC)
{
    System.Console.WriteLine("Да, палиндром");
}
else
{
    System.Console.WriteLine("Нет");
}
}