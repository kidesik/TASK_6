List<int> inputNumbers = new List<int>();
int maxInputs = 10;

Console.WriteLine($"\nВведите до {maxInputs} чисел. Ввод числа 0 прекращает процесс.");

for (int i = 0; i < maxInputs; i++)
{
    Console.Write($"Введите число {i + 1} из {maxInputs}: ");

    if (int.TryParse(Console.ReadLine(), out int inputNumber))
    {
        if (inputNumber == 0)
        {
            Console.WriteLine("Введен ноль. Ввод прекращен досрочно.");
            break; 
        }

        inputNumbers.Add(inputNumber);
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
        i--;
    }
}

Console.WriteLine($"\nВсего введено чисел: **{inputNumbers.Count}**");
if (inputNumbers.Count > 0)
{
    Console.WriteLine($"Список введенных чисел: {string.Join(", ", inputNumbers)}");
}
