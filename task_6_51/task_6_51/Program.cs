Console.Write("Введите натуральное число N: ");
string inputN = Console.ReadLine();
if (!long.TryParse(inputN, out long N) || N <= 0) { Console.WriteLine("Ошибка ввода N."); return; }

Console.Write("Введите целое число 'k': "); int k = int.Parse(Console.ReadLine());
Console.Write("Введите целое число 'b': "); long b = long.Parse(Console.ReadLine());
Console.Write("Введите целое число 'x': "); int x = int.Parse(Console.ReadLine());
Console.Write("Введите целое число 'y': "); int y = int.Parse(Console.ReadLine());
Console.Write("Введите целое число 'a': "); long a = long.Parse(Console.ReadLine());
Console.Write("Введите целое число 'n' (делитель): "); int paramN = int.Parse(Console.ReadLine());

long tempNumber = N;
long sumOfDigits = 0;
long productOfDigits = 1;
int countOfDigits = 0;
long firstDigit = 0;
long lastDigit = N % 10;

while (tempNumber > 0)
{
    long digit = tempNumber % 10;
    sumOfDigits += digit;
    productOfDigits *= digit;
    countOfDigits++;
    firstDigit = digit; 
    tempNumber /= 10;
}

Console.WriteLine($"\nРезультаты для числа N = {N}:");

bool conditionA = (sumOfDigits > k) && (N % 2 == 0);
Console.WriteLine($"  а) Сумма цифр > k ({k}) и число четное? **{conditionA}**");

bool conditionB = (countOfDigits % 2 == 0) && (N <= b);
Console.WriteLine($"  б) Количество цифр четно и N <= b ({b})? **{conditionB}**");

bool conditionG = (firstDigit == x) && (lastDigit == y);
Console.WriteLine($"  г) Начинается на {x} и заканчивается на {y}? **{conditionG}**");

bool conditionD = (productOfDigits < a) && (b != 0 && N % b == 0);
Console.WriteLine($"  д) Произведение цифр < a ({a}) и N делится на b ({b})? **{conditionD}**");

bool conditionE = (sumOfDigits > m) && (paramN != 0 && N % paramN == 0);
Console.WriteLine($"  е) Сумма цифр > m ({m}) и N делится на n ({paramN})? **{conditionE}**");
