Console.Write("Введите длину 'a': ");
if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0) { Console.WriteLine("Ошибка ввода."); return; }

Console.Write("Введите ширину 'b': ");
if (!int.TryParse(Console.ReadLine(), out int b) || b <= 0) { Console.WriteLine("Ошибка ввода."); return; }

int length = Math.Max(a, b); 
int width = Math.Min(a, b);  
List<string> squares = new List<string>();

while (width > 0)
{
    int squareSize = width;
    int count = length / width; 

    squares.Add($"{count} шт. размером {squareSize}x{squareSize}");

    int remainder = length % width; 
    length = width;
    width = remainder;
}

Console.WriteLine($"\n--- Результаты для прямоугольника {a}x{b} ---");
Console.WriteLine("Исходный прямоугольник будет разрезан на следующие квадраты:");

foreach (string description in squares)
{
    Console.WriteLine($"- **{description}**");
}