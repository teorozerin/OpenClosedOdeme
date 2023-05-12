using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedOdeme.OdemeSekilleri
{
    public class Odeme
    {
        private readonly IOdeme _ıodeme;
        public Odeme(IOdeme ıodeme)
        {
            _ıodeme = ıodeme;
        }
        public void OdemeSekli(decimal tutar)
        {
            _ıodeme.OdemeSekli(tutar);
        }
    }
}
