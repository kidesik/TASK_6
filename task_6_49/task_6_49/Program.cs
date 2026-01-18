Console.Write("Введите натуральное число N: ");

string input = Console.ReadLine();
long n = long.Parse(input);

long tempNumber = n;
long sumOfDigits = 0;
long productOfDigits = 1;
int countOfDigits = 0;
long firstDigit = 0;
long lastDigit = n % 10;
while (tempNumber > 0)
{
    long digit = tempNumber % 10;

    sumOfDigits += digit;
    productOfDigits *= digit;
    countOfDigits++;

    firstDigit = digit; 

    tempNumber /= 10;
}

Console.WriteLine($"\nРезультаты для числа N = {n}:");

bool conditionA = (sumOfDigits > 10);
Console.WriteLine($"  а) Сумма цифр > 10? **{conditionA}**");

bool conditionB = (productOfDigits < 50);
Console.WriteLine($"  б) Произведение цифр < 50? **{conditionB}**");

bool conditionC = (countOfDigits % 2 == 0);
Console.WriteLine($"  в) Количество цифр четно? **{conditionC}**");

bool conditionD = (countOfDigits == 4);
Console.WriteLine($"  г) Число четырехзначное? **{conditionD}**");

bool conditionE = (firstDigit <= 6);
Console.WriteLine($"  д) Первая цифра <= 6? **{conditionE}**");

bool conditionF = (firstDigit == lastDigit);
Console.WriteLine($"  е) Начинается и заканчивается одинаково? **{conditionF}**");

string comparisonResult = (firstDigit > lastDigit) ? "Первая цифра больше последней." :
                        (lastDigit > firstDigit) ? "Последняя цифра больше первой." : "Первая и последняя цифры равны.";
Console.WriteLine($"  ж) Сравнение первой и последней цифр: **{comparisonResult}**");
