namespace AlgorithmProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 0 and 1000:");
            PrintPrimeNumbers pn = new PrintPrimeNumbers();
                pn.PrintPrimeNumber(0, 1000);
        }
    }
}