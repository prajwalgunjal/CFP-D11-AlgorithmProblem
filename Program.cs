namespace AlgorithmProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 0 and 1000:");
            PrintPrimeNumbers pn = new PrintPrimeNumbers();
                pn.PrintPrimeNumber(0, 1000);



            /// anagram detection
            AnagramDetection anagramDetection = new AnagramDetection();
            string str1 = "listen";
            string str2 = "silent";


            if (anagramDetection.AreAnagrams(str1, str2))
            {
                Console.WriteLine("The two strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The two strings are not anagrams.");
            }
        }
    }
    }
}