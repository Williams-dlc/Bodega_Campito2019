using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;

namespace Bodega.Productos
{
    public partial class ListadoProducto : Form
    {
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        CapaDatosBodega conexion = new CapaDatosBodega();
        public ListadoProducto()
        {
            InitializeComponent();
            dgv_productos.DataSource = CapaDatosBodega.llenarInventario();
            gbx_Producto.Visible = false;

            cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario.ValueMember = "Nombre";
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            disponibilidad();
        }

        public void disponibilidad() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from Producto a INNER JOIN detalleinventario b on a.idProducto=b.FK_producto where FK_Propietario='" + cmb_propietario.Text.ToString() + "'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                  //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos.DataSource = tabla;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbx_Producto.Visible = true;
            lbl_buscar.Visible = false;

            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from producto", con);//llama a la tabla de inventario para ver stock
                                                                                              //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos.DataSource = tabla;
        }

        private void btn_aceptarProd_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_producto, cantidad, FK_Propietario from DetalleInventario  where FK_Producto='" + txt_codProducto.Text + "'", con);//llama a la tabla de inventario para ver stock   a INNER JOIN producto b on a.FK_producto=b.idProducto
                                                                                                                                                                                   //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos.DataSource = tabla;
        }

        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_codProducto.Text= Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_producto.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void verPrestamos()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("Select * from EncabezadoPrestamo a INNER JOIN DetallePrestamo b ON a.idPrestamo=b.FK_EncPrestamo AND b.Estado=1 and a.FK_Propietario='" + cmb_propietario.Text.ToString()+"'", con);//
              
                cmd.Fill(tabla);
            }
            dgv_productos.DataSource = tabla;

        }

        private void btn_Prestados_Click(object sender, EventArgs e)
        {
            verPrestamos();
        }
    }
}
