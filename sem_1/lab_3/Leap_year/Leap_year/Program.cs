using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the year: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool flag = false;
        string msg = "";
        if (number % 400 == 0)
            flag = true;
        else if (number % 4 == 0)
        {
            if (number % 100 != 0)
                flag = true;
        }
        if (flag)
            msg = "Yes";
        else
            msg = "No";
        Console.WriteLine(msg);

    }
}