Console.Write("Введите натуральное число N: ");
string input = Console.ReadLine();
long n = long.Parse(input);

Console.Write("Введите цифру 'a' (0-9): ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите цифру 'b' (0-9): ");
int b = int.Parse(Console.ReadLine());

int positionAFromRight = 0;
int positionBFromRight = 0;
int currentPositionFromRight = 1;

long tempNumber = n;

while (tempNumber > 0)
{
    long digit = tempNumber % 10;

    if (digit == a && positionAFromRight == 0)
    {
        positionAFromRight = currentPositionFromRight;
    }
    if (digit == b && positionBFromRight == 0)
    {
        positionBFromRight = currentPositionFromRight;
    }

    if (positionAFromRight != 0 && positionBFromRight != 0)
    {
        break;
    }

    tempNumber /= 10;
    currentPositionFromRight++;
}
Console.WriteLine($"\nРезультаты для N={n}, a={a}, b={b}:");
Console.WriteLine($"Самая правая позиция цифры {a} (от конца): {positionAFromRight}");
Console.WriteLine($"Самая правая позиция цифры {b} (от конца): {positionBFromRight}");

string result;
if (positionAFromRight != 0 && positionBFromRight != 0)
{
    if (positionAFromRight < positionBFromRight)
    {
        result = $"Цифра **{a}** расположена правее цифры **{b}**.";
    }
    else if (positionBFromRight < positionAFromRight)
    {
        result = $"Цифра **{b}** расположена правее цифры **{a}**.";
    }
    else
    {
        result = "Цифры расположены на одной позиции (невозможно для разных цифр).";
    }
}
else if (positionAFromRight != 0)
{
    result = $"Цифра **{b}** отсутствует в числе.";
}
else if (positionBFromRight != 0)
{
    result = $"Цифра **{a}** отсутствует в числе.";
}
else
{
    result = $"В числе отсутствуют как цифра {a}, так и цифра {b}.";
}

Console.WriteLine($"\n**{result}**");
    