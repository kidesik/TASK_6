Console.Write("Введите натуральное число N: ");

string input = Console.ReadLine();

if (!long.TryParse(input, out long n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
    return;
}

bool isPalindrome = true;
int length = input.Length;

for (int i = 0; i < length / 2; i++)
{
    if (input[i] != input[length - 1 - i])
    {
        isPalindrome = false; 
        break;                
    }
}

string resultText = isPalindrome ? "является палиндромом" : "не является палиндромом";
Console.WriteLine($"\nЧисло {n} **{resultText}**.");