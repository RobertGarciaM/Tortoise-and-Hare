using System;

namespace TurtleAndHare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result: ");
            Console.WriteLine(TortoiseAndHare());
            Console.ReadKey();
        }

        // TIME: O(N)
        // Space complexity: O(1)
        public static int TortoiseAndHare()
        {
            //int[] numberList = { 1, 2, 4, 2, 9 };
            int[] numberList = { 1, 3, 4, 2, 2};
            //int[] numberList = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 };
            int tortoise = numberList[0];
            int hare = numberList[0];

            while (true)
            {
                tortoise = numberList[tortoise];
                hare = numberList[numberList[hare]];

                if (tortoise == hare)
                {
                    break;
                }
            }

            tortoise = numberList[0];

            while (hare != tortoise)
            {
                hare = numberList[hare];
                tortoise = numberList[tortoise];
            }

            return hare;
        }
    }
}
