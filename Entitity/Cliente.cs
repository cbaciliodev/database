using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Cliente(int codigo, string nombre, string ciudad, string direccion, string telefono)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        public Cliente()
        {
        }
    }
}
