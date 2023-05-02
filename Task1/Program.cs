// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное чило: ");
double x1 = Convert.ToInt32(Console.ReadLine());
double x = x1;
double[] m = new double [5];
if (x > 9999 && x < 100000)
{   double o = 0;
    int i = 0;
    
    while (i < 5)
    {
        o = x % 10;
        x = Math.Floor(x/10);
        m[i] = o;
        i++;
    }
    if (m[0] == m [4] && m[1] == m[3])
    {
        Console.WriteLine($"Число {x1}  является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {x1} не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Число введено некорректно.");
}
