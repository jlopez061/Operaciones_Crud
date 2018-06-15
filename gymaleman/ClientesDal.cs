using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace gymaleman
{
    /*class ClientesDal
    {
        public static int Agregar(Cliente pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into clientes (IDC, Nombre, ApellidoPaterno, ApellidoMaterno, Dia, Mes, Año,) values ('{0}','{1}','{2}', '{3}',{4}, '{5},'{6}')",
                pCliente.IDC, pCliente.Nombre, pCliente.ApellidoPaterno, pCliente.ApellidoPaterno, pCliente.Dia, pCliente.Mes, pCliente.Año), BD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

    }*/
}
