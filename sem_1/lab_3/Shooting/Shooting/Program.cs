using System;
class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        double x_center = Convert.ToDouble(rnd.Next(0, 4));
        double y_center = Convert.ToDouble(rnd.Next(0, 4));
        int total_score = 0;
        int attempt = 0;
        while (attempt <= 5)
        {
            double x_obstacle = rnd.NextSingle();
            double y_obstacle = rnd.NextSingle();
            Console.Write("Please enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double real_x = x - x_center + x_obstacle;
            double real_y = y - y_center - y_obstacle;
            if (real_x*real_x + real_y*real_y <= 1.00) total_score += 10;
            else if (real_x*real_x + real_y*real_y <= 2.00) total_score += 5;
            else if (real_x*real_x + real_y*real_y <= 3.00) total_score += 1;
            Console.WriteLine("Score is " + total_score);
            attempt += 1;
        }
        Console.WriteLine("Game is over. Total score is " + total_score);

    }
}