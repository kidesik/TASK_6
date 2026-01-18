Console.Write("Введите натуральное число N: ");

long n = long.Parse(Console.ReadLine());
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
long difference = maxDigit - minDigit;
long sum = maxDigit + minDigit;

Console.WriteLine($"\nРезультаты для числа N = {n}:");
Console.WriteLine($"  а) Максимальная цифра: {maxDigit}, Минимальная цифра: {minDigit}");
Console.WriteLine($"  б) На сколько максимальная цифра превышает минимальную: **{difference}**");
Console.WriteLine($"  в) Сумма его максимальной и минимальной цифр: **{sum}**");
