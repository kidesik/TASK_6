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
bool isEven = (difference % 2 == 0);
string resultText = isEven ? "четным" : "нечетным";

Console.WriteLine($"\nРазность максимальной ({maxDigit}) и минимальной ({minDigit}) цифр равна {difference}.");
Console.WriteLine($"Результат: **Разность является {resultText} числом**.");
