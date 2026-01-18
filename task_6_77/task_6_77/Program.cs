Console.Write("Введите натуральное число N: ");

string input = Console.ReadLine();
if (!long.TryParse(input, out long n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
    return;
}

bool allDigitsSame = true;
if (input.Length > 0)
{
    char firstDigit = input;
    foreach (char digit in input)
    {
        if (digit != firstDigit)
        {
            allDigitsSame = false;
            break;
        }
    }
}
string resultA = allDigitsSame ? "Да, состоит из одинаковых цифр" : "Нет, цифры различаются";
Console.WriteLine($"\nа) Число N состоит из одинаковых цифр? **{resultA}** (например, 666)");

bool hasAdjacentSameDigits = false;
for (int i = 0; i < input.Length - 1; i++)
{
    if (input[i] == input[i + 1])
    {
        hasAdjacentSameDigits = true;
        break; 
    }
}
string resultB = hasAdjacentSameDigits ? "Да, содержит рядом стоящие одинаковые цифры" : "Нет, рядом стоящих одинаковых цифр нет";
Console.WriteLine($"б) Число N содержит две одинаковые цифры, стоящие рядом? **{resultB}** (например, 35510)");
