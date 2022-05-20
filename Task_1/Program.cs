void Func(int x, int y)
{
    if (x>0 & y > 0)
    {
        Console.WriteLine("Qurter - 1");
    }
    else if (x<0 & y>0)
    {
        Console.WriteLine("Qurter - 2");
    }
    else if (x<0 & y<0)
    {
        Console.WriteLine("Qurter - 3");
    }
    else if (x>0 & y<0)
    {
        Console.WriteLine("Qurter - 4");
    }
    else
    {
        Console.WriteLine("Point is on the coordinate oxis.");
    }
}

Func(1,1);
Func(-1,1);
Func(-1,-1);
Func(1,-1);
Func(0,0);