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
    public partial class EliminarUsuario : Form
    {
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        public EliminarUsuario()
        {
            InitializeComponent();
            cmb_usuario.DataSource = CapaDatosBodega.llenarUsuarioActivo();
            cmb_usuario.ValueMember = "nombre";
        }

       

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Desea eliminar el usuario '"+cmb_usuario.Text.ToString()+"'", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Yes)
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                    OdbcCommand cmd1 = new OdbcCommand("update usuario set estado=0 where nombre='" + cmb_usuario.Text.ToString() + "'", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    MessageBox.Show("Usuario paso a estar inactivo en el sistema", "Usuario creado", MessageBoxButtons.OK);
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
    }
}
