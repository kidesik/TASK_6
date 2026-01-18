Console.Write("Введите натуральное число N: ");

if (!long.TryParse(Console.ReadLine(), out long n) || n < 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
    return;
}

long tempNumber = n;
int currentPosition = 0; 
int foundPosition = 0;   
string numberString = n.ToString();
int totalDigits = numberString.Length;

while (tempNumber > 0)
{
    currentPosition++; 
    long digit = tempNumber % 10; 

    if (digit == 8)
    {
        break; 
    }

    tempNumber /= 10;
}


int leftmostEightIndex = -1; 
int positionFromEnd = 0;

for (int i = 0; i < totalDigits; i++)
{
    if (numberString[i] == '8')
    {
        leftmostEightIndex = i;
        break; 
    }
}

if (leftmostEightIndex != -1)
{
    positionFromEnd = totalDigits - leftmostEightIndex;
}

Console.WriteLine($"\nНомер самой левой цифры 8 (считая от конца числа): **{positionFromEnd}**");
