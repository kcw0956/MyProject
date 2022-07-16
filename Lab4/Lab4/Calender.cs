namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {
            if (year == 0)
            {
                return true;
            }

            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else if (year % 400 == 0)
            {
                return true;
            }
            else
                return false;
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            if (year > 9999 || !(1 <= month && month <= 12))
            {
                return -1;
            }

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if ((month == 2) && ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)))
            {
                return 29;
            }
            else if (month == 2)
            {
                return 28;
            }
            else
                return 30;
            
        }
           
        
    }
}