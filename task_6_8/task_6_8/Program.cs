Console.Write("Введите натуральное число 'n': ");

int n = int.Parse(Console.ReadLine());
int k = 1; 
while (k * k <= n)
{
    k++; 
    if (k > 100) break;
}

Console.WriteLine($"\nПервое натуральное число, квадрат которого больше {n}: **{k}**\n");
