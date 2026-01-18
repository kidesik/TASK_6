Console.Write("Введите натуральное число N (N > 9): ");

long n = long.Parse(Console.ReadLine());
long temp = n;

int countOfDigits = 0;
long tempCounter = n;
while (tempCounter > 0)
{
    tempCounter /= 10;
    countOfDigits++;
}

if (countOfDigits < 2)
{
    Console.WriteLine("Вторая цифра отсутствует.");
    return;
}

long divisor = (long)Math.Pow(10, countOfDigits - 2);
long result = temp / divisor;
long secondDigit = result % 10;

Console.WriteLine($"\nВторая цифра числа {n}: **{secondDigit}**\n");