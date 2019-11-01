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
using Common.Cache;
using Datos;
using Dominio;

namespace Bodega.Ajustes
{
    public partial class NuevoProducto : Form
    {
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            UsuarioModel producto = new UsuarioModel();

            if (txt_codigo.Text == "" || txt_nombre.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //var validProduct = producto.AñadirProduc(txt_codigo.Text, txt_nombre.Text);
                //if (validProduct == true)
                    
                    try
                    {
                        OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                        OdbcCommand cmd1 = new OdbcCommand("insert into producto values ('" + txt_codigo.Text + "','" + txt_nombre.Text + "',1)", con);
                        con.Open();//abre la conexion 
                        cmd1.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion


                        MessageBox.Show("Se añadio el producto '" + txt_nombre.Text + "'", "Nuevo producto", MessageBoxButtons.OK);
                        txt_codigo.Text = "";
                        txt_nombre.Text = "";
                    }
                    catch (Exception ex)
                    {
                    MessageBox.Show("Este codigo o nombre ya esta en uso, vuelva a intentarlo", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.ToString());
                    }
                    /*else
                    {
                        MessageBox.Show("Este codigo o nombre ya esta en uso, vuelva a intentarlo", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
                
                
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
