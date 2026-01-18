int startFrom = 500;
int countToFind = 20;

List<int> foundNumbers = new List<int>();
int currentNumber = startFrom;

Console.WriteLine($"\nИскомые числа:");
while (foundNumbers.Count < countToFind)
{
    if (currentNumber % 13 == 0 || currentNumber % 17 == 0)
    {
        foundNumbers.Add(currentNumber);
        Console.Write($"{currentNumber} ");
    }

    currentNumber++;
}

Console.WriteLine($"\n\nНайдено {foundNumbers.Count} чисел.");
Console.WriteLine($"Последнее найденное число в списке: **{foundNumbers[foundNumbers.Count - 1]}**");
