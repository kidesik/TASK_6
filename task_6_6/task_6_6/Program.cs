Console.Write("Введите известное значение факториала (например, 120 для 5!): ");

long knownFactorial = long.Parse(Console.ReadLine());
if (knownFactorial == 1)
{
    Console.WriteLine($"\nЧисло N равно **1** (или 0).");
    return;
}

long currentProduct = 1; 
int n = 1;              
while (currentProduct < knownFactorial)
{
    n++; 
    currentProduct *= n; 
}

if (currentProduct == knownFactorial)
{
    Console.WriteLine($"\nИзвестное значение факториала принадлежит числу N = **{n}**.");
}
else
{
    Console.WriteLine($"\nВведенное число, вероятно, не является факториалом натурального числа.");
}