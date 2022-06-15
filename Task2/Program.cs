void FuncRange(int quarter)
{
    if (quarter <= 4 && quarter >= 1)
    {
        if (quarter == 1)
        {
            System.Console.WriteLine("X > 0, Y > 0");
        }
        if (quarter == 2)
        {
            System.Console.WriteLine("X < 0, Y > 0");
        }
        if (quarter == 3)
        {
            System.Console.WriteLine("X < 0, Y < 0");
        }
        if (quarter == 4)
        {
            System.Console.WriteLine("X > 0, Y < 0");
        }
    }
    else
    {
        System.Console.WriteLine("Такой четвери нет");
    }
}
