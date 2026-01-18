Console.Write("Введите натуральное число N (все цифры различны): ");

string input = Console.ReadLine();
long n = long.Parse(input);

long tempNumber = n;
int totalLength = input.Length; 
long maxDigit = -1;
long minDigit = 10;
int currentPositionFromEnd = 0; 
int maxPosEnd = 0;
int minPosEnd = 0;

while (tempNumber > 0)
{
    currentPositionFromEnd++;
    long digit = tempNumber % 10; 

    if (digit > maxDigit)
    {
        maxDigit = digit;
        maxPosEnd = currentPositionFromEnd;
    }

    if (digit < minDigit)
    {
        minDigit = digit;
        minPosEnd = currentPositionFromEnd;
    }

    tempNumber /= 10; 
}

int maxPosStart = totalLength - maxPosEnd + 1;
int minPosStart = totalLength - minPosEnd + 1;
Console.WriteLine($"\nРезультаты для числа N = {n}:");
Console.WriteLine($"Максимальная цифра: {maxDigit}, Минимальная цифра: {minDigit}");

Console.WriteLine($"  а) Порядковый номер максимальной цифры:");
Console.WriteLine($"     - От конца числа: **{maxPosEnd}**");
Console.WriteLine($"     - От начала числа: **{maxPosStart}**");

Console.WriteLine($"  б) Порядковый номер минимальной цифры:");
Console.WriteLine($"     - От конца числа: **{minPosEnd}**");
Console.WriteLine($"     - От начала числа: **{minPosStart}**");