Console.Write("Введите натуральное число N (N > 99): ");

long n = long.Parse(Console.ReadLine());
long temp = n;

int countOfDigits = 0;
long tempCounter = n;
while (tempCounter > 0)
{
    tempCounter /= 10;
    countOfDigits++;
}

if (countOfDigits < 3)
{
    Console.WriteLine("Третья цифра отсутствует.");
    return;
}

long divisor = (long)Math.Pow(10, countOfDigits - 3);

long result = n / divisor;

long thirdDigit = result % 10;

Console.WriteLine($"\nТретья цифра числа {n}: **{thirdDigit}**");