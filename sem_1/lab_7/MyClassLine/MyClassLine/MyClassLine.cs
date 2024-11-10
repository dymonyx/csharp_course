class Point
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Point()
    { }

    public void Show()
    {
        Console.WriteLine($"Точка c координатами: ({x}, {y})");
    }

    public double Dlina(Point p)
    {
        double Dl = Math.Sqrt((this.x - p.x) * (this.x - p.x) + (this.y - p.y) * (this.y - p.y));
        return Dl;
    }

    public override string ToString()
    {
        string ss = x + " ; " + y;
        return ss;
    }

}

class Line
{
    private Point pStart;
    private Point pEnd;
    public Line(Point pStart, Point pEnd)
    {
        this.pStart = pStart;
        this.pEnd = pEnd;
    }

    public Line()
    { }

    public void Show()
    {
        Console.WriteLine($"Отрезок c координатами: ({pStart}) - ({pEnd})");
    }

    public double DlinL()
    {
        return pStart.Dlina(pEnd);
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point();
        p1.Show();
        Point p2 = new Point(12, 13);
        p2.Show();
        Line line = new Line(p1, p2);
        line.Show();
        double dtr = line.DlinL();
        Console.WriteLine("Длина отрезка " + dtr);
    }
}
