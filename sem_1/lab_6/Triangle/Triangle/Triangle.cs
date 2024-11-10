class Triangle
{
    private int a;
    private int b;
    private int c;
    public Triangle(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void Show()
    {
        Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
    }

    public double Perimeter()
    {
        double perimeter = Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c);
        return perimeter;
    }

    public double Square()
    {
        double sp = (a+b+c)/2;
        double square = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
        return Math.Round(square, 2);
    }

    public bool IsTriangle()
    {
        bool flag = false;
        if ((a < b + c) && (b < a + c) && (c < a + b)) flag = true;
        return flag;
    }
}

class Program
{
    public static void Main()
    {
        Triangle tr = new Triangle(3, 4, 5);
        tr.Show();
        Console.WriteLine($"Perimeter = {tr.Perimeter()}");
        Console.WriteLine($"Square = {tr.Square()}");
        if (tr.IsTriangle()) Console.WriteLine("Triangle is.");
        else Console.WriteLine("Triangle isn't.");
    }
}
