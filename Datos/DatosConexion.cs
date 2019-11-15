using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class DatosConexion
    {

        public string ConnexionString
        {
            get
            {
                return @"Data Source=LENOVO;Initial Catalog=TALLER;Integrated Security=True";
            }
        }
        public string Source { get; set; }
        public string Database { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

        public DatosConexion()
        {
            Source = "mySourceAddress";
            Database = "myDataBase";
            UserId = "C44910167d";
            Password = "myPassword";
        }

        //Data Source=LEnovo;Initial Catalog=LABORATORIO;Integrated Security=True

        public DatosConexion(string source, string database, string userId, string password)
        {
            Source = source;
            Database = database;
            UserId = userId;
            Password = password;
        }
    }
}
