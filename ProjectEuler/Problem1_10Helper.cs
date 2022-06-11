namespace ProjectEuler;

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

    // Problem 2
    public static string Problem2(int upperBound)
    {
        int sum = MathHelper.SumEvenFibonacci(upperBound);
        return "The sum of the even-valued Fibonacci sequence terms below " + upperBound + " is " + sum;
    }

    // Problem 3
    public static string Problem3(long n)
    {
        long prime = MathHelper.LargestPrimeFactor(n);
        return "The largest prime factor of " + n + " is " + prime;
    }
}