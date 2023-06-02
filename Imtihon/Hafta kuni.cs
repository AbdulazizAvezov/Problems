using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon
{
    public class Hafta_kuni
    {
        public string Print(int haftaraqami)
        {
            switch (haftaraqami)
            {
                case 1:
                    Console.WriteLine("Dushanbe");
                        break;
                    case 2:
                    Console.WriteLine("Seshanbe");
                    break;
                    case 3:
                    Console.WriteLine("Chorshanbe");
                    break;
                    case 4:
                    Console.WriteLine("Payshanbe");
                    break;
                    case 5:
                    Console.WriteLine("Juma");
                    break;
                    case 6:
                    Console.WriteLine("Shanbe");
                    break;
                    case 7:
                    Console.WriteLine("Yakshanbe");
                    break;
                default:
                    Console.WriteLine("Hafta raqmini togri kiting");
                    break;
            }
            return haftaraqami.ToString();
            //Hafta kuni shu metodni chaqirasiz va unga raqm berasiz Consolega chiqarib beradi
            //Hafta_kuni hafta_Kuni = new Hafta_kuni();
            //hafta_Kuni.Print(1);Dushanbe chiqadi


        }
    }
}
