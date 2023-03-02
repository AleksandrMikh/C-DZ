// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
//Примеры: 6 -> да
//         7 -> да
//         1 -> нет 


Console.Write("Введите цифру дня недели от 1 до 7: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if(numberDay > 7 || numberDay < 1)
{
    Console.Write("некорректный ввод цифры");
}
else
{
    if(numberDay < 6)
    {
        Console.Write("нет");
    }
    else 
    {
        Console.Write("да");
    }
}