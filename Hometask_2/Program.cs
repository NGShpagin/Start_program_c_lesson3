double Func(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), +2);
    return dist;
}

Console.WriteLine(Func(3, 6, 8, 2, 1, -7));