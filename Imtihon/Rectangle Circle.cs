using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon
{
    public class Rectangle_Circle
    {
      
        public static bool isPossible(int m, int n, int k, int r, int[] X, int[] Y)
        {

            int[,] rect = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rect[i, j] = 0;
                }
            }

          
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int p = 0; p < k; p++)
                    {
                        if (Math.Sqrt((Math.Pow((X[p] - 1 - i), 2) + Math.Pow((Y[p] - 1 - j), 2))) <= r)
                        {
                            rect[i, j] = -1;
                        }
                    }
                }
            }

           
            if (rect[0, 0] == -1)
                return false;

            
            Queue<KeyValuePair<int, int>> qu = new Queue<KeyValuePair<int, int>>();
            rect[0, 0] = 1;
            qu.Enqueue(new KeyValuePair<int, int>(0, 0));

          
            while (qu.Count > 0)
            {

                var arr = qu.Dequeue();
                int elex = arr.Key;
                int eley = arr.Value;

               
                if ((elex > 0) && (eley > 0) && (rect[elex - 1, eley - 1] == 0))
                {
                    rect[elex - 1, eley - 1] = 1;
                    qu.Enqueue(new KeyValuePair<int, int>(elex - 1, eley - 1));
                }

          
                if ((elex > 0) && (rect[elex - 1, eley] == 0))
                {
                    rect[elex - 1, eley] = 1;
                    qu.Enqueue(new KeyValuePair<int, int>(elex - 1, eley));
                }

                
                if ((elex > 0) && (eley < n - 1) && (rect[elex - 1, eley + 1] == 0))
                {
                    rect[elex - 1, eley + 1] = 1;
                    qu.Enqueue(new KeyValuePair<int, int>(elex - 1, eley + 1));
                }

               
                if ((eley > 0) && (rect[elex, eley - 1] == 0))
                {
                    rect[elex, eley - 1] = 1;
                    qu.Enqueue(new KeyValuePair<int, int>(elex, eley - 1));
                }

               
                if ((eley < n - 1) && (rect[elex, eley + 1] == 0))
                {
                    rect[elex, eley + 1] = 1;
                    qu.Enqueue(new KeyValuePair<int, int>(elex, eley + 1));
                }

               
                if ((elex < m - 1) && (eley > 0) && (rect[elex + 1, eley - 1] == 0))
                {
                    rect[elex + 1, eley - 1] = 1;
                    qu.Enqueue(new KeyValuePair<int, int>(elex + 1, eley - 1));
                }

               
                if ((elex < m - 1) && (rect[elex + 1, eley] == 0))
                {
                    rect[elex + 1, eley] = 1;
                    qu.Enqueue(new KeyValuePair<int, int>(elex + 1, eley));
                }

               
                if ((elex < m - 1) && (eley < n - 1) && (rect[elex + 1, eley + 1] == 0))
                {
                    rect[elex + 1, eley + 1] = 1;
                    qu.Enqueue(new KeyValuePair<int, int>(elex + 1, eley + 1));
                }
            }

           
            return (rect[m - 1, n - 1] == 1);
        }

        /* manshu holda tekshirib korasiz
         * int m1 = 5, n1 = 5, k1 = 2, r1 = 1;
        int[] X1 = { 1, 3 };
        int[] Y1 = { 3, 3 };

            
            if (isPossible(m1, n1, k1, r1, X1, Y1))
                Console.WriteLine("Mumkun");
            else
                Console.WriteLine("Mumkun emas");*/

           

      
    }

    
}

