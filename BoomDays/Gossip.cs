using System;

namespace BoomDays
{
    public class Gossip
    {
        public const int MAX_PERSONS = 10000;
        public const int MAX_PERSONS_IN_GROUP = 20;

        private int days = 0;
        private int maxBoomSize = 0;

        private int currBoomSize = 1;

        private int totalBoomSize = 0;

        public int Days
        {
            get
            {
                return days;
            }
        }
        public int MaxBoomSize
        {
            get
            {
                return maxBoomSize;
            }
        }

        public int CurrBoomsize
        {
            get
            {
                return currBoomSize;
            }
            private set
            {
                currBoomSize = value * MAX_PERSONS_IN_GROUP;
                if ((totalBoomSize + currBoomSize) > MAX_PERSONS)
                    currBoomSize = MAX_PERSONS - totalBoomSize;
            }
        }

        public Gossip()
        {
            CalculateMaxBoomSize();
        }

        private void CalculateMaxBoomSize()
        {
            if (totalBoomSize < MAX_PERSONS)
            {
                CalculateNewBoomSize();
            }
        }

        private void StoreResults()
        {
            if (currBoomSize > maxBoomSize)
            {
                maxBoomSize = currBoomSize;
                days++;
            }
        }

        private void CalculateNewBoomSize () {
            CurrBoomsize = currBoomSize;

            StoreResults();
            totalBoomSize += currBoomSize;

            CalculateMaxBoomSize();

        }
    }
}
