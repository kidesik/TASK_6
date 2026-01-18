Console.Write("Введите натуральное число N (все цифры различны): ");

long n = long.Parse(Console.ReadLine());

long tempNumber = n;

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

string result;
if (maxPosEnd > minPosEnd)
{
    result = $"Максимальная цифра (**{maxDigit}**) расположена левее минимальной (**{minDigit}**).";
}
else if (minPosEnd > maxPosEnd)
{
    result = $"Минимальная цифра (**{minDigit}**) расположена левее максимальной (**{maxDigit}**).";
}
else
{
    result = "Обе цифры находятся на одной позиции (число однозначное).";
}
Console.WriteLine($"\nРезультаты для числа N = {n}:");
Console.WriteLine($"Позиция max цифры ({maxDigit}) от конца: {maxPosEnd}");
Console.WriteLine($"Позиция min цифры ({minDigit}) от конца: {minPosEnd}");
Console.WriteLine($"\n**{result}**");