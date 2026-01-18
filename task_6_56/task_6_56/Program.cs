Console.Write("Введите натуральное число N: ");

string input = Console.ReadLine();
long n = long.Parse(input);

int position2 = -1;
int position5 = -1;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '2' && position2 == -1)
    {
        position2 = i + 1;
    }
    if (input[i] == '5' && position5 == -1)
    {
        position5 = i + 1;
    }

    if (position2 != -1 && position5 != -1)
    {
        break;
    }
}
Console.WriteLine($"\nРезультаты для N={n}:");
Console.WriteLine($"Самая левая позиция цифры 2: {position2}");
Console.WriteLine($"Самая левая позиция цифры 5: {position5}");

string result;
if (position2 != -1 && position5 != -1)
{
    if (position2 < position5)
    {
        result = "Цифра **2** расположена левее цифры 5.";
    }
    else if (position5 < position2)
    {
        result = "Цифра **5** расположена левее цифры 2.";
    }
    else
    {
        result = "Цифры расположены на одной позиции (невозможно для разных цифр).";
    }
}
else if (position2 != -1)
{
    result = "Цифра **5** отсутствует в числе.";
}
else if (position5 != -1)
{
    result = "Цифра **2** отсутствует в числе.";
}
else
{
    result = "В числе отсутствуют как цифра 2, так и цифра 5.";
}

Console.WriteLine($"\n**{result}**");
    