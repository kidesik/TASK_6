decimal initialDeposit = 1000m; 
decimal rate = 0.02m;           

decimal currentAmount = initialDeposit;
int month = 0;
int monthForA = 0;
int monthForB = 0;

Console.WriteLine($"\nНачальный вклад: {currentAmount:C2}");
Console.WriteLine("Начинаем расчет по месяцам:");
while (true)
{
    month++;
    decimal monthlyIncrease = currentAmount * rate;

    currentAmount += monthlyIncrease;

    Console.WriteLine($"Месяц {month}: Прирост={monthlyIncrease:C2}, Сумма={currentAmount:C2}");

    if (monthForA == 0 && monthlyIncrease > 30m)
    {
        monthForA = month;
    }
    if (monthForB == 0 && currentAmount > 1200m)
    {
        monthForB = month;
    }
    if (monthForA != 0 && monthForB != 0)
    {
        break;
    }
}

Console.WriteLine($"\n--- Результаты ---");
Console.WriteLine($"а) Величина ежемесячного увеличения вклада превысит 30 руб. за **{monthForA}** месяц.");
Console.WriteLine($"б) Размер вклада превысит 1200 руб. через **{monthForB}** месяцев.");
