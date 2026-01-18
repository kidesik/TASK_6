Console.Write("Введите целое число 'a': ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите целое число 'b': ");
int b = int.Parse(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("Ошибка: Делитель 'a' не может быть нулем.");
    return;
}

int absA = Math.Abs(a);
int absB = Math.Abs(b);
int quotient = 0; 
int remainder = absB; 

while (remainder >= absA)
{
    remainder -= absA;
    quotient++;
}

int sign = (a < 0) ^ (b < 0) ? -1 : 1;
int finalQuotient = quotient * sign;

Console.WriteLine($"\nа) Результат целочисленного деления ({b} на {a}): **{finalQuotient}**");

int finalRemainder = remainder;
if (b < 0)
{
    if (finalRemainder != 0)
    {
        finalRemainder = finalRemainder - absA;
    }
}

Console.WriteLine($"б) Остаток от деления ({b} на {a}): **{finalRemainder}**");
