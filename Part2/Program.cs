/// Homework 4
/// File Name: Coin toss stats
/// @author: Dakota Durst
/// Date: september 28, 2020
///
/// Problem Statement: 
/// Ask the user to enter heads or tails 8 times. program will print out the total number of heads and tails and the percentage each one showed up
///
///
/// Overall Plan:
/// 1) get user to input h or t 8 times
/// 2) as they input value increase counter by 1 (if they enter an invalid entry decrease i by 1 to compensate
/// 3) when counter reaches 8 stop getting inputs
/// 4 )output number of heads and tails 
/// 5) calculate and output percent of each one

using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int HeadCount = 0;
            int TailCount = 0;
            string toss;
            int TOTAL_TOSS = 8;

            for (int i = 0; i < TOTAL_TOSS; i++)
            {
                Console.WriteLine("Toss number: " + i + " enter h for heads and t for tails.");
                toss = Console.ReadLine();

                if (toss == "h")
                {
                    HeadCount++;

                }
                else if (toss == "t")
                {
                    TailCount++;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    i = i - 1;
                }
            }

            double percentHeads = (((double)HeadCount / TOTAL_TOSS) * 100);
            double percentTails = (((double)TailCount / TOTAL_TOSS) * 100);

            Console.WriteLine("Number of heads: " + HeadCount);
            Console.WriteLine("Number of tails: " + TailCount);
            Console.WriteLine("Perecentage of Heads " + percentHeads + "%");
            Console.WriteLine("Percentage of Tails " + percentTails + "%");

        }
    }
}
