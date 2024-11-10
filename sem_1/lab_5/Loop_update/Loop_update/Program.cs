using System;
class Program
{
    public static void Main()
    {
        int[] MyArray;
        int n = int.Parse(Console.ReadLine());
        MyArray = new int[n];
        for (int i = 0; i < MyArray.Length; ++i)
        {
            Console.Write("a[{0}]=", i);
            MyArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < MyArray.Length; i++)
        {
            if (MyArray[i] % 2 == 0) MyArray[i] = 0;
        }
        foreach (int x in MyArray) Console.Write("{0} ", x);
    }
}