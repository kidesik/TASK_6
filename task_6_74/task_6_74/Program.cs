Console.Write("Введите натуральное число N: ");

if (!long.TryParse(Console.ReadLine(), out long n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода. Введите натуральное число.");
    return;
}

long temp3 = n;
while (temp3 > 1 && temp3 % 3 == 0)
{
    temp3 /= 3;
}
bool isPowerOf3 = (temp3 == 1);
string resultA = isPowerOf3 ? "Является" : "Не является";

long temp5 = n;
while (temp5 > 1 && temp5 % 5 == 0)
{
    temp5 /= 5;
}
bool isPowerOf5 = (temp5 == 1);
string resultB = isPowerOf5 ? "Является" : "Не является";

Console.WriteLine($"\nРезультаты для числа N = {n}:");
Console.WriteLine($"  а) Является ли степенью числа 3? **{resultA}**");
Console.WriteLine($"  б) Является ли степенью числа 5? **{resultB}**");
