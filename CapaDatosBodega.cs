using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace Bodega
{
    class CapaDatosBodega
    {
        public static OdbcConnection cnx = new OdbcConnection(Properties.Settings.Default.ruta);
        public OdbcConnection con1;


        public CapaDatosBodega()
        {
            string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
            con1 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
        }


        public static string producto = "select * from Producto where estado=1";
        public static string producto2 = "select * from Producto where estado=0";
        public static string encargado = "select * from trabajador";
        public static string propietario = "select * from distribuidores";
        public static string bodega = "select * from Bodega";
        public static string pedido = "select * from DetalleInventario";
        public static string prestador = "select * from prestador";
        public static string perfil = "select * from perfil";
        public static string usuario = "select * from usuario";
        public static string usuario2 = "select * from usuario where estado=1";

        public static DataTable llenarProductoInactivo()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(producto2, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarUsuarioActivo()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(usuario2, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarUsuario()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(usuario, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarPerfil()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(perfil, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarproducto()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(producto, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarTrabajador()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(encargado, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarPropietario()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(propietario, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarBodega()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(bodega, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }


        public static DataTable llenarInventario()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(pedido, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarPrestador()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(prestador, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }

    class USER :CapaDatosBodega
    {        
        

        public string log_username { set; get; }
        public string log_password { set; get; }
        public string log_role { set; get; }
        
        public bool user_verification()
        {            
            //OdbcCommand command = new OdbcCommand("SELECT * FROM `usuario` where Nombre=@user AND contraseña=@pass", con1);
            con1.Open();
            OdbcDataReader rd;
            bool check = false;
            using (OdbcCommand cmd = new OdbcCommand())
            {
                
                cmd.CommandText = "SELECT * FROM usuario where Nombre='" + log_username + "' AND contraseña='" + log_password + "' and estado=1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con1;

                //cmd.Parameters.Add("@user", OdbcType.VarChar).Value = log_username;
                //cmd.Parameters.Add("@pass", OdbcType.VarChar).Value = log_password;
                cmd.Parameters.AddWithValue("@user", log_username);
                cmd.Parameters.AddWithValue("@pass", log_password);
                
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    log_role= "Perfil";
                    
                }
                con1.Close();
            }
            return check;

        }
    }
}
