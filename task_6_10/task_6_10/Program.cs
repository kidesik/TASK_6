
const int SECRET_PASSWORD = 1234;
int inputPassword;

do
{
    Console.Write("Пожалуйста, введите пароль (целое число): ");

    if (!int.TryParse(Console.ReadLine(), out inputPassword))
    {
        Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите только цифры.");
        continue;
    }
    if (inputPassword != SECRET_PASSWORD)
    {
        Console.WriteLine("Ошибка: Неправильный пароль. Попробуйте снова.");
    }

} while (inputPassword != SECRET_PASSWORD);

Console.WriteLine("\n**Приветствуем!** Пароль принят.");
