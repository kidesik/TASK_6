Console.Write("Введите натуральное число N: ");

string input = Console.ReadLine();
long n = long.Parse(input);

bool isNonDecreasingFromLeft = true;

for (int i = 0; i < input.Length - 1; i++)
{
    if (input[i] > input[i + 1])
    {
        isNonDecreasingFromLeft = false; 
        break;                           
    }
}

string resultText = isNonDecreasingFromLeft ? "положительный (цифры не убывают слева направо)" : "отрицательный (порядок нарушен)";
Console.WriteLine($"\nОтвет: **{resultText}**.");