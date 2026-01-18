int startNumber = 191; 
int requiredNumber = startNumber;
int divisor = 17;
while (requiredNumber % divisor != 0)
{
    requiredNumber++; 
}

Console.WriteLine($"\nМинимальное число, большее 190 и делящееся на 17: **{requiredNumber}**\n");
