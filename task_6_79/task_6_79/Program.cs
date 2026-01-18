Console.Write("Введите натуральное число N: ");

if (!long.TryParse(Console.ReadLine(), out long n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
    return;
}

long tempNumber = n;
long previousDigit = tempNumber % 10;
tempNumber /= 10;

bool isNonDecreasingFromRight = true;

while (tempNumber > 0)
{
    long currentDigit = tempNumber % 10; 
    if (currentDigit > previousDigit)
    {
        isNonDecreasingFromRight = false; 
        break;                           
    }

    previousDigit = currentDigit; 
    tempNumber /= 10;             
}

string resultText = isNonDecreasingFromRight ? "положительный (цифры не убывают справа налево)" : "отрицательный (порядок нарушен)";
Console.WriteLine($"\nОтвет: **{resultText}**.");
