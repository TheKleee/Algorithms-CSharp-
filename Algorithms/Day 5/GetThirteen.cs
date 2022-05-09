/*
 * Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13.
 */

using System;

//With Math methods
public class GetThirteen
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{ThirteenCheck(1)}");
        Console.WriteLine($"{ThirteenCheck(14)}");
        Console.WriteLine($"{ThirteenCheck(25)}");
        Console.WriteLine($"{ThirteenCheck(26)}");
    }
    public static bool ThirteenCheck(int x)
    {
        if (x > 1)
            return x % 13 == 0 || x % 13 == 1;
        else
            return false;
    }
}
