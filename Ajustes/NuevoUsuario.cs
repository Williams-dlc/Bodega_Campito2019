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
        //string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=35.222.102.30;Database=Bodega_Campito;uid=root;pwd=125654campUSER";
        public NuevoUsuario()
        {
            InitializeComponent();
            /*cmb_perfil.DataSource = CapaDatosBodega.llenarPerfil2();
            cmb_perfil.ValueMember = "tipo";*/
            perfiles();

            personalizado();
        }

        public void perfiles()

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from Perfil where estado=1", con);//llama a la tabla de inventario para ver stock
                                                                                                        //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }
            cmb_perfil.ValueMember = "tipo";
            cmb_perfil.DataSource = tabla;

        }

        void personalizado()
        {
            if (cmb_perfil.Text.ToString() == "Personalizado")
            {
                chb_produtos.Enabled = true;
                chb_traslados.Enabled = true;
                chb_reportes.Enabled = true;
                chb_graficas.Enabled = true;
                chb_confAdmin.Enabled = true;
                chb_confTrabajador.Enabled = true;
            }
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
            if (txt_contraseña.Text == "" || txt_usuario.Text=="" || cmb_perfil.SelectedIndex==-1)
                MessageBox.Show("Llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (cmb_perfil.Text.ToString() == "Administrador" || cmb_perfil.Text.ToString() == "Trabajador")
                {
                    try
                    {
                        OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                        OdbcCommand cmd1 = new OdbcCommand("insert into Usuario values ('" + txt_usuario.Text + "',null,null,'" + txt_contraseña.Text + "','" + cmb_perfil.Text.ToString() + "',1)", con);
                        con.Open();//abre la conexion 
                        cmd1.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion

                        OdbcConnection con2 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                        OdbcCommand cmd2 = new OdbcCommand("insert into Trabajador values ('" + txt_usuario.Text + "','" + txt_usuario.Text + "')", con2);
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
                }else if (cmb_perfil.Text.ToString()== "Personalizado")
                {
                    chb_produtos.Enabled = true;
                    chb_traslados.Enabled = true;
                    chb_reportes.Enabled = true;
                    chb_graficas.Enabled = true;
                    chb_confAdmin.Enabled = true;
                    chb_confTrabajador.Enabled = true;

                    OdbcConnection con1 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                    OdbcCommand cmd1 = new OdbcCommand("insert into Perfil values ('" + cmb_perfil.Text.ToString() + txt_usuario.Text + "',0,0,0,0,0,0,2)", con1);
                    con1.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con1.Close();//cierra la conexion*/

                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                    OdbcCommand cmd = new OdbcCommand("insert into Usuario values ('" + txt_usuario.Text + "',null,null,'" + txt_contraseña.Text + "','" + cmb_perfil.Text.ToString() + ""+txt_usuario.Text+"',1)", con);
                    con.Open();//abre la conexion 
                    cmd.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    OdbcConnection con3 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                    OdbcCommand cmd3 = new OdbcCommand("insert into Trabajador values ('" + txt_usuario.Text + "','" + txt_usuario.Text + "')", con3);
                    con3.Open();//abre la conexion 
                    cmd3.ExecuteNonQuery();//ejecuta el query
                    con3.Close();//cierra la conexion*/

                    
                    MessageBox.Show("Usuario creado exitosamente", "Usuario creado", MessageBoxButtons.OK);

                    if (chb_produtos.Checked == true) {
                        OdbcConnection con2 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                        OdbcCommand cmd2 = new OdbcCommand("update Perfil set Productos = '1' where Tipo='" + cmb_perfil.Text.ToString() + txt_usuario.Text + "' ", con2);
                        con2.Open();//abre la conexion 
                        cmd2.ExecuteNonQuery();//ejecuta el query
                        con2.Close();//cierra la conexion*/
                    }

                    if (chb_traslados.Checked == true)
                    {
                        OdbcConnection con2 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                        OdbcCommand cmd2 = new OdbcCommand("update Perfil set Traslados = '1' where Tipo='" + cmb_perfil.Text.ToString() + txt_usuario.Text + "' ", con2);
                        con2.Open();//abre la conexion 
                        cmd2.ExecuteNonQuery();//ejecuta el query
                        con2.Close();//cierra la conexion*/
                    }

                    if (chb_reportes.Checked==true)
                    {
                        OdbcConnection con2 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                        OdbcCommand cmd2 = new OdbcCommand("update Perfil set Reportes = '1' where Tipo='" + cmb_perfil.Text.ToString() + txt_usuario.Text + "' ", con2);
                        con2.Open();//abre la conexion 
                        cmd2.ExecuteNonQuery();//ejecuta el query
                        con2.Close();//cierra la conexion*/
                    }

                    if (chb_graficas.Checked == true)
                    {
                        OdbcConnection con2 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                        OdbcCommand cmd2 = new OdbcCommand("update Perfil set Graficas = '1' where Tipo='" + cmb_perfil.Text.ToString() + txt_usuario.Text + "' ", con2);
                        con2.Open();//abre la conexion 
                        cmd2.ExecuteNonQuery();//ejecuta el query
                        con2.Close();//cierra la conexion*/
                    }

                    if (chb_confAdmin.Checked == true)
                    {
                        OdbcConnection con2 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                        OdbcCommand cmd2 = new OdbcCommand("update Perfil set Configuracion1 = '1' where Tipo='" + cmb_perfil.Text.ToString() + txt_usuario.Text + "' ", con2);
                        con2.Open();//abre la conexion 
                        cmd2.ExecuteNonQuery();//ejecuta el query
                        con2.Close();//cierra la conexion*/
                    }

                    if (chb_confTrabajador.Checked == true)
                    {
                        OdbcConnection con2 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                        OdbcCommand cmd2 = new OdbcCommand("update Perfil set Configuracion2 = '1' where Tipo='" + cmb_perfil.Text.ToString() + txt_usuario.Text + "' ", con2);
                        con2.Open();//abre la conexion 
                        cmd2.ExecuteNonQuery();//ejecuta el query
                        con2.Close();//cierra la conexion*/
                    }
                }
            }
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            personalizado();
        }

        private void cmb_perfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            personalizado();
        }
    }
}
