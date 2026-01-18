Console.Write("Введите натуральное число N (все цифры различны): ");
string input = Console.ReadLine();
long n = long.Parse(input);

int max1 = -1; 
int max2 = -1; 
int min1 = 10; 
int min2 = 10; 

foreach (char digitChar in input)
{
    int digit = int.Parse(digitChar.ToString());

    if (digit > max1)
    {
        max2 = max1; 
        max1 = digit; 
    }
    else if (digit > max2)
    {
        max2 = digit;
    }

    if (digit < min1)
    {
        min2 = min1; 
        min1 = digit; 
    }
    else if (digit < min2)
    {
        min2 = digit;
    }
}


Console.WriteLine($"  а) Две максимальные цифры: **{max1}** и **{max2}**");
Console.WriteLine($"  б) Две минимальные цифры: **{min1}** и **{min2}**");
