using System;

namespace NewBase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine("Write number:");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write new base (2-20):");
                int nBase = Convert.ToInt32(Console.ReadLine());
                if(nBase < 2 || nBase > 20)
                {
                    Console.WriteLine("Wrong new base!");
                    continue;
                }
                Console.WriteLine("Your number in new base: " + NewBase.SetNewBase(input,nBase));
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