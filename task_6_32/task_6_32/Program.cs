double initialRun = 10.0; 
double increaseFactor = 1.1; 

double currentRun = initialRun;
double totalDistance = 0.0;
int day = 0;

int dayForA = 0;
int dayForB = 0;

Console.WriteLine($"\nНачальный пробег в первый день: {initialRun:F2} км");
Console.WriteLine("Начинаем расчет по дням:");

while (true)
{
    day++;
    if (day > 1)
    {
        currentRun *= increaseFactor;
    }

    totalDistance += currentRun;

    Console.WriteLine($"День {day}: Пробег за день={currentRun:F2} км, Суммарный пробег={totalDistance:F2} км");

    if (dayForA == 0 && currentRun > 20.0)
    {
        dayForA = day;
    }

    if (dayForB == 0 && totalDistance > 100.0)
    {
        dayForB = day;
    }
    if (dayForA != 0 && dayForB != 0)
    {
        break;
    }
}

Console.WriteLine($"а) Он пробежит больше 20 км в **{dayForA}**-й день.");
Console.WriteLine($"б) Суммарный пробег за все дни превысит 100 км в **{dayForB}**-й день.");
