Console.Write("Введите натуральное число N: ");

string inputN = Console.ReadLine();
if (!long.TryParse(inputN, out long n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода N.");
    return;
}

Console.Write("Введите целое число 'a' (для суммы): ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите целое число 'b' (для произведения): ");
long b = long.Parse(Console.ReadLine());

Console.Write("Введите целое число 'k' (для проверки разрядности): ");
int k = int.Parse(Console.ReadLine());

Console.Write("Введите целое число 'm' (для проверки первой цифры): ");
int m = int.Parse(Console.ReadLine());

long tempNumber = n;
long sumOfDigits = 0;
long productOfDigits = 1;
int countOfDigits = 0;
long firstDigit = 0;

while (tempNumber > 0)
{
    long digit = tempNumber % 10;

    sumOfDigits += digit;
    productOfDigits *= digit;
    countOfDigits++;

    firstDigit = digit; 

    tempNumber /= 10;
}

Console.WriteLine($"\nРезультаты для числа N = {n}, a={a}, b={b}, k={k}, m={m}:");

bool conditionA = (sumOfDigits < a);
Console.WriteLine($"  а) Сумма цифр ({sumOfDigits}) < {a}? **{conditionA}**");

bool conditionB = (productOfDigits > b);
Console.WriteLine($"  б) Произведение цифр ({productOfDigits}) > {b}? **{conditionB}**");

bool conditionC = (countOfDigits == k);
Console.WriteLine($"  в) Число {k}-значное? **{conditionC}**");

bool conditionD = (firstDigit > m);
Console.WriteLine($"  г) Первая цифра ({firstDigit}) > {m}? **{conditionD}**");
