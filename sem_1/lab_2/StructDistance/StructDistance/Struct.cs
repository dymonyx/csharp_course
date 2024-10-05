using System;

public struct Distance
{
    public int ft;
    public int inch;
    // перегрузка оператора для сложения
    public static Distance operator +(Distance d1, Distance d2)
    {
        Distance result;
        result.ft = d1.ft + d2.ft;
        result.inch = d1.inch + d2.inch;

        result.ft += result.inch / 12;
        result.inch = result.inch % 12;

        return result;
    }

}
class Program
{
    public static void Main(string[] args)
    {
        Distance dist1;
        Distance dist2;
        Distance sumDist;
        Console.WriteLine("Please enter ft value and inch value for dist1");
        string line1 = Console.ReadLine();
        string[] splitString1 = line1.Split(' ');
        dist1.ft = Convert.ToInt32(splitString1[0]);
        dist1.inch = Convert.ToInt32(splitString1[1]);
        Console.WriteLine("Please enter ft value and inch value for dist2");
        string line2 = Console.ReadLine();
        string[] splitString2 = line2.Split(' ');
        dist2.ft = Convert.ToInt32(splitString2[0]);
        dist2.inch = Convert.ToInt32(splitString2[1]);
        sumDist = dist1 + dist2;
        Console.WriteLine($"dist1 = {dist1.ft}'-{dist1.inch}\"");
        Console.WriteLine($"dist2 = {dist2.ft}'-{dist2.inch}\"");
        Console.WriteLine($"sumDist = {sumDist.ft}'-{sumDist.inch}\"");
    }
}