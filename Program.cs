using System;

namespace GoCards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine();
            
                if (i % 4 == 0 & i % 7 == 0)
                {
                    Console.Write("Go Cards");
                
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Cards");
                }
                else if (i % 4 == 0)
                {
                    Console.Write("Go");
                }
                else
                Console.WriteLine(i);
            }
            
            {
                Console.ReadLine();
            }
        }
    }
}