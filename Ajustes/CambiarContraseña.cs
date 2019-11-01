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
    public partial class CambiarContraseña : Form
    {
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        public CambiarContraseña()
        {
            InitializeComponent();
            cmb_usuario.DataSource = CapaDatosBodega.llenarUsuario();
            cmb_usuario.ValueMember = "Nombre";
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if(txt_contraseña.Text=="")
                MessageBox.Show("Llenar el campo de contraseña", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else { 
            try
            {
                OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                OdbcCommand cmd1 = new OdbcCommand("update usuario set contraseña='" + txt_contraseña.Text+"' where nombre='" + cmb_usuario.Text.ToString() + "'", con);
                con.Open();//abre la conexion 
                cmd1.ExecuteNonQuery();//ejecuta el query
                con.Close();//cierra la conexion
                txt_contraseña.Text = "";
                MessageBox.Show("Se cambio la contraseña del usuario '"+cmb_usuario.Text.ToString()+"'", "Cambio de contraseña", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.UseSystemPasswordChar == true)
            {
                txt_contraseña.UseSystemPasswordChar = false;
            }
            else if (txt_contraseña.UseSystemPasswordChar == false)
            {
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = true;
        }
    }
}
