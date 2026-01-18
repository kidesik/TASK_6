Console.Write("Введите натуральное число N: ");

if (!long.TryParse(Console.ReadLine(), out long n) || n < 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
    return;
}

long tempNumber = n;
long lastDigit = n % 10;
int countOfThrees = 0;         
int countOfLastDigit = 0;      
int countOfEvenDigits = 0;     
long sumOfDigitsGreaterThanFive = 0;    
long productOfDigitsGreaterThanSeven = 1; 
int countOfZeroesAndFives = 0;    

while (tempNumber > 0)
{
    long digit = tempNumber % 10;
    if (digit == 3) countOfThrees++;
    if (digit == lastDigit) countOfLastDigit++;
    if (digit % 2 == 0) countOfEvenDigits++;
    if (digit > 5) sumOfDigitsGreaterThanFive += digit;
    if (digit > 7) productOfDigitsGreaterThanSeven *= digit;
    if (digit == 0 || digit == 5) countOfZeroesAndFives++;

    tempNumber /= 10;
}

Console.WriteLine($"\nРезультаты для числа N = {n}:");
Console.WriteLine($"  а) Количество цифр 3: **{countOfThrees}**");
Console.WriteLine($"  б) Количество вхождений последней цифры ({lastDigit}): **{countOfLastDigit}**");
Console.WriteLine($"  в) Количество четных цифр: **{countOfEvenDigits}**");
Console.WriteLine($"  г) Сумма цифр, больших 5: **{sumOfDigitsGreaterThanFive}**");
Console.WriteLine($"  д) Произведение цифр, больших 7: **{productOfDigitsGreaterThanSeven}**");
Console.WriteLine($"  е) Количество цифр 0 и 5 (всего): **{countOfZeroesAndFives}**");
