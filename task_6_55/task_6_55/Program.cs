Console.Write("Введите натуральное число N: ");
long n = long.Parse(Console.ReadLine());

Console.Write("Введите цифру 'a' (0-9): ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите цифру 'b' (0-9): ");
int b = int.Parse(Console.ReadLine());

long tempNumber = n;
int countA = 0;
int countB = 0;

while (tempNumber > 0)
{
    long digit = tempNumber % 10;

    if (digit == a) countA++;
    if (digit == b) countB++;

    tempNumber /= 10;
}

Console.WriteLine($"\nРезультаты для N={n}, a={a}, b={b}:");
Console.WriteLine($"Цифра {a} встречается {countA} раз(а).");
Console.WriteLine($"Цифра {b} встречается {countB} раз(а).");

bool isARarerThanB = countA < countB;
string resultText = isARarerThanB ? "Верно" : "Неверно";

Console.WriteLine($"\nОтвет: **{resultText}**, цифра {a} встречается реже, чем цифра {b}.");
