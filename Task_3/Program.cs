double Func(int x1, int y1, int x2, int y2)
{
    double dist = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),+3);
    return dist;
}

Console.WriteLine(Func(3,6,2,1));