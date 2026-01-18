int startFrom = 100;
int countToFind = 10;

List<int> foundNumbers = new List<int>();
int currentNumber = startFrom;

Console.WriteLine($"\nИскомые числа:");
while (foundNumbers.Count < countToFind)
{
    int lastDigit = currentNumber % 10;

    if (lastDigit == 7 && currentNumber % 9 == 0)
    {
        foundNumbers.Add(currentNumber);
        Console.Write($"{currentNumber} ");
    }
    currentNumber++;
}

Console.WriteLine($"\nНайдено {foundNumbers.Count} чисел.");
Console.WriteLine($"Последнее найденное число в списке: **{foundNumbers[foundNumbers.Count - 1]}**");
