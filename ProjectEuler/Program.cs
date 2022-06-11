// Main program to execute ProjectEuler code

using ProjectEuler;

class Program
{
    static void Main(string[] args)
    {
        // Print out result of Project Euler problem
        string answer = Problem1_10Helper.Problem2(4000000);
        Console.WriteLine(answer);
    }
}