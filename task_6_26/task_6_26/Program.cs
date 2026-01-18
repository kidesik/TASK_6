{
    Console.WriteLine("Числа, кратные 13 и меньшие 100:");
    for (int i = 13; i < 100; i += 13)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine("\n");
}
{
    Console.WriteLine("Числа, кратные 13 и меньшие 100:");

    int currentNumber = 13; 

    while (currentNumber < 100)
    {
        Console.Write($"{currentNumber} ");

        
        currentNumber += 13;
    }

}
