namespace TurtleAndHare
{
    internal class Challenges
    {
        public static int TortoiseAndHare()
        {
            //int[] numberList = { 1, 2, 4, 2, 9 };
            int[] numberList = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 };
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
