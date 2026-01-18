Console.Write("Введите натуральное число N: ");

string input = Console.ReadLine();
long n = long.Parse(input);

bool isMonotonicallyIncreasing = true;

for (int i = 0; i < input.Length - 1; i++)
{
    if (input[i] >= input[i + 1])
    {
        isMonotonicallyIncreasing = false; 
        break;                             
    }
}

string resultText = isMonotonicallyIncreasing ? "Верно (цифры монотонно возрастают)" : "Неверно (порядок нарушен)";
Console.WriteLine($"\nОтвет: **{resultText}**.");