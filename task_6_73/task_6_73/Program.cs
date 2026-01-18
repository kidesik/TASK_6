Console.Write("Введите проверяемое число (m): ");
double m = double.Parse(Console.ReadLine());

Console.Write("Введите первый член прогрессии (g): ");
double g = double.Parse(Console.ReadLine());

Console.Write("Введите знаменатель (r): ");
double r = double.Parse(Console.ReadLine());

if (g == 0)
{
    if (m == 0)
    {
        Console.WriteLine($"\nЧисло {m} **является** членом прогрессии (если r!=0).");
    }
    else
    {
        Console.WriteLine($"\nЧисло {m} **не является** членом прогрессии.");
    }
    return;
}

if (r == 0)
{
    if (m == g || m == 0)
    {
        Console.WriteLine($"\nЧисло {m} **является** членом прогрессии.");
    }
    else
    {
        Console.WriteLine($"\nЧисло {m} **не является** членом прогрессии.");
    }
    return;
}

if (m == 0)
{
    Console.WriteLine($"\nЧисло {m} **является** членом прогрессии (если r!=0).");
    return;
}
double ratio = m / g;

bool isMember = false;
double currentPower = 1.0;
int nMinus1 = 0; 
double epsilon = 1e-9;

if (ratio >= 1)
{
    while (currentPower < ratio + epsilon)
    {
        if (Math.Abs(currentPower - ratio) < epsilon)
        {
            isMember = true;
            break;
        }
        currentPower *= r;
        nMinus1++;
    }
}

double nMinus1_calc = Math.Log(Math.Abs(ratio)) / Math.Log(Math.Abs(r));
if (Math.Abs(nMinus1_calc - Math.Round(nMinus1_calc)) < epsilon)
{
    if (Math.Round(nMinus1_calc) >= 0)
    {
        isMember = true;
    }
}


if (isMember)
{
    Console.WriteLine($"\nЧисло {m} **является** членом геометрической прогрессии.");
}
else
{
    Console.WriteLine($"\nЧисло {m} **не является** членом геометрической прогрессии.");
}