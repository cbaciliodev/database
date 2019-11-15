using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitity
{
    class Docente
    {
        public int ICodigo_Doc { get; set; }
        public string VNombre_Doc { get; set; }
        public string VApaterno_Doc { get; set; }
        public string VAmaterno_Doc { get; set; }
        internal Cargo FK_cargo { get; set; }

        public Docente()
        {
        }

        public Docente(int iCodigo_Doc, string vNombre_Doc, string vApaterno_Doc, string vAmaterno_Doc, Cargo fK_cargo)
        {
            ICodigo_Doc = iCodigo_Doc;
            VNombre_Doc = vNombre_Doc;
            VApaterno_Doc = vApaterno_Doc;
            VAmaterno_Doc = vAmaterno_Doc;
            FK_cargo = fK_cargo;
        }
    }
}
