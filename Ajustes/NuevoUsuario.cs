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
    public partial class NuevoUsuario : Form
    {
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        public NuevoUsuario()
        {
            InitializeComponent();
            cmb_perfil.DataSource = CapaDatosBodega.llenarPerfil();
            cmb_perfil.ValueMember = "tipo";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = true;
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.UseSystemPasswordChar == true)
            {
                txt_contraseña.UseSystemPasswordChar = false;
            }
            else if(txt_contraseña.UseSystemPasswordChar == false)
            {
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "")
                MessageBox.Show("Llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                    OdbcCommand cmd1 = new OdbcCommand("insert into usuario values ('" + txt_usuario.Text + "',null,null,'" + txt_contraseña.Text + "','" + cmb_perfil.Text.ToString() + "',1)", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    OdbcConnection con2 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                    OdbcCommand cmd2 = new OdbcCommand("insert into Trabajador values ('"+txt_usuario.Text+"','"+txt_usuario.Text+"')", con2);
                    con2.Open();//abre la conexion 
                    cmd2.ExecuteNonQuery();//ejecuta el query
                    con2.Close();//cierra la conexion*/

                    MessageBox.Show("Usuario creado exitosamente", "Usuario creado", MessageBoxButtons.OK);

                    txt_contraseña.Text = "";
                    txt_usuario.Text = "";
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("El nombre de usuario ya esta en uso, utilice otro nombre", "Error al crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
