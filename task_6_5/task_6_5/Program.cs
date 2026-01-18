int startNumber = 5000;
int requiredNumber = startNumber;
int divisor = 139;
while (requiredNumber % divisor != 0)
{
    requiredNumber--; 
}

Console.WriteLine($"\nМаксимальное число, не превышающее 5000 и делящееся на 139: **{requiredNumber}**\n");
