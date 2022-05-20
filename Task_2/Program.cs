void Func(int quarter)
{
    if (quarter == 1)
    {
        Console.WriteLine($"Quarter {quarter}, Available - x>0,y>0");
    }
    else if (quarter == 2)
    {
        Console.WriteLine($"Quarter {quarter}, Available - x<0,y>0");
    }
    else if (quarter == 3)
    {
        Console.WriteLine($"Quarter {quarter}, Available - x<0,y<0");
    }
    else if (quarter == 4)
    {
        Console.WriteLine($"Quarter {quarter}, Available - x>0,y<0");
    }
    else
    {
        Console.WriteLine("Please, print number from 1 to 4");
    }
}

Func(1);
Func(2);
Func(3);
Func(4);
Func(5);