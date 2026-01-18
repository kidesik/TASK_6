Console.Write("Введите натуральное число N: ");

if (!long.TryParse(Console.ReadLine(), out long n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
    return;
}

long tempNumber = n;
long maxDigit = tempNumber % 10;
long minDigit = tempNumber % 10;

while (tempNumber > 0)
{
    long digit = tempNumber % 10; 
    if (digit > maxDigit)
    {
        maxDigit = digit;
    }

    if (digit < minDigit)
    {
        minDigit = digit;
    }

    tempNumber /= 10; 
}

Console.WriteLine($"\nРезультаты для числа N = {n}:");
Console.WriteLine($"  а) Его максимальная цифра: **{maxDigit}**");
Console.WriteLine($"  б) Его минимальная цифра: **{minDigit}**");
