// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");



static double GetAverage(int[] numbers)


{
    int sumaaia = 0;
    foreach (var number in numbers)
    {
        sumaaia += number;
    }
    
    return (double) sumaaia / numbers.Length;
}

static double GetMax(int[] numbers)

{
    int maxii = 0;
    foreach (var number in numbers)
    {
        if (number > maxii)
        {
            maxii = number;
        }
    }

    return maxii;
}

// int[] numbers = { 1, 2, 3, 4 };
// double avarage = GetAverage(numbers);