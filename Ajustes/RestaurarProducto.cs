using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Bodega.Ajustes
{
    public partial class RestaurarProducto : Form
    {
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";

        public RestaurarProducto()
        {
            InitializeComponent();
            cmb_Producto.DataSource = CapaDatosBodega.llenarProductoInactivo();
            cmb_Producto.ValueMember = "name";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea restaurar el producto '" + cmb_Producto.Text.ToString() + "'", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Yes)
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                    OdbcCommand cmd1 = new OdbcCommand("update producto set estado=1 where name='" + cmb_Producto.Text.ToString() + "'", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    MessageBox.Show("Se restauro el producto '"+cmb_Producto.Text.ToString()+"'", "Usuario creado", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
