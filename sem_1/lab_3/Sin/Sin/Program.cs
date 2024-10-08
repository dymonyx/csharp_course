using System;
class Program
{

    public static void Main()
    {
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        double x, y;

        Console.WriteLine("{0, 5} | {1, 5}", "X", "Sin(x)");
        x = x1;
        do
            {
                y = Math.Round(Math.Sin(x), 3);
                Console.WriteLine("{0, 5} | {1, 5}", x, y);
                x = Math.Round(x + 0.01, 2);
            }
        while (x <= x2);
        
    }
}
