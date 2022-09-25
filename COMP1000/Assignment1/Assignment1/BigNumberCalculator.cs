

namespace Assignment1
{
    public class BigNumberCalculator
    {
        public BigNumberCalculator(int bitCount, EMode mode)
        {
        }

        public static string GetOnesComplementOrNull(string num)
        {

            string[] returnNum = new string[num.Length];

            if (returnNum.Length <= 2)
            {
                return null;
            }

            returnNum[0] = "0";
            returnNum[1] = "b";

            for (int i = 2; i < num.Length; i++)
            {
                if (num[i] != 0 || num[i] != 1)
                    return null;

                if (num[i] == 49)
                {
                    returnNum[i] = "0";
                }
                else
                    returnNum[i] = "1";

            }

            string newNum = string.Join("", returnNum);
    
            return newNum;
        }

        public static string GetTwosComplementOrNull(string num)
        {
            string[] returnNum = new string[num.Length];

            for (int i = 2; i < num.Length; i++)
            {
                if (num[i] == 49)
                {
                    returnNum[i] = "0";
                }
                else
                    returnNum[i] = "1";
            }

            if (returnNum[returnNum.Length] == "1")
            {
                for (int i = returnNum.Length; i > 1; i--)
                {
                    if (returnNum[i] == "0") {
                        returnNum[i] = "1";
                        break;
                    }
                    returnNum[i] = "0";
                    

                }
            }
            string newNum = string.Join("", returnNum);
            return newNum;
        }

        public static string ToBinaryOrNull(string num)
        {
            return null;
        }

        public static string ToHexOrNull(string num)
        {
            return null;
        }

        public static string ToDecimalOrNull(string num)
        {
            return null;
        }

        public string AddOrNull(string num1, string num2, out bool bOverflow)
        {
            bOverflow = false;
            return null;
        }

        public string SubtractOrNull(string num1, string num2, out bool bOverflow)
        {
            bOverflow = false;
            return null;
        }
    }
}