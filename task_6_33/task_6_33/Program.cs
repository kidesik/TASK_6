double initialArea = 100.0; 
double initialYield = 20.0; 
double areaGrowthRate = 1.05; 
double yieldGrowthRate = 1.02; 

double currentArea = initialArea;
double currentYield = initialYield;
double totalCumulativeHarvest = 0.0;
int year = 0;

int yearForA = 0;
int yearForB = 0;
int yearForC = 0;

Console.WriteLine($"\nНачальные данные (Год 1): Площадь={currentArea:F2} га, Урожайность={currentYield:F2} ц/га");
Console.WriteLine("Начинаем расчет по годам:");

while (true)
{
    year++;

    double annualHarvest = currentArea * currentYield;
    totalCumulativeHarvest += annualHarvest;

    Console.WriteLine($"Год {year}: Урожай за год={annualHarvest:F2} ц, Суммарный={totalCumulativeHarvest:F2} ц");

    if (yearForA == 0 && currentYield > 22.0)
    {
        yearForA = year;
    }

    if (yearForB == 0 && currentArea > 120.0)
    {
        yearForB = year;
    }

    if (yearForC == 0 && totalCumulativeHarvest > 800.0)
    {
        yearForC = year;
    }

    if (yearForA != 0 && yearForB != 0 && yearForC != 0)
    {
        break;
    }
    currentArea *= areaGrowthRate;
    currentYield *= yieldGrowthRate;
}

Console.WriteLine($"а) Урожайность превысит 22 ц с гектара в **{yearForA}**-м году.");
Console.WriteLine($"б) Площадь участка станет больше 120 га в **{yearForB}**-м году.");
Console.WriteLine($"в) Общий урожай превысит 800 ц в **{yearForC}**-м году.");
