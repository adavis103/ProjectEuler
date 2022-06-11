namespace ProjectEuler;

public class MathHelper
{
    public static int SumMultiplesOfX(int x, int upperBound)
    {
        if (x > upperBound) return 0;

        //multiples must be strictly less than upper bound
        upperBound -= 1;
        
        // Use a summation to avoid looping
        int quotient = upperBound / x;
        return x * (quotient * (quotient + 1)) / 2;
    }
}