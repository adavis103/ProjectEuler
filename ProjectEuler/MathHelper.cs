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

    public static long LargestPrimeFactor(long n)
    {
        for (int i = 2; i < n; i++)
        {
            while (n % i == 0)
            {
                n /= i;
            }
        }

        return n;
    }
    public static int MaxPalindrome(int digits)
    {
        int upperBound = (int)Math.Pow(10,digits);
        int lowerBound = (int)Math.Pow(10,digits-1);
        int maxProduct = 0;

        for (int i = upperBound - 1;  i >= lowerBound; i--)
        {
            // Break if all further numbers will be less than current max palindrome
            if (i * i < maxProduct)
            {
                break;
            }

            for (int j = i; j >= lowerBound; j--)
            {
                int product = i*j;

                if (IsPalindrome(product) && product > maxProduct) 
                {
                    maxProduct = product;
                }
            }
        }

        return maxProduct;
    }

    public static bool IsPalindrome(int n)
    {
        string number = Convert.ToString(n);
        bool result = true;

        // Compare every number except middle (if odd # of digits)
        for (int i = 0; i < number.Length / 2; i++)
        {
            if (number[i] != number[number.Length-i-1]) 
            {
                result = false;
                break; 
            }
        }

        return result;
    }
}