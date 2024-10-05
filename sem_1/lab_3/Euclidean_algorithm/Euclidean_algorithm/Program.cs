using System;
class Program
{
    public static void Main()
    {
        int a, b, temp;
        Console.Write("Enter a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        b = int.Parse(Console.ReadLine());
        temp = a;
        while (temp != b)
        {
            a = temp;
            if (a<b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            temp = a - b;
            a = b;
        }
        Console.WriteLine("GCD is " + a);
    }
}