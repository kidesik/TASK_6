Console.Write("Введите длину 'a' (например, 4): ");
if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0) { Console.WriteLine("Ошибка ввода."); return; }

Console.Write("Введите ширину 'b' (например, 6): ");
if (!int.TryParse(Console.ReadLine(), out int b) || b <= 0) { Console.WriteLine("Ошибка ввода."); return; }

int length = Math.Max(a, b); 
int width = Math.Min(a, b);  
int totalFenceLength = 0;

while (length > 0 && width > 0)
{
    totalFenceLength += (length - 1);
    totalFenceLength += (width - 1);

    length -= 2;
    width -= 2;
}

Console.WriteLine($"\n--- Результаты для лужайки {a}x{b} ---");
Console.WriteLine($"Длина ограждения для такой лужайки будет равна: **{totalFenceLength}**");
