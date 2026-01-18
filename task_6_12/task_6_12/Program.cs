Console.WriteLine("\nВведите последовательность целых чисел. Ввод нуля завершает ввод.");

int inputNumber;

while (true)
{
    Console.Write("Введите число: ");

    if (int.TryParse(Console.ReadLine(), out inputNumber))
    {
        Console.WriteLine($"Вы ввели число: **{inputNumber}**");
        if (inputNumber == 0)
        {
            break; 
        }
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
    }
}

Console.WriteLine("\nПрограмма завершена.");