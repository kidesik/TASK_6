Console.Write("Введите натуральное число N: ");

long n = long.Parse(Console.ReadLine());

long tempNumber = n;
int count0 = 0;
int count9 = 0;

while (tempNumber > 0)
{
    long digit = tempNumber % 10; 

    if (digit == 0) count0++;
    if (digit == 9) count9++;

    tempNumber /= 10; 
}

Console.WriteLine($"\nРезультаты для N={n}:");
Console.WriteLine($"Количество цифр 0: {count0}");
Console.WriteLine($"Количество цифр 9: {count9}");

string result;
if (count0 > count9)
{
    result = "Цифра **0** встречается чаще.";
}
else if (count9 > count0)
{
    result = "Цифра **9** встречается чаще.";
}
else
{
    result = "Цифры 0 и 9 встречаются одинаковое количество раз.";
}

Console.WriteLine($"\n**{result}**");