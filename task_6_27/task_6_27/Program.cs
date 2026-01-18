int startFrom = 100;
int countToFind = 15;
int divisor = 19;

List<int> foundNumbers = new List<int>();
int currentNumber = startFrom;
while (foundNumbers.Count < countToFind)
{
    if (currentNumber % divisor == 0)
    {
        foundNumbers.Add(currentNumber);
    }
    currentNumber++;
}

Console.WriteLine($"\nПервые {countToFind} натуральных чисел, >= {startFrom} и делящихся на {divisor}:");
Console.WriteLine(string.Join(", ", foundNumbers));
Console.WriteLine($"\nПоследнее найденное число в списке: **{foundNumbers[foundNumbers.Count - 1]}**");
