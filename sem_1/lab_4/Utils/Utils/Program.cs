using System;
class Utils
{
    public static int Greater(int a, int b)
    {
        if (a > b) return a;
        else return b;
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static bool Factorial(int n, out int answer)
    {
        int k;
        int f = 1;
        bool ok = true;
        try
        {
            checked
            {
                for (k = 2; k <= n; ++k) f *= k;
            }
        }
        catch (Exception)
        {
            f = 0;
            ok = false;
        }

        answer = f;
        return ok;

    }
}

class Program
{
    public static void Main()
    {
        int f, x;
        bool ok;
        Console.Write("Enter the num for factorial: ");
        x = Convert.ToInt32(Console.ReadLine());
        ok = Utils.Factorial(x, out f);
        if (ok) Console.WriteLine("The factorial of {0} is {1}.", x, f);
        else Console.WriteLine("Cannot compute this factorial");
    }
}
