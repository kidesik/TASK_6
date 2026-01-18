Console.Write("Введите натуральное число N: ");
long n = long.Parse(Console.ReadLine());

Console.Write("Введите целое число 'a' (делитель): ");
int a = int.Parse(Console.ReadLine());

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
long sumOfMinMax = maxDigit + minDigit;

if (a == 0)
{
    Console.WriteLine("\nОшибка: Делитель 'a' не может быть нулем.");
}
else if (sumOfMinMax % a == 0)
{
    Console.WriteLine($"\nСумма максимальной ({maxDigit}) и минимальной ({minDigit}) цифр равна {sumOfMinMax}.");
    Console.WriteLine($"Результат: **Сумма кратна числу {a}**.");
}
else
{
    Console.WriteLine($"\nСумма максимальной ({maxDigit}) и минимальной ({minDigit}) цифр равна {sumOfMinMax}.");
    Console.WriteLine($"Результат: **Сумма не кратна числу {a}**.");
}