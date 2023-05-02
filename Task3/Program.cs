// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
double k = 1;
Console.Write($"{n} -> ");
while (n > i)
{
    Console.Write($"{Math.Pow(k, 3)} ");
    k++;
    i++;
}