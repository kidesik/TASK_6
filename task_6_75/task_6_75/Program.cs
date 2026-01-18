const double EPSILON = 0.001;
Console.WriteLine("\n--- Уравнение: f(x) = x^2 + 2x - 1 на отрезке [0, 1] ---");

double a = 0.0;
double b = 1.0;

double f(double x) => x * x + 2 * x - 1;

double fa = f(a);
double fb = f(b);

if (fa * fb >= 0)
{
    Console.WriteLine("Ошибка: Функция не меняет знак на заданном отрезке.");
    return;
}

double c = 0.0;
int iterations = 0;

while (Math.Abs(b - a) > EPSILON)
{
    iterations++;
    c = (a + b) / 2.0; 
    double fc = f(c);

    if (fc * fa < 0)
    {
        b = c; 
        fb = fc;
    }
    else
    {
        a = c; 
        fa = fc;
    }
}

double root = (a + b) / 2.0;

Console.WriteLine($"Приближенное значение корня: **{root:F4}**");
Console.WriteLine($"Найдено за {iterations} итераций.");
