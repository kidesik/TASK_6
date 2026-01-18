int inputNumber;
bool isInputValid = false;

do
{
    Console.Write("Пожалуйста, введите четное число: ");

    if (int.TryParse(Console.ReadLine(), out inputNumber))
    {
        if (inputNumber % 2 == 0)
        {
            isInputValid = true; 
            Console.WriteLine("\nСпасибо! Число **{0}** принято.", inputNumber);
        }
        else
        {
            Console.WriteLine("Ошибка: Вы ввели нечетное число. Попробуйте снова.");
        }
    }
    else
    {
        Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
    }

} while (!isInputValid);