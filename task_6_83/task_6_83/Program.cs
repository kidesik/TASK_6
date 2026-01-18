Console.Write("Введите натуральное число N (например, 13579 или 76520): ");

string input = Console.ReadLine();
long n = long.Parse(input);

bool isMonotonicallyIncreasing = true;
bool isMonotonicallyDecreasing = true;

for (int i = 0; i < input.Length - 1; i++)
{
    if (input[i] >= input[i + 1])
    {
        isMonotonicallyIncreasing = false;
    }

    if (input[i] <= input[i + 1])
    {
        isMonotonicallyDecreasing = false;
    }

    if (!isMonotonicallyIncreasing && !isMonotonicallyDecreasing)
    {
        break;
    }
}

string resultText;
if (isMonotonicallyIncreasing)
{
    resultText = "Верно, последовательность монотонно возрастающая.";
}
else if (isMonotonicallyDecreasing)
{
    resultText = "Верно, последовательность монотонно убывающая.";
}
else
{
    resultText = "Неверно, последовательность не является монотонной (ни возрастающей, ни убывающей).";
}

Console.WriteLine($"\nОтвет: **{resultText}**.");