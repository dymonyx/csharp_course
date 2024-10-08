using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("x=");
        float x = float.Parse(Console.ReadLine());
        Console.Write("y=");
        float y = float.Parse(Console.ReadLine());
        if (x * x + y * y < 9 && y > 0)
            Console.WriteLine("inside");
        else if (x * x + y * y > 9 || y < 0)
            Console.WriteLine("outside");
        else Console.WriteLine("on the line");
    }
}
