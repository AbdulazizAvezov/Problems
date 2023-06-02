using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon
{
    public class K0rdinata
    {
      K0rdinata(int a,int b) 
        {
          if (a> 0 && b> 0)
            {
                Console.WriteLine(" 1 kvadrat");
            }
          else if (a< 0 &&b> 0)
            {
                Console.WriteLine("2 kvadrat");
            }
          else if(a< 0 && b < 0)
            {
                Console.WriteLine("3 kvadrat");
            }
          else if(a>0 && b<0)
            {
                Console.WriteLine("4 kvadrat");
            }
          //Kordinata masalasi bunda siz Claasdagi Consturuktormiziga  kiritasiz parametlarini (X va Y  nuqtani);
          //Programm. cs da Consturoctor yaratib olib keyin berasiz nuqtalarni;

            
        }
    }
}
