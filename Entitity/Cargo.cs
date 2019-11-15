using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitity
{
    public class Cargo
    {
        public int ICodigo_Cargo { get; set; }
        public string VConcepto_Cargo { get; set; }
        public Cargo()
        {
        }

        public Cargo(int iCodigo_Cargo, string vConcepto_Cargo)
        {
            ICodigo_Cargo = iCodigo_Cargo;
            VConcepto_Cargo = vConcepto_Cargo;
        }

    }
}
