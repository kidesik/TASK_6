Console.Write("Введите натуральное число N: ");

string inputN = Console.ReadLine();

Console.WriteLine($"\nИсходное число: {inputN}\n");

string resultA = new string(inputN.Reverse().ToArray());
Console.WriteLine($"  а) Число справа налево: **{resultA}**");

string resultB = "2" + inputN + "2";
Console.WriteLine($"  б) Число с 2 в начале и конце: **{resultB}**");

Console.Write("Введите цифру 'a' для удаления (0-9): ");
char aChar = Console.ReadKey().KeyChar;
Console.WriteLine();
string resultV = new string(inputN.Where(c => c != aChar).ToArray());
Console.WriteLine($"  в) Число без цифры '{aChar}': **{(string.IsNullOrEmpty(resultV) ? "Пусто" : resultV)}**");

string resultG = inputN;
if (inputN.Length > 1)
{
    char first = inputN[0];
    char last = inputN[inputN.Length - 1];
 
    resultG = last + inputN.Substring(1, inputN.Length - 2) + first;
}
Console.WriteLine($"  г) Число с переставленными первой и последней цифрами: **{resultG}**");

string resultD = inputN + inputN;
Console.WriteLine($"  д) Число, приписанное к себе: **{resultD}**");
