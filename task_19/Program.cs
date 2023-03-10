// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberA = number / 10000;
Console.Write($"{numberA}" );
int numberBb = number / 1000;
int numberB = numberBb %10;

Console.Write($"{numberB}" );
