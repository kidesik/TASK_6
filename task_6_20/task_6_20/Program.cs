Console.Write("Введите натуральное число: ");

string input = Console.ReadLine();
if (!long.TryParse(input, out long number) || number < 0)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
    return;
}


long sumOfDigits = 0;          
int countOfDigits = 0;          
long productOfDigits = 1;       
double sumOfSquares = 0;        
double sumOfCubes = 0;          
long firstDigit = 0;            
long lastDigit = number % 10;   

long tempNumber = number;

while (tempNumber > 0)
{
    long digit = tempNumber % 10;

    sumOfDigits += digit;
    countOfDigits++;
    productOfDigits *= digit;
    sumOfSquares += digit * digit;
    sumOfCubes += digit * digit * digit;

    firstDigit = digit;

    tempNumber /= 10;
}

Console.WriteLine($"\nРезультаты для числа N = {number}:");
Console.WriteLine($"  а) Сумма его цифр: **{sumOfDigits}**");
Console.WriteLine($"  б) Количество цифр в нем: **{countOfDigits}**");
Console.WriteLine($"  в) Произведение его цифр: **{productOfDigits}**");
double averageOfDigits = (double)sumOfDigits / countOfDigits;
Console.WriteLine($"  г) Среднее арифметическое его цифр: **{averageOfDigits:F4}**");
Console.WriteLine($"  д) Сумма квадратов его цифр: **{sumOfSquares}**");
Console.WriteLine($"  е) Сумма кубов его цифр: **{sumOfCubes}**");
Console.WriteLine($"  ж) Его первая цифра: **{firstDigit}**");
long sumFirstLast = firstDigit + lastDigit;
Console.WriteLine($"  з) Сумма его первой и последней цифр: **{sumFirstLast}**");
