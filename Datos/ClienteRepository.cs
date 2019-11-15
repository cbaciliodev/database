using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Data
{
    public class ClienteRepository
    {
        private readonly SqlConnection connection;
        private readonly Cliente cliente = new Cliente();
        private readonly DatosConexion datosConexion = new DatosConexion();
        private readonly SqlCommand cmd = new SqlCommand();

        public ClienteRepository()
        {
            connection = new SqlConnection(datosConexion.ConnexionString);
        }

        public Cliente GetClientes()
        {
            Cliente cliente = new Cliente(
                1, "David", "Lima", "Villa el Salvador", "7865245");
            return cliente;
        }

        public Cliente GetClienteById(int codigo)
        {

            try
            {
                SqlDataReader dtr;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CLIENTE_CODIGO";
                cmd.Parameters.Add(new SqlParameter("@CODIGO", SqlDbType.Int));
                cmd.Parameters["@CODIGO"].Value = codigo;

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    cliente.Codigo = Convert.ToInt32(dtr[0]);
                    cliente.Nombre = dtr[1].ToString();
                    cliente.Ciudad = dtr[2].ToString();
                    cliente.Direccion = dtr[3].ToString();
                    cliente.Telefono = dtr[4].ToString();


                }
                connection.Close();
                cmd.Parameters.Clear();
                return cliente;
            }
            catch (Exception)
            {

                throw new Exception();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                cmd.Parameters.Clear();
            }
        }

    }
}
//http://sistemasddm.blogspot.com/2014/02/crud-de-clientes-en-capas-aspnet-sql.html