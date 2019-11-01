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
    public partial class EliminarProducto : Form
    {
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        public EliminarProducto()
        {
            InitializeComponent();
            producto();
        }

        public void producto()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from producto where estado=1", con);//llama a la tabla de inventario para ver stock
                                                                                                        //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos.DataSource = tabla;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" || txt_codProducto.Text=="")
            {
                MessageBox.Show("Seleccione el Producto a eliminar", "Error de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                    OdbcCommand cmd1 = new OdbcCommand("update Producto set Estado=0 where idProducto='"+txt_codProducto.Text+"'", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion


                    MessageBox.Show("Se deshabilito el producto '" + txt_nombre.Text + "'", "Nuevo producto", MessageBoxButtons.OK);
                    txt_codProducto.Text = "";
                    txt_nombre.Text = "";
                    producto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    txt_codProducto.Text = "";
                    txt_nombre.Text = "";
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

        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                try
                {
                    txt_codProducto.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                    txt_nombre.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
