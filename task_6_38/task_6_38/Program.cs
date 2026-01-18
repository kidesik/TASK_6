Console.Write("Введите натуральное число N: ");

if (!long.TryParse(Console.ReadLine(), out long n) || n < 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
    return;
}

long tempNumber = n;
int currentPosition = 0; 
int foundPosition = 0;   
while (tempNumber > 0)
{
    currentPosition++; 
    long digit = tempNumber % 10; 

    if (digit == 3)
    {
        
        foundPosition = currentPosition;
        break; 
    }

    tempNumber /= 10; 
}

Console.WriteLine($"\nНомер самой правой цифры 3 (считая от конца числа): **{foundPosition}**");
