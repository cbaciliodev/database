using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitity
{
    class Acta
    {
        public int ICodigo_Acta { get; set; }
        public DateTime DFecha_Acta { get; set; }
        public string VObs_Acta { get; set; }
        public Reunion Fk_Reunion { get; set; }

        public Acta()
        {
        }

        public Acta(int iCodigo_Acta, DateTime dFecha_Acta, string vObs_Acta, Reunion fk_Reunion)
        {
            ICodigo_Acta = iCodigo_Acta;
            DFecha_Acta = dFecha_Acta;
            VObs_Acta = vObs_Acta;
            Fk_Reunion = fk_Reunion;
        }
    }
}
