﻿namespace ProjectEuler;

public class Problem1_10Helper
{
    // Problem 1
    public static string Problem1(int upperBound)
    {
        int multiplesOf3 = MathHelper.SumMultiplesOfX(3,upperBound);
        int multiplesOf5 = MathHelper.SumMultiplesOfX(5,upperBound);
        int multiplesOf15 = MathHelper.SumMultiplesOfX(15,upperBound);  //need to remove one set of double-counted multiples
        return "The sum of multiples of 3 and 5 between 1 and " + upperBound + " is " + (multiplesOf3 + multiplesOf5 - multiplesOf15);
    }
}