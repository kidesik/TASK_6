Console.Write("Введите натуральное число N (сумма к выплате): ");

if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода. Введите натуральное число.");
    return;
}

int remainingSum = n;
int[] denominations = { 64, 32, 16, 8, 4, 2, 1 };
Dictionary<int, int> payment = new Dictionary<int, int>();
int totalNotes = 0;

foreach (int denom in denominations)
{
    if (remainingSum >= denom)
    {
        int count = remainingSum / denom;
        payment[denom] = count;
        totalNotes += count;
        remainingSum %= denom;
    }
}

Console.WriteLine($"\n--- Результат для суммы {n} ---");
Console.WriteLine($"Минимальное количество купюр: **{totalNotes}**");
Console.WriteLine("Используемые купюры:");
foreach (var kvp in payment)
{
    Console.WriteLine($"- {kvp.Value} шт. достоинством {kvp.Key}");
}