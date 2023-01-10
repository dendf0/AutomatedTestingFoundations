using System;

namespace MaxDiffChars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine("Write string:");
                string input = Console.ReadLine();
                Console.WriteLine("Maximum consecutive different chars = " + MaxDiffChars.MaximumDifferentCharacters(input));
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }
                Console.WriteLine();
            }
        }
    }
}