using Model;
using Negocios;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Vista
{


    public partial class Default : Page
    {
        ClienteService service = new ClienteService();
        Cliente cliente = new Cliente();

        protected void Page_Load(object sender, EventArgs e)
        {

            int _codigo = 1; 
            cliente = service.GetClienteById(_codigo);

            codigo.Text = cliente.Codigo + "";
            nombre.Text = cliente.Nombre;
            cuidad.Text = cliente.Ciudad;
            direccion.Text = cliente.Direccion;
            telefono.Text = cliente.Telefono;
            
        }
    }
}