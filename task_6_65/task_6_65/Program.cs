Console.Write("Введите первое натуральное число (a): ");
if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0) { Console.WriteLine("Ошибка ввода."); return; }

Console.Write("Введите второе натуральное число (b): ");
if (!int.TryParse(Console.ReadLine(), out int b) || b <= 0) { Console.WriteLine("Ошибка ввода."); return; }

int numA = a;
int numB = b;

while (numB != 0)
{
    int remainder = numA % numB; 
    numA = numB;                 
    numB = remainder;            
}

int gcd = numA;

Console.WriteLine($"\nНаибольший общий делитель чисел {a} и {b} равен: **{gcd}**");
