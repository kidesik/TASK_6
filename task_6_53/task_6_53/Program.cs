Console.Write("Введите натуральное число N: ");
long n = long.Parse(Console.ReadLine());

Console.Write("Введите цифру 'a' (0-9): ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите цифру 'b' (0-9): ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите пороговое значение 'k': ");
int k = int.Parse(Console.ReadLine());

long tempNumber = n;
bool hasDigitA = false;
bool hasDigitB = false;
int countOfA = 0;

while (tempNumber > 0)
{
    long digit = tempNumber % 10;

    if (digit == a)
    {
        hasDigitA = true;
        countOfA++;
    }

    if (digit == b)
    {
        hasDigitB = true;
    }

    tempNumber /= 10;
}

Console.WriteLine($"\nРезультаты для N={n}, a={a}, b={b}, k={k}:");

string resultA = hasDigitA ? "Да" : "Нет";
Console.WriteLine($"  а) Есть ли в числе цифра {a}? **{resultA}**");

string resultB = !hasDigitB ? "Верно (цифры нет)" : "Неверно (цифра есть)";
Console.WriteLine($"  б) Верно ли, что в нем нет цифры {b}? **{resultB}**");

string resultV = (countOfA > k) ? "Верно" : "Неверно";
Console.WriteLine($"  в) Верно ли, что цифра {a} встречается более {k} раз? **{resultV}** ({countOfA} раз)");

string resultG = (hasDigitA && hasDigitB) ? "Да (есть обе)" : "Нет (одной или обеих нет)";
Console.WriteLine($"  г) Есть ли в числе цифры {a} и {b} одновременно? **{resultG}**");
