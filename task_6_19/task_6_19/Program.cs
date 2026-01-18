Console.Write("Введите натуральное число: ");

string input = Console.ReadLine();

Console.WriteLine($"\nЦифры числа в столбик:");

foreach (char digitChar in input)
{
    Console.WriteLine(digitChar);
}