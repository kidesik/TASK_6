Console.Write("Введите натуральное число N: ");

if (!long.TryParse(Console.ReadLine(), out long n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода. Введите натуральное число.");
    return;
}

if (n == 1)
{
    Console.WriteLine($"\nЧисло {n} **является** членом последовательности Фибоначчи.");
    return;
}

long a = 1; 
long b = 1; 
bool isFibonacci = false;

while (b < n)
{
    long nextFib = a + b;
    a = b;
    b = nextFib;

    if (b == n)
    {
        isFibonacci = true;
        break; 
    }
}

string resultText = isFibonacci ? "является" : "не является";
Console.WriteLine($"\nЧисло {n} **{resultText}** членом последовательности Фибоначчи.");
