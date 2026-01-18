{Console.Write("Введите натуральное число N: ");
string input = Console.ReadLine();
long n = long.Parse(input);

long tempNumber = n;
long maxDigit = -1;


while (tempNumber > 0)
{
    long digit = tempNumber % 10;
    if (digit > maxDigit)
    {
        maxDigit = digit;
    }
    tempNumber /= 10;
}

tempNumber = n; 
int count = 0;

while (tempNumber > 0)
{
    long digit = tempNumber % 10;
    if (digit == maxDigit)
    {
        count++;
    }
    tempNumber /= 10;
}

Console.WriteLine($"\nМаксимальная цифра: {maxDigit}");
Console.WriteLine($"Количество ее вхождений в числе {n}: **{count}**");}
{
    Console.Write("Введите натуральное число N: ");
    string input = Console.ReadLine();
    long n = long.Parse(input);

    long tempNumber = n;
    long maxDigit = -1;
    int count = 0;

    while (tempNumber > 0)
    {
        long digit = tempNumber % 10;

        if (digit > maxDigit)
        {
            maxDigit = digit; 
            count = 1;        
        }
        else if (digit == maxDigit)
        {
            count++;          
        }

        tempNumber /= 10;
    }

    Console.WriteLine($"\nМаксимальная цифра: {maxDigit}");
    Console.WriteLine($"Количество ее вхождений в числе {n}: **{count}**");
}
