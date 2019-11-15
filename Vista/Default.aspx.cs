using Entitity;
using Model;
using Negocios;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Vista
{


    public partial class Default : Page
    {
        CargoService service = new CargoService();
        Cargo objCargo = new Cargo();

        protected void Page_Load(object sender, EventArgs e)
        {
            int _codigo = 1;
            objCargo = service.GetCargoById(_codigo);

            codigo.Text = objCargo.ICodigo_Cargo + "";
            nombre.Text = objCargo.VConcepto_Cargo;
            cuidad.Text = objCargo.VConcepto_Cargo;
            direccion.Text = objCargo.VConcepto_Cargo;
            telefono.Text = objCargo.VConcepto_Cargo;         
        }
    }
}