Console.Write("Введите натуральное число N: ");
if (!long.TryParse(Console.ReadLine(), out long n) || n < 0)
{
    Console.WriteLine("Ошибка ввода. Введите натуральное число.");
    return;
}

Console.Write("Введите количество последних цифр m: ");
if (!int.TryParse(Console.ReadLine(), out int m) || m < 0)
{
    Console.WriteLine("Ошибка ввода. Введите натуральное число m.");
    return;
}

long sumOfLastDigits = 0;
long tempNumber = n;
int countProcessed = 0;

while (countProcessed < m && tempNumber > 0)
{
    long digit = tempNumber % 10; 
    sumOfLastDigits += digit;     
    tempNumber /= 10;             
    countProcessed++;             
}

Console.WriteLine($"\nСумма {countProcessed} последних цифр числа {n} равна: **{sumOfLastDigits}**");
