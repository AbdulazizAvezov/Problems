using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon
{
    public class Kunlar_soni
    {
        // kunlar soni
       public  int Kun(int yil,int oy)
        {
           int kunlar=DateTime.DaysInMonth(yil,oy);
            return kunlar;
        }
        // misol
        // int yil=2005
        // int oy=02;
        //Console.Writile("Kunlar soni oyda("+yil+"/"+oy +'"+Kun(yil,oy));
        //Program.cs da shunday tekshirib korishingiz mumkun
    }
}
