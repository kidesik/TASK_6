Console.Write("Введите натуральное число: ");

string input = Console.ReadLine();
if (!long.TryParse(input, out long n) || n < 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
    return;
}

List<long> digits = new List<long>();
long temp = n;
while (temp > 0)
{
    digits.Add(temp % 10);
    temp /= 10;
}
long sumA = 0;
int signA = 1; 

foreach (long digit in digits.AsEnumerable().Reverse())
{
    sumA += signA * digit;
    signA *= -1; 
}

long sumB = 0;
int signB = 1; 

foreach (long digit in digits)
{
    sumB += signB * digit;
    signB *= -1; 
}

Console.WriteLine($"\nРезультаты для числа N = {n}:");
Console.WriteLine($"  а) Знакопеременная сумма слева направо: **{sumA}**");
Console.WriteLine($"  б) Знакопеременная сумма справа налево: **{sumB}**");
