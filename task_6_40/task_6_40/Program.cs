Console.Write("Введите натуральное число N: ");

string input = Console.ReadLine();

if (!long.TryParse(input, out long n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
    return;
}

char firstDigitChar = input[0];
int count = 0;

foreach (char digitChar in input)
{
    if (digitChar == firstDigitChar)
    {
        count++;
    }
}

Console.WriteLine($"\nПервая цифра числа {n} — это **{firstDigitChar}**.");
Console.WriteLine($"Она встречается в числе **{count}** раз(а).");
