Console.Write("Введите натуральное число: ");

string input = Console.ReadLine();
if (long.TryParse(input, out long number))
{
    Console.WriteLine($"Цифры числа {number} в столбик:");
    foreach (char digitChar in input)
    {
        Console.WriteLine(digitChar);
    }
}
else
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное натуральное число.");
}