class Program
{
    public static void Main()
    {
        Console.Write("Enter the size of array: ");
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');
        int num1 = Convert.ToInt32(splitString[0]);
        int num2 = Convert.ToInt32(splitString[1]);
        int[,] a = new int[num1, num2];
        Input(a, num1, num2);
        Console.WriteLine("sum = {0}", Sum(a));
        Console.WriteLine("average = {0}", Average(a));
        int negative_sum = 0, positive_sum = 0;
        PositiveNegativeSum(a, ref negative_sum, ref positive_sum);
        Console.WriteLine("positive sum = {0}, negative sum = {1}", positive_sum, negative_sum);
        int even_sum = 0; int odd_sum = 0;
        EvenOddSum(a, ref even_sum, ref odd_sum);
        Console.WriteLine("even sum = {0}, odd sum = {1}", even_sum, odd_sum);
        int max = int.MinValue; int min = int.MaxValue; int r_min = 0; int c_min = 0; int r_max = 0; int c_max = 0;
        Min(a, ref min, ref r_min, ref c_min); Max(a, ref max, ref r_max, ref c_max);
        Console.WriteLine("min = {0} a[{1}, {2}], max = {3} a[{4}, {5}]", min, r_min, c_min, max, r_max, c_max);
        Console.WriteLine("multiply = {0}", Multiply(a, r_min, c_min, r_max, c_max));


    }
    public static void Input(int[,] a, int num1, int num2)
    {
        for (int r = 0; r < num1; ++r)
        {
            for (int c = 0; c < num2; ++c)
            {
                Console.Write("a[{0},{1}] = ", r, c);
                a[r, c] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public static int Sum(int[,] a)
    {
        int sum = 0;
        foreach (int i in a) sum += i;
        return sum;
    }

    public static double Average(int[,] a)
    {
        int sum = Sum(a);
        double average = Convert.ToDouble(sum) / Convert.ToDouble(a.Length);
        return average;
    }
    public static void PositiveNegativeSum(int[,] a, ref int negative_sum, ref int positive_sum)
    {
        foreach (int i in a)
        {
            if (i < 0) negative_sum += i;
            else positive_sum += i;
        }
    }

    public static void EvenOddSum(int[,] a, ref int even_sum, ref int odd_sum)
    {
        for (int r = 0; r < a.GetLength(0); ++r)
        {
            for (int c = 0; c < a.GetLength(1); ++c)
            {
                if ((r + c) % 2 == 0) even_sum += a[r, c];
                else odd_sum += a[r, c];
            }
        }
    }

    public static void Min(int[,] a, ref int min, ref int r_min, ref int c_min)
    {
        for (int r = 0; r < a.GetLength(0); ++r)
        {
            for (int c = 0; c < a.GetLength(1); ++c)
            {
                if (a[r, c] < min)
                {
                    min = a[r, c];
                    r_min = r;
                    c_min = c;
                }
            }
        }


    }

    public static void Max(int[,] a, ref int max, ref int r_max, ref int c_max)
    {
        for (int r = 0; r < a.GetLength(0); ++r)
        {
            for (int c = 0; c < a.GetLength(1); ++c)
            {
                if (a[r, c] > max)
                {
                    max = a[r, c];
                    r_max = r;
                    c_max = c;
                }
            }
        }
    }
    public static int Multiply(int[,] a, int r_min, int c_min, int r_max, int c_max)
    {
        int res = 1;

        // Представляем двумерный массив как одномерный
        int minIndex = r_min * a.GetLength(1) + c_min;
        int maxIndex = r_max * a.GetLength(1) + c_max;


        int startIndex = Math.Min(minIndex, maxIndex);
        int endIndex = Math.Max(minIndex, maxIndex);

        for (int i = startIndex + 1; i < endIndex; ++i)
        {
            int r = i / a.GetLength(1); 
            int c = i % a.GetLength(1); 
            res *= a[r, c];
        }

        return res;
    }
}

