using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon
{
    public class TimeConverter
    {
        public static string FormatVaqt(string kiritish)
        {
            ///Masala Time Converter 
            DateTime vaqt;
            CultureInfo tekshirish = CultureInfo.InvariantCulture;
            DateTime.TryParseExact(kiritish, "hh:mm:tt", tekshirish, DateTimeStyles.None, out vaqt);
            DateTimeFormatInfo vaqtformati = CultureInfo.InvariantCulture.DateTimeFormat;
            string output = vaqt.ToString("HH:mm", vaqtformati);
            return output;
            //Kiritasiz vaqtni Manashunday  Program .cs ga otgazib  Console.Writiline(FormatVaqt("07:45 PM"))
        }

    }
}
