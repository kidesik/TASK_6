Console.Write("Введите натуральное число N: ");

string input = Console.ReadLine();
long n = long.Parse(input);

long tempNumber = n;
int totalLength = input.Length;

long maxOddDigit = -1;

long minDigit = 10;
int currentPositionFromEnd = 0;
int minPosEnd = 0; 
while (tempNumber > 0)
{
    currentPositionFromEnd++;
    long digit = tempNumber % 10;

    if (digit % 2 != 0 && digit > maxOddDigit)
    {
        maxOddDigit = digit;
    }

    if (digit < minDigit)
    {
        minDigit = digit;
        minPosEnd = currentPositionFromEnd;
    }

    tempNumber /= 10;
}

int minPosStart = totalLength - minPosEnd + 1; Console.WriteLine($"\nРезультаты для числа N = {n}:");

Console.Write("  а) Максимальная нечетная цифра числа: ");
if (maxOddDigit == -1)
{
    Console.WriteLine("**Не найдена (все цифры четные)**");
}
else
{
    Console.WriteLine($"**{maxOddDigit}**");
}

Console.WriteLine($"  б) Номер минимальной цифры ({minDigit}) при счете слева направо: **{minPosStart}**");

