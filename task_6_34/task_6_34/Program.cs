Console.Write("Введите натуральное число 'm' (взаимно простое с n): ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите натуральное число 'n' (взаимно простое с m): ");
int n = int.Parse(Console.ReadLine());

int limit = m * n;

Console.WriteLine($"\nЧисла, кратные и {m}, и {n}, не превышающие {limit}:");

for (int i = 1; i <= limit; i++)
{
    if (i == limit)
    {
        Console.WriteLine($"**{i}**");
    }