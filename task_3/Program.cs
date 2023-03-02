//Задача 6: Напишите программу, которая на вход принимает число и выдает, 
//является ли число четным (делится ли оно на два без остатка).
//Пример: 4 -> да
//       -3 -> нет


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int test = number%2;

if(test == 0)  
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}
