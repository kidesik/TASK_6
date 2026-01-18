Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"\nНатуральные числа, квадрат которых не превышает {n}:");

int currentNumber = 1;
while (currentNumber * currentNumber <= n)
{
    Console.Write($"{currentNumber} ");
    currentNumber++;
}