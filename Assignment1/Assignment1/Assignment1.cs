using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    public static class Assignment1
    {
        public static void PrintIntegers(StreamReader input, StreamWriter output, int width)
        {
            if (width <= 9)
            {
                width = 10;
            }

            string num1 = input.ReadLine();

            num1 = num1.Trim();

            string num2 = input.ReadLine();

            num2 = num2.Trim(); 

            string num3 = input.ReadLine();

            num3 = num3.Trim(); 

            string num4 = input.ReadLine();

            num4 = num4.Trim();

            string num5 = input.ReadLine();

            num5 = num5.Trim();


            string num1Left = num1.PadLeft(width);

            string num2Left = num2.PadLeft(width);

            string num3Left = num3.PadLeft(width);

            string num4Left = num4.PadLeft(width);

            string num5Left = num5.PadLeft(width);

            string octLeft = "oct".PadLeft(width);

            string decLeft = "dec".PadLeft(width);

            string hexLeft = "hex".PadLeft(width);

            long num1Long = long.Parse(num1);
            long num2Long = long.Parse(num2);
            long num3Long = long.Parse(num3);
            long num4Long = long.Parse(num4);
            long num5Long = long.Parse(num5);


            string num1To16 = num1Long.ToString("X");

            string num2To16 = num2Long.ToString("X");

            string num3To16 = num3Long.ToString("X");

            string num4To16 = num4Long.ToString("X");

            string num5To16 = num5Long.ToString("X");


            string num1T16Left = num1To16.PadLeft(width);

            string num2T16Left = num2To16.PadLeft(width);

            string num3T16Left = num3To16.PadLeft(width);

            string num4T16Left = num4To16.PadLeft(width);

            string num5T16Left = num5To16.PadLeft(width);


            string num1To8 = Convert.ToString(long.Parse(num1), 8);

            string num2To8 = Convert.ToString(long.Parse(num2), 8);

            string num3To8 = Convert.ToString(long.Parse(num3), 8);

            string num4To8 = Convert.ToString(long.Parse(num4), 8);

            string num5To8 = Convert.ToString(long.Parse(num5), 8);


            string num1TO8Left = num1To8.PadLeft(width);

            string num2TO8Left = num2To8.PadLeft(width);

            string num3TO8Left = num3To8.PadLeft(width);

            string num4TO8Left = num4To8.PadLeft(width);

            string num5TO8Left = num5To8.PadLeft(width);



            output.WriteLine($"{octLeft} {decLeft} {hexLeft}");

            output.WriteLine($"{num1TO8Left} {num1Left} {num1T16Left}");

            output.WriteLine($"{num2TO8Left} {num2Left} {num2T16Left}");

            output.WriteLine($"{num3TO8Left} {num3Left} {num3T16Left}");

            output.WriteLine($"{num4TO8Left} {num4Left} {num4T16Left}");

            output.Write($"{num5TO8Left} {num5Left} {num5T16Left}\n");

        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            double num1 = double.Parse(input.ReadLine());

            double num2 = double.Parse(input.ReadLine());

            double num3 = double.Parse(input.ReadLine());

            double num4 = double.Parse(input.ReadLine());

            double num5 = double.Parse(input.ReadLine());

            string num1F3 = string.Format("{0:f3}", num1);

            string num2F3 = string.Format("{0:f3}", num2);

            string num3F3 = string.Format("{0:f3}", num3);

            string num4F3 = string.Format("{0:f3}", num4);

            string num5F3 = string.Format("{0:f3}", num5);



            double sum = num1 + num2 + num3 + num4 + num5;

            double avg = (num1 + num2 + num3 + num4 + num5) / 5;

            double[] array = { num1, num2, num3, num4, num5 };

            double min = array[0];

            double max = -9999999999999;

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }

                if (max < array[i])
                {
                    max = array[i];
                }
            }




            string minF3 = String.Format("{0:f3}", min);

            string maxF3 = String.Format("{0:f3}", max);

            string sumF3 = String.Format("{0:f3}", sum);

            string avgF3 = String.Format("{0:f3}", avg);


            output.WriteLine("{0,25}", num1F3);

            output.WriteLine("{0,25}", num2F3);

            output.WriteLine("{0,25}", num3F3);

            output.WriteLine("{0,25}", num4F3);

            output.WriteLine("{0,25}", num5F3);

            output.WriteLine("{0}{1,22}", "Min", minF3);

            output.WriteLine("{0}{1,22}", "Max", maxF3);

            output.WriteLine("{0}{1,22}", "Sum", sumF3);

            output.WriteLine("{0}{1,18}", "Average", avgF3);


        }
    }
}