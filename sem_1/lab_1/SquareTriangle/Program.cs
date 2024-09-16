class Square
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the perimeter of triangle");
        string temp = Console.ReadLine();
        double perimeter = Int32.Parse(temp);
        double a = perimeter / 3;
        string a_res = string.Format("{0:f2}", a);
        double semiperimeter = perimeter / 2;
        double square = Math.Sqrt(semiperimeter * Math.Pow(semiperimeter - a, 3));
        string sqaure_res = string.Format("{0:f2}", square);
        Console.WriteLine("{0, 3} | {1, 3}", "Side", "Square");
        Console.WriteLine("{0, 3} | {1, 3}", a_res, sqaure_res);
    }
}
