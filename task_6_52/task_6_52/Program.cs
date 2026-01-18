Console.Write("Введите натуральное число N: ");

long n = long.Parse(Console.ReadLine());

long tempNumber = n;
bool hasDigit3 = false;
bool hasDigit2 = false;
bool hasDigit5 = false;

while (tempNumber > 0)
{
    long digit = tempNumber % 10; 

    if (digit == 3) hasDigit3 = true;
    if (digit == 2) hasDigit2 = true;
    if (digit == 5) hasDigit5 = true;

    tempNumber /= 10; 
}

string resultA = hasDigit3 ? "Есть" : "Нет";
Console.WriteLine($"\nа) Есть ли в числе цифра 3? **{resultA}**");

string resultB;
if (hasDigit2 && hasDigit5)
{
    resultB = "Есть (присутствуют обе)";
}
else
{
    resultB = "Нет (одна или обе отсутствуют)";
}
Console.WriteLine($"б) Есть ли в числе цифры 2 и 5? **{resultB}**");
