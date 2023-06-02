using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon
{
     public class Harajat__Calkulyatori
    {
   
        static int maxProfit(int[] price, int start, int end)
        {
            if (end <= start)
                return 0;

            int profit = 0;
            for (int i = start; i < end; i++)
            {
                for (int j = i + 1; j <= end; j++)
                {
                    if (price[j] > price[i])
                    {
                        int curr_profit
                         = price[j] - price[i]
                            + maxProfit(price, start, i - 1)
                            + maxProfit(price, j + 1, end);

                       
                        profit = Math.Max(profit, curr_profit);
                    }
                }
            }
            return profit;
        }

        //Tekshirib koring

        //Manashu tarzda shu Claasni Prgram.csga chaqirib olasiz va maxProfit metodi oraqili qiymatlarni kiritasiz
       
          /*  int[] price = { 100, 180, 260, 310, 40, 535, 695 };
            int n = price.Length;

            Console.Write(maxProfit(price, 0, n - 1));*/
      
    }
}
