// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа нахождения четных чисел от 1 до N. Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int Count = 1;
while (Count <= N)
{
    if (Count % 2 == 0)
    {
        Console.WriteLine($"Четные сисла {Count}");
    }
}
