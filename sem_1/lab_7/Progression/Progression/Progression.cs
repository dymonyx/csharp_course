interface IProgression
{
    int GetElement(int k);

}

class ArithmeticProgression : IProgression
{
    int d;
    int a1;
    public ArithmeticProgression(int d, int a1)
    {
        this.d = d;
        this.a1 = a1;
    }
    public ArithmeticProgression()
    { }
    public int GetElement(int k)
    {
        return a1 + (k - 1) * d;
    }
}

class GeometricProgression : IProgression
{
    int q;
    int b1;

    public GeometricProgression(int q, int b1)
    {
        this.q = q;
        this.b1 = b1;
    }
    public GeometricProgression()
    { }

    public int GetElement(int k)
    {
        int res = 1;
        for (int i = 0; i < k - 1; i++)
        {
            res *= q;
        }
        return b1 * res;
    }

}

class Program
{
    public static void Main()
    {
        Console.Write("d = ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("a1 = ");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("k = ");
        int k = Convert.ToInt32(Console.ReadLine());
        ArithmeticProgression am = new ArithmeticProgression(d, a1);
        Console.WriteLine($"a[{k}] = {am.GetElement(k)}");
        Console.Write("q = ");
        int q = Convert.ToInt32(Console.ReadLine());
        Console.Write("b1 = ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("k = ");
        k = Convert.ToInt32(Console.ReadLine());
        GeometricProgression gm = new GeometricProgression(q, b1);
        Console.WriteLine($"b[{k}] = {gm.GetElement(k)}");
        

    }
}

