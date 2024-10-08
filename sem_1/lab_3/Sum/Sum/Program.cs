using System;
class Program
{
    public static void Main()
    {
        int k, m, sum = 0;
        Console.Write("Enter k: ");
        k = int.Parse(Console.ReadLine());
        Console.Write("Enter m: ");
        m = int.Parse(Console.ReadLine());
        for (int i = 1; i<=100; i++)
        {
            if (i > k && i < m) continue;
            sum +=i ;
        }
        Console.WriteLine(sum);
    }
}
