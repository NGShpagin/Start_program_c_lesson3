void Func(int number)
{
    int index = 0;
    double[] numbers = new double[number];
    Console.Write($"{number}-->");
    while (index < number)
    {
        numbers[index] = Math.Pow((index+1), 2);
        Console.Write($"{numbers[index]}, ");
        index += 1;
    }
}

Func(6);
Func(2);
Func(11);