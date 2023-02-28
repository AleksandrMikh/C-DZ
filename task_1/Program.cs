//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, 
//какое число большее, а какое меньшее.
//Пример:
//a = 5; b = 7 ->  max = 7

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.Write($"max = {number1} min = {number2}");
}
else if(number1 < number2)
{
    Console.Write($"max = {number2} min = {number1}");
}
else if(number1 == number2)
{
 Console.Write("Числа равны");   
}
