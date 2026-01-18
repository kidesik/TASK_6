Console.Write("Введите первое натуральное число (a): ");
if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0) { Console.WriteLine("Ошибка ввода."); return; }

Console.Write("Введите второе натуральное число (b): ");
if (!int.TryParse(Console.ReadLine(), out int b) || b <= 0) { Console.WriteLine("Ошибка ввода."); return; }

int numA_gcd = a;
int numB_gcd = b;
int gcd = 0;

while (numB_gcd != 0)
{
    int temp = numB_gcd;
    numB_gcd = numA_gcd % numB_gcd;
    numA_gcd = temp;
}
gcd = numA_gcd;
long lcm = ((long)a * b) / gcd;

Console.WriteLine($"\nНаибольший общий делитель (НОД): {gcd}");
Console.WriteLine($"Наименьшее общее кратное (НОК) чисел {a} и {b} равно: **{lcm}**");
