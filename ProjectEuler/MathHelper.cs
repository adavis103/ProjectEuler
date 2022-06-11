namespace ProjectEuler;

public class MathHelper
{
    public static int SumMultiplesOfX(int x, int upperBound)
    {
        if (x > upperBound) return 0;

        // Multiples must be strictly less than upper bound
        upperBound -= 1;
        
        // Use a summation to avoid looping
        int quotient = upperBound / x;
        return x * (quotient * (quotient + 1)) / 2;
    }

    public static int SumEvenFibonacci(int upperBound)
    {
        int sum = 0;
        int prev2 = 0;
        int prev = 1;

        for (int i = 2; i < upperBound; i += prev2)
        {
            // Sum only even numbers in Fibonacci sequence
            if (i % 2 == 0) 
            {
                sum += i;
            }
            
            prev2 = prev;
            prev = i;
        }
        
        return sum;
    }
}