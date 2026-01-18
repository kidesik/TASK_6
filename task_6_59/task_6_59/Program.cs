{
Console.Write("Введите натуральное число N: ");
string input = Console.ReadLine();
long n = long.Parse(input);

long tempNumber = n;
long minDigit = 10; 
while (tempNumber > 0)
{
long digit = tempNumber % 10;
if (digit < minDigit)
{
minDigit = digit;
}
tempNumber /= 10;
}

tempNumber = n; 
int count = 0;

while (tempNumber > 0)
{
long digit = tempNumber % 10;
if (digit == minDigit)
{
count++;
}
tempNumber /= 10;
}

Console.WriteLine($"\nМинимальная цифра: {minDigit}");
Console.WriteLine($"Количество ее вхождений в числе {n}: **{count}**");

}
{
    Console.Write("Введите натуральное число N: ");
    string input = Console.ReadLine();
    long n = long.Parse(input);

    long tempNumber = n;
    long minDigit = 10;
    int count = 0;

    while (tempNumber > 0)
    {
        long digit = tempNumber % 10;

        if (digit < minDigit)
        {
            minDigit = digit; 
            count = 1;        
        }
        else if (digit == minDigit)
        {
            count++;          
        }

        tempNumber /= 10;
    }

    Console.WriteLine($"\nМинимальная цифра: {minDigit}");
    Console.WriteLine($"Количество ее вхождений в числе {n}: **{count}**");

}