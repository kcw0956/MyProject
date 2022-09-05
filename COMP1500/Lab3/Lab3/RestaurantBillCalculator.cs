using System;
using System.IO;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        {

            double menu1 = double.Parse(input.ReadLine());

            double menu2 = double.Parse(input.ReadLine());

            double menu3 = double.Parse(input.ReadLine());

            double menu4 = double.Parse(input.ReadLine());

            double menu5 = double.Parse(input.ReadLine());

            double tipInput = double.Parse(input.ReadLine());
                      

            double sum = menu1 + menu2 + menu3 + menu4 + menu5;
            double tex = Math.Round(sum * 0.05, 3);
            double tip = (sum + tex) * (tipInput / 100);
            double pay = Math.Round(sum + tex + tip, 2);


            Console.WriteLine("음식");
            Console.WriteLine($"1. 첫번째 음식 가격 = {menu1}");
            Console.WriteLine($"2. 두번째 음식 가격 = {menu2}");
            Console.WriteLine($"3. 세번째 음식 가격 = {menu3}");
            Console.WriteLine($"4. 네번째 음식 가격 = {menu4}");
            Console.WriteLine($"5. 다섯번째 음식 가격 = {menu5}\n");
            Console.WriteLine($"팁 퍼센트 = {tipInput}\n");
            Console.WriteLine($"소계 = {menu1} + {menu2} + {menu3} + {menu4} + {menu5} = {sum}");
            Console.WriteLine($"세금 = ({sum}) * 0.05 = {tex} ");
            Console.WriteLine($"팁 = ({sum} + {tex}) * {tipInput} / 100 = {tip}");
            Console.WriteLine($"총 가격 = {sum} + {tex} + {tip} = {pay:f2}\n");
            return pay;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            double peopleNum = double.Parse(input.ReadLine());
            double pay = Math.Round(totalCost / peopleNum, 2); 
            Console.WriteLine($"입력받을 사람 수: {peopleNum}");
            Console.WriteLine($"한 사람당 내야 할 금액: {pay}");
            return pay;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            double payment = double.Parse(input.ReadLine());
            Console.WriteLine(totalCost);
            uint payPeople = (uint)Math.Ceiling(totalCost / payment);
            
            Console.WriteLine(String.Format("지불 해야 할 손님 수: {0}", payPeople));

            return payPeople;
        }
    }
}