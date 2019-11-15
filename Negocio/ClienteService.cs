using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Negocios
{
    public class ClienteService
    {
        private readonly ClienteRepository repository = null;

        public ClienteService()
        {
            repository = new ClienteRepository();
        }

        public Cliente GetCliente()
        {
            return repository.GetClientes();
        }

        public Cliente GetClienteById(int codigo)
        {

            return repository.GetClienteById(codigo); 
        }
    }
}
