int Func1(int number)
{
    int len = 1;
    while (number > 10)
    {
        number = number / 10;
        len++;
    }
    return len;
}

void Func2(int number)
{
    int len = Func1(number);
    int i = 1;
    while (i <= len)
    {
        double sqr = Math.Pow(10, len - 1);
        int sqr1 = (int)sqr;
        int number_1 = number % 10;
        int number_2 = number / sqr1;
        if (number_1 != number_2)
        {
            Console.WriteLine("is not a polindrom");
            return;
        }
        else
        {
            number = (number - (number_2 * sqr1)) / 10;
            len = len - 2;
            i++;
        }
    }
    Console.WriteLine("is a polindrom");
}

Console.Write("Please, print number with 5 digits: ");
string your_number = Console.ReadLine();
int your_num = int.Parse(your_number);
Console.Write($"Your number: '{your_number}' ");
Func2(your_num);
Console.WriteLine($"Number of digits: {Func1(your_num)}");