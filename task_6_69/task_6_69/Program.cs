int length = 425;
int width = 131;
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

Console.WriteLine("\nИсходный прямоугольник будет разрезан на следующие квадраты:");
foreach (string description in squares)
{
    Console.WriteLine($"- **{description}**");
}