// Задача 23: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

int i = 1;
int cube = 0;
Console.Write("Введите целое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N < 0) 
{
    Console.WriteLine("Введено отрицательное число!");
}
else
{
    while(i < N)
    {
        cube = (int)Math.Pow(i , 3);
        Console.Write($"{cube}, ");
        i += 1;
    }
    cube = (int)Math.Pow(N , 3);
    Console.WriteLine(cube + ".");
}
