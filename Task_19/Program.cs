// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99999 || number < 10000)
{
    Console.WriteLine("Ошибка! Введённое число не является пятизначным!");
} 
else
{
    if(number / 10000 % 10 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}
