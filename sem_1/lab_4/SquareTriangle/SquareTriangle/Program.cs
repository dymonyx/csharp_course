using System;

class Operation
{
    private static bool IsTriangle(double a, double b, double c)
    {
        bool flag = false;
        if ((a < b + c) && (b < a + c) && (c < a + b)) flag = true;
        return flag;
    }
    public static double Square(double a, double b, double c)
    {
        bool isTriangle = IsTriangle(a, b, c);
        if (!isTriangle) return 0;
        double sp = (a+b+c)/2;
        double square = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
        return Math.Round(square, 2);
    }

    public static double Square(double a)
    {
        double sp = (a*3)/2;
        double square = Math.Sqrt(sp * Math.Pow((sp - a), 3));
        return Math.Round(square, 2);
    }
}

class Program
{
    public static void Main()
    {
        Console.Write("Is your triangle equilateral? (yes/no): ");
        string answer = Console.ReadLine();
        if (answer == "yes")
        {
            Console.Write("Enter side of your triangle: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double square = Operation.Square(x);
            Console.WriteLine($"Square of triangle is {square}");

        }
        else
        {
            Console.Write("Enter sides of your triangle: ");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            double x1 = Convert.ToDouble(splitString[0]);
            double x2 = Convert.ToDouble(splitString[1]);
            double x3 = Convert.ToDouble(splitString[2]);
            double square = Operation.Square(x1, x2, x3);
            Console.WriteLine($"Square of triangle is {square}");

        }
        
    }
}

