//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Пример: 456 -> 5

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100 || number > 999)
{
    Console.Write("Введено не трехзначное число");
}
else
{
    int numberA = number / 10;
    int numberResult = numberA%10; 
    Console.Write($"Вторая цифра данного числа: {numberResult} ");
}

