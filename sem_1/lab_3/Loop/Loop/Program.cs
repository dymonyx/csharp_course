﻿using System;

class Program
{
    public static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("\nwhile: \t\t");
        int i = 1;
        while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }
        Console.Write("\ndo while: \t");
        i = 1;
        do
            {
                Console.Write(" " + i);
                i += 2;
            }
        while (i <= n);
        Console.Write("\nFor: \t\t");
        for (i = 1; i<=n; i+=2)
            {
                Console.Write(" " + i);
            }
        Console.WriteLine();
    }
}
