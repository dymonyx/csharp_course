class Operation
{
    public static int QuadraticEquation(double a, double b, double c, out double x1, out double x2)
    {
        int res = 1;
        double discr = b *b - 4 * a * c;
        if (discr > 0)
        {
            x1 = (-b + Math.Sqrt(discr)) / (2*a);
            x2 = (-b - Math.Sqrt(discr)) / (2*a);
        }
        else if (discr == 0)
        {
            x1 = x2 = (-b) / (2*a);
            res = 0;
        }
        else 
        {
            x1 = x2 = 0;
            res = -1;
        }
        return res;

    }
}

class Program
{
    public static void Main()
    {
        Console.Write("Enter the a b c const for the equation: ");
        string line = Console.ReadLine();
        string[] splitString = line.Split(" ");
        double a = Convert.ToDouble(splitString[0]);
        double b = Convert.ToDouble(splitString[1]);
        double c = Convert.ToDouble(splitString[2]);
        double x1, x2;
        int res = Operation.QuadraticEquation(a, b, c, out x1, out x2);
        if (res == 1) Console.WriteLine($"Roots of equation with a = {a}, b = {b}, c = {c} is {x1} and {x2}.");
        else if (res == 0) Console.WriteLine($"Root of equation with a = {a}, b = {b}, c = {c} is {x1}.");
        else Console.WriteLine($"There is no root of equation with a = {a}, b = {b}, c = {c}.");





    }
}
