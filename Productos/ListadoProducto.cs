﻿using System;
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
        //string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=35.222.102.30;Database=Bodega_Campito;uid=root;pwd=125654campUSER";
        
        public ListadoProducto()
        {
            InitializeComponent();
            //dgv_productos.DataSource = CapaDatosBodega.llenarInventario2();
            gbx_Producto.Visible = false;

            //cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            //cmb_propietario.ValueMember = "Nombre";
            propietarios();
            inventarios();
        }

        public void inventarios()

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select d.fk_producto AS 'Codigo de producto', p.name as 'Producto', d.cantidad AS 'Cantidad disponible', d.fk_propietario as 'Propietario de producto' from DetalleInventario d, Producto p WHERE p.idProducto=d.Fk_Producto", con);//llama a la tabla de inventario para ver stock
                                                                                                    //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }
            dgv_productos.DataSource = tabla;

        }


        public void propietarios()

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select nombre from Distribuidores", con);//llama a la tabla de inventario para ver stock
                                                                                                    //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }
            cmb_propietario.ValueMember = "Nombre";
            cmb_propietario.DataSource = tabla;

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
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from Producto a INNER JOIN DetalleInventario b on a.idProducto=b.FK_producto where FK_Propietario='" + cmb_propietario.Text.ToString() + "'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                  //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos.DataSource = tabla;
            dgv_productos.Columns[0].Visible = false;//columna de id producto
            dgv_productos.Columns[2].Visible = false;//columnas de encabezados
            dgv_productos.Columns[3].Visible = false;//columnas de encabezados
            dgv_productos.Columns[4].Visible = false;//columnas de encabezados
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbx_Producto.Visible = true;
            lbl_buscar.Visible = false;

            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from Producto where estado=1", con);//llama a la tabla de inventario para ver stock
                                                                                              //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos.DataSource = tabla;
        }

        private void btn_aceptarProd_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_producto AS 'Producto', cantidad, FK_Propietario AS 'Distribuidor' from DetalleInventario  where FK_Producto='" + txt_codProducto.Text + "'", con);//llama a la tabla de inventario para ver stock   a INNER JOIN producto b on a.FK_producto=b.idProducto
                                                                                                                                                                                                                        //OdbcDataReader queryResults = cmd.ExecuteReader();

                OdbcDataAdapter cmd2 = new OdbcDataAdapter("SELECT p.name as 'Producto', sum(d.cantidad) AS 'Cantidad' from DetalleInventario d, Producto p where d.fk_producto='" + txt_codProducto.Text + "' and p.idProducto=d.Fk_Producto", con);
                cmd.Fill(tabla);
                cmd2.Fill(tabla2);

            }

            dgv_productos.DataSource = tabla;
            dgv_totalProductos.DataSource = tabla2;
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
                //OdbcDataAdapter cmd = new OdbcDataAdapter("Select idPrestamo AS 'ID', fecha, FK_Trabajador AS 'Trabajador', FK_Propietario AS 'Distribuidor', FK_Prestador AS 'Prestador', FK_Tipo_Bodega AS 'Bodega' from EncabezadoPrestamo a INNER JOIN DetallePrestamo b ON a.idPrestamo=b.FK_EncPrestamo AND b.Estado=1 and a.FK_Propietario='" + cmb_propietario.Text.ToString()+"'", con);//

                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idPrestamo as 'Codigo', e.Fecha, e.fk_prestador as 'Prestador', e.FK_trabajador as 'Entrego', e.Recibio, p.Name as 'Producto', d.Cantidad,  d.comentario from EncabezadoPrestamo e, DetallePrestamo d, Producto p where e.idPrestamo=d.FK_EncPrestamo AND e.FK_Propietario = '" + cmb_propietario.Text.ToString() + "' AND p.idProducto=d.Fk_Producto AND d.estado=1", con);
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
