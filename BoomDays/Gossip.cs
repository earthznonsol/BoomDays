using System;

namespace BoomDays
{
    public class Gossip
    {
        public const int MAX_PERSONS = 10000;
        public const int MAX_PERSONS_IN_GROUP = 20;

        private int startTotalPeople;

        private int days;
        private int maxBoomSize;

        private int currBoomSize;
        private int currBoomSizeDay;
        
        private int totalBoomSize;

        public int Days
        {
            get
            {
                return days;
            }
        }
        public int MaxBoomSize {
            get
            {
                return maxBoomSize;
            }
        }

        public Gossip(int startTotalPeople)
        {
            this.startTotalPeople = startTotalPeople;
            days = 0;
            maxBoomSize = 0;
            currBoomSize = 0;
            currBoomSizeDay = 0;
            totalBoomSize = 0;
        }

        public void CalculateBoomSize()
        {
            CalculateMaxBoomSize(startTotalPeople);
        }

        private void CalculateMaxBoomSize(int totalPeople)
        {
            if (totalBoomSize < MAX_PERSONS)
            {
                
                currBoomSize = GetBoomSize(totalPeople);
                totalBoomSize += currBoomSize;
                currBoomSizeDay++;
                if (currBoomSize > maxBoomSize)
                {
                    maxBoomSize = currBoomSize;
                    days = currBoomSizeDay;
                }
                CalculateMaxBoomSize(maxBoomSize);
            }
        }

        private int GetBoomSize(int totalPeople)
        {
            int bs = totalPeople * MAX_PERSONS_IN_GROUP;
            if ((totalBoomSize + bs) > MAX_PERSONS)
                bs = MAX_PERSONS - totalBoomSize;

            return bs;
        }
    }
}
