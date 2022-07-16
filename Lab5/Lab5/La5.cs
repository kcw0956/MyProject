using System;

namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {

            for (int i = 0; i < usersPerDay.Length; i++)
            {
                uint u = usersPerDay[i];

#pragma warning disable CS0162 // 접근할 수 없는 코드가 있습니다.
                for (int j = 0; j < revenuePerDay.Length; j++)
                {
                    double r = Math.Round(revenuePerDay[j], 2);
                    if (usersPerDay.Length != revenuePerDay.Length)
                    {
                        return false;
                    }
                    else if (0 <= u && u <= 10)
                    {
                        r = u / 2;
                        return true;
                    }
                    else if (10 < u && u <= 100)
                    {
                        r = 16 * u / 5 - 27;
                        return true;
                    }
                    else if (100 < u && u <= 1000)
                    {
                        r = u ^ 2 / 4 - 2 * u - 2007;
                        return true;
                    }
                    else if (u > 1000)
                    {
                        r = 245743 + u / 4;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
#pragma warning restore CS0162 // 접근할 수 없는 코드가 있습니다.
            }


            return false;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            for (int i = 0; i < revenuePerDay.Length; i++)
            {
                double u = revenuePerDay[i];
                if (0 <= u && u <= 10 || 10 < u && u <= 100 || 100 < u && u <= 1000 || u > 1000)
                {
                    int a = (int)revenuePerDay.Length;
                    return a;
                }
                if (usersPerDay[usersPerDay.Length] != revenuePerDay[revenuePerDay.Length])
                {
                    return -1;
                }
            }
            return -1;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
           while (start <= end)
            {
                double sum = 0;
                sum += revenuePerDay[start];
                ++start;
                return sum;
            }

            if (revenuePerDay[revenuePerDay.Length] == 0 || revenuePerDay[0] != start && revenuePerDay[revenuePerDay.Length] != end)
            {
                return -1;
            }
            return 0.0;
        }
    }
}