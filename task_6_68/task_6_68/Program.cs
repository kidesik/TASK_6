Console.Write("Введите натуральное число для числителя (a): ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите натуральное число для знаменателя (b): ");
int b = int.Parse(Console.ReadLine());

int originalA = a;
int originalB = b;

while (b != 0)
{
    int temp = b;
    b = a % b;
    a = temp;
}
int gcd = a; 

int p = originalA / gcd; 
int q = originalB / gcd; 

Console.WriteLine($"\nИсходная дробь: {originalA}/{originalB}");
Console.WriteLine($"Наибольший общий делитель (НОД): {gcd}");
Console.WriteLine($"Сокращенная дробь: {p}/{q}");
Console.WriteLine($"\nРезультат (p/q): **{p}/{q}**");