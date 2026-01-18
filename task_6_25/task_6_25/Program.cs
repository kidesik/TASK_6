Console.Write("Введите натуральное число N (N > 1): ");

if (!int.TryParse(Console.ReadLine(), out int n) || n <= 1)
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите натуральное число больше 1.");
    return;
}

int smallestDivisor = 0;
int currentDivisor = 2; 
while (n % currentDivisor != 0)
{
    currentDivisor++; 
}

smallestDivisor = currentDivisor;

Console.WriteLine($"\nНаименьший делитель числа {n}, отличный от 1: **{smallestDivisor}**");
