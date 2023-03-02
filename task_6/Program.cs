// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// Примеры: 645 -> 5
//          78 -> третьей цифры нет
//          32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100)
{
    Console.Write("третьей цифры нет");
}
else if(number > 999)
   {
    while(number > 999)
    {       
    number /= 10;
    }
    int digitA = number%10;
    Console.Write($"третья цифра: {digitA}");
   }
   else
   {
    int digit = number%10;
    Console.Write($"третья цифра: {digit}");
   }

