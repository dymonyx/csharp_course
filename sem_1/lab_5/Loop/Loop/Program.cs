using System;
class Program
{
    public static void Main()
    {
        int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] % 2 == 0) myArray[i] = 0;
            Console.Write(myArray[i] + " ");
        }
    }
}
