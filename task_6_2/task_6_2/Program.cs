Console.Write("Введите натуральное число 'n': ");
int n = int.Parse(Console.ReadLine());

int currentNumber = 1;
while (currentNumber <= n)
{
    Console.Write($"{currentNumber} ");

    currentNumber++;
}