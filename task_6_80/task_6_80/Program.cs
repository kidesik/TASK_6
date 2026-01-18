Console.Write("Введите натуральное число N: ");

string input = Console.ReadLine();
long n = long.Parse(input);

bool isIncreasingFromLeft = true;

for (int i = 0; i < input.Length - 1; i++)
{
    if (input[i] >= input[i + 1])
    {
        isIncreasingFromLeft = false; 
        break;                        
    }
}

string resultText = isIncreasingFromLeft ? "положительный (цифры возрастают слева направо)" : "отрицательный (порядок нарушен)";
Console.WriteLine($"\nОтвет: **{resultText}**.");