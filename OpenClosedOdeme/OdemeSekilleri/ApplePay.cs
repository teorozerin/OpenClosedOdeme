using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedOdeme.OdemeSekilleri
{
    public class ApplePay : IOdeme
    {
        public void OdemeSekli(decimal tutar)
        {
            Console.WriteLine(tutar + "Tl Ödeme yapıldı");
        }
    }
}
