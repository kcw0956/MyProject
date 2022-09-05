using System;

namespace Lab5
{
    public static class Lab5
    {
        public static double[] Correct(uint[] usersPerDay, double[] revenuePerDay)
        {
            double[] correctRevenueperDay = new double[revenuePerDay.Length];

            for (int i = 0; i < usersPerDay.Length; i++)
            {


                if (0 <= usersPerDay[i] && usersPerDay[i] <= 10)
                {
                    correctRevenueperDay[i] = usersPerDay[i] / 2;
                }
                else if (10 < usersPerDay[i] && usersPerDay[i] <= 100)
                {
                    correctRevenueperDay[i] = 16 * usersPerDay[i] / 5 - 27;
                }
                else if (100 < usersPerDay[i] && usersPerDay[i] <= 1000)
                {
                    correctRevenueperDay[i] = usersPerDay[i] ^ 2 / 4 - 2 * usersPerDay[i] - 2007;
                }
                else if (usersPerDay[i] > 1000)
                {
                    correctRevenueperDay[i] = 245743 + usersPerDay[i] / 4;
                }

                correctRevenueperDay[i] = Math.Round(revenuePerDay[i], 2);
            }
            return correctRevenueperDay;
        }

        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            double[] correctRevenue = Correct(usersPerDay, revenuePerDay);

            if ( revenuePerDay == correctRevenue)
                
            for (int i = 0; i < revenuePerDay.Length; i++)
            {
                if (correctRevenue[i] == revenuePerDay[i] || usersPerDay.Length != revenuePerDay.Length)
                {
                    return false;
                }
            }
            return false;
        }


        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            double[] correctRevenue = Correct(usersPerDay, revenuePerDay);
            int num = 0;
            for (int i = 0; i < revenuePerDay.Length; i++)
            {

                if (correctRevenue[i] != revenuePerDay[i])
                {
                    num++;
                }
            }
            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return -1;
            }
            return num;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            double sum = 0;

            for (uint i = start; i <= end; i++)
            {
                sum += revenuePerDay[i];
            }

            if (revenuePerDay.Length == 0 || !(0 <= start && start <= revenuePerDay.Length) || !(0 <= end && end <= revenuePerDay.Length))
            {
                return -1;
            }
            return sum;
        }
    }
}