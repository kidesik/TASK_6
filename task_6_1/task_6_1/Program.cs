Console.Write("Введите натуральное число 'a': ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите натуральное число 'b' (a > b): ");
int b = int.Parse(Console.ReadLine());

int quotient = 0; 
int remainder = a; 

while (remainder >= b)
{
    remainder = remainder - b;

    quotient++;
}

Console.WriteLine($"\nа) Результат целочисленного деления ({a} на {b}): **{quotient}**");
Console.WriteLine($"б) Остаток от деления ({a} на {b}): **{remainder}**\n");