void Func(int number)
{
    double[] numbers = new double[number];
    int index = 0;
    while (index < number)
    {
        numbers[index] = Math.Pow((index + 1), 3);
        Console.WriteLine($"{numbers[index]}");
        index++;
    }
}

Console.Write("Please, print any number: ");
string your_number = Console.ReadLine();
int your_num = int.Parse(your_number);
Func(your_num);