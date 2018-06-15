using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace gymaleman.DAD
{
    class MostrarDatos : BD
    {
        string instruccion,a,  b, c, d, e , f;
        
        public DataTable vistaTabla()
        {
            instruccion = "Select * from Clientes";

            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, ObtenerConexion());

            DataTable consulta = new DataTable();
            adp.Fill(consulta);


            return consulta;

           
        }
      
        public DataTable vistaTabla1()
        {

          
                a = "Select * from Productos";
                MySqlDataAdapter adp = new MySqlDataAdapter(a, ObtenerConexion());
                DataTable consulta1 = new DataTable();
                adp.Fill(consulta1);
                return consulta1;
            

        }
        public DataTable vistaTabla2()
        {


            b = "Select * from Ventas";
            MySqlDataAdapter adp = new MySqlDataAdapter(b, ObtenerConexion());
            DataTable consulta1 = new DataTable();
            adp.Fill(consulta1);
            return consulta1;


        }




        public DataTable vistaTabla3()
        {


            c = "Select * from Compras";
            MySqlDataAdapter adp = new MySqlDataAdapter(c, ObtenerConexion());
            DataTable consulta1 = new DataTable();
            adp.Fill(consulta1);
            return consulta1;


        }

        public DataTable vistaTabla4()
        {


            d = "Select * from Servicio";
            MySqlDataAdapter adp = new MySqlDataAdapter(d, ObtenerConexion());
            DataTable consulta1 = new DataTable();
            adp.Fill(consulta1);
            return consulta1;


        }

        public DataTable vistaTabla5()
        {


            e = "Select * from Inventario";
            MySqlDataAdapter adp = new MySqlDataAdapter(e, ObtenerConexion());
            DataTable consulta1 = new DataTable();
            adp.Fill(consulta1);
            return consulta1;


        }
        public DataTable vistaTabla6()
        {


            f = "Select * from Provedores";
            MySqlDataAdapter adp = new MySqlDataAdapter(f, ObtenerConexion());
            DataTable consulta1 = new DataTable();
            adp.Fill(consulta1);
            return consulta1;


        }
    }
}
