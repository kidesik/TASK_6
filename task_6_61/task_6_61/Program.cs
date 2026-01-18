Console.Write("Введите натуральное число N (все цифры различны): ");
string input = Console.ReadLine();
long n = long.Parse(input);

long tempNumber = n;
int totalLength = input.Length;

int max1 = -1, max2 = -1;
int min1 = 10, min2 = 10;
int max1PosEnd = 0, max2PosEnd = 0;
int min1PosEnd = 0, min2PosEnd = 0;
int currentPosEnd = 0;

while (tempNumber > 0)
{
    currentPosEnd++;
    int digit = (int)(tempNumber % 10);

    if (digit > max1)
    {
        max2 = max1; 
        max2PosEnd = max1PosEnd; 
        max1 = digit; 
        max1PosEnd = currentPosEnd; 
    }
    else if (digit > max2)
    {
        max2 = digit;
        max2PosEnd = currentPosEnd;
    }

    if (digit < min1)
    {
        min2 = min1; 
        min2PosEnd = min1PosEnd; 
        min1 = digit; 
        min1PosEnd = currentPosEnd; 
    }
    else if (digit < min2)
    {
        min2 = digit;
        min2PosEnd = currentPosEnd;
    }

    tempNumber /= 10; 
}
Console.WriteLine($"\nРезультаты для N={n}:");

Console.WriteLine($"  а) Порядковые номера двух максимальных цифр ({max1} и {max2}):");
Console.WriteLine($"     - От конца числа: {max1PosEnd}, {max2PosEnd}");
Console.WriteLine($"     - От начала числа: {totalLength - max1PosEnd + 1}, {totalLength - max2PosEnd + 1}");

Console.WriteLine($"  б) Порядковые номера двух минимальных цифр ({min1} и {min2}):");
Console.WriteLine($"     - От конца числа: {min1PosEnd}, {min2PosEnd}");
Console.WriteLine($"     - От начала числа: {totalLength - min1PosEnd + 1}, {totalLength - min2PosEnd + 1}");
