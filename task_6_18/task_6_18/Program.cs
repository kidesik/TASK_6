{
    int a = 25;
    int b = 16;
    int i = a; 
    while (i >= b) 
    {
        Console.WriteLine($"Квадратный корень из {i}: {Math.Sqrt(i):F4}");
        i--;                  
    }
}
{
    int a = 25;
    int b = 16;
    int i = a; 
    do
    {
        Console.WriteLine($"Квадратный корень из {i}: {Math.Sqrt(i):F4}");
        i--;                  
    } while (i >= b);
}