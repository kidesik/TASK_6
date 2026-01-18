Console.Write("Введите натуральное число N: ");
if (!long.TryParse(Console.ReadLine(), out long n) || n < 0)
{
    Console.WriteLine("Ошибка ввода N.");
    return;
}

Console.Write("Введите значение 'a' (0 <= a <= 8): ");
if (!int.TryParse(Console.ReadLine(), out int a) || a < 0 || a > 8)
{
    Console.WriteLine("Ошибка ввода A. Значение должно быть от 0 до 8.");
    return;
}

Console.Write("Введите значение 'x' (для пункта г): ");
if (!int.TryParse(Console.ReadLine(), out int x) || x < 0 || x > 9)
{
    Console.WriteLine("Ошибка ввода X. Значение должно быть от 0 до 9.");
    return;
}

Console.Write("Введите значение 'y' (для пункта г): ");
if (!int.TryParse(Console.ReadLine(), out int y) || y < 0 || y > 9)
{
    Console.WriteLine("Ошибка ввода Y. Значение должно быть от 0 до 9.");
    return;
}


long tempNumber = n;

int countOfA = 0;             
long sumOfDigitsGreaterThanA = 0; 
long sumOfEvenDigits = 0;      
int countOfXAndY = 0;          
while (tempNumber > 0)
{
    long digit = tempNumber % 10;

    if (digit == a) countOfA++;

    if (digit > a) sumOfDigitsGreaterThanA += digit;

    if (digit % 2 == 0) sumOfEvenDigits += digit;

    if (digit == x || digit == y) countOfXAndY++;

    tempNumber /= 10;
}

Console.WriteLine($"\nРезультаты для числа N = {n}, a = {a}, x = {x}, y = {y}:");
Console.WriteLine($"  а) Количество вхождений цифры {a}: **{countOfA}**");
Console.WriteLine($"  б) Сумма цифр, больших {a}: **{sumOfDigitsGreaterThanA}**");
Console.WriteLine($"  в) Сумма его четных цифр: **{sumOfEvenDigits}**");
Console.WriteLine($"  г) Количество вхождений цифр {x} или {y}: **{countOfXAndY}**");
