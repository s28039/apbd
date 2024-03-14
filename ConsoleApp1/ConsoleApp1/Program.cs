// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");



static double GetAverage(int[] numbers)


{
    int sumaai = 0;
    foreach (var number in numbers)
    {
        sumaai += number;
    }
    
    return (double) sumaai / numbers.Length;
}

static double GetMax(int[] numbers)

{
    int max = 0;
    foreach (var number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
    }

    return max;
}

// int[] numbers = { 1, 2, 3, 4 };
// double avarage = GetAverage(numbers);