void CoordinatesSearch(int X, int Y)
{
    if (X == 0 || Y == 0)
    {
        Console.WriteLine("Параметры некорректны");
    }
    else
    {
        if (X > 0 && Y > 0)
        {
            System.Console.WriteLine("1");
        }
        if (X > 0 && Y < 0)
        {
            System.Console.WriteLine("4");
        }
        if (X < 0 && Y > 0)
        {
            System.Console.WriteLine("2");
        }
        if (X < 0 && Y < 0)
        {
            System.Console.WriteLine("3");
        }
    }
}
CoordinatesSearch(2, 3);
CoordinatesSearch(-2, 3);
CoordinatesSearch(2, -3);
CoordinatesSearch(-2, -3);
CoordinatesSearch(0, 0);
