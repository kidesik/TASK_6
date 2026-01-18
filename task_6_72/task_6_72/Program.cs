Console.Write("Введите проверяемое число (i): ");
double i = double.Parse(Console.ReadLine());

Console.Write("Введите первый член прогрессии (f): ");
double f = double.Parse(Console.ReadLine());

Console.Write("Введите шаг прогрессии (s): ");
double s = double.Parse(Console.ReadLine());

if (s == 0)
{
    if (i == f)
    {
        Console.WriteLine($"\nПрогрессия постоянна. Число {i} **является** ее членом.");
    }
    else
    {
        Console.WriteLine($"\nПрогрессия постоянна. Число {i} **не является** ее членом.");
    }
    return;
}

double difference = i - f;


if ((difference % s == 0) && (difference / s) >= 0)
{
    int n = (int)(difference / s) + 1;
    Console.WriteLine($"\nЧисло {i} **является** членом арифметической прогрессии (порядковый номер n = {n}).");
}
else
{
    Console.WriteLine($"\nЧисло {i} **не является** членом арифметической прогрессии.");
}