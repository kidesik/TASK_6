Console.Write("Введите первое натуральное число (a): ");
if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0) { Console.WriteLine("Ошибка ввода."); return; }

Console.Write("Введите второе натуральное число (b): ");
if (!int.TryParse(Console.ReadLine(), out int b) || b <= 0) { Console.WriteLine("Ошибка ввода."); return; }

Console.Write("Введите третье натуральное число (c): ");
if (!int.TryParse(Console.ReadLine(), out int c) || c <= 0) { Console.WriteLine("Ошибка ввода."); return; }

int gcd_ab = 0;
int numA = a;
int numB = b;
while (numB != 0)
{
    int temp = numB;
    numB = numA % numB;
    numA = temp;
}
gcd_ab = numA; 

int numC = c;
int finalGcd = 0;
while (numC != 0)
{
    int temp = numC;
    numC = gcd_ab % numC;
    gcd_ab = temp;
}
finalGcd = gcd_ab; 

Console.WriteLine($"\nНаибольший общий делитель чисел {a}, {b} и {c} равен: **{finalGcd}**");
