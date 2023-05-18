using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Template_Design_Pattern
{
    public class Mause : Alisveris
    {
        public override void OdemeSekliDegis()
        {
            OdemeSekli = "Peşin";
        }

        public override void FiyatDegis()
        {
            Fiyat = 10;
        }
    }

    public class Televizyon : Alisveris
    {
        public override void OdemeSekliDegis()
        {
            OdemeSekli = "Taksit";
        }

        public override void FiyatDegis()
        {
            Fiyat = 1000;
        }
    }
}
