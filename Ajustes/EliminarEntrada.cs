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
    public partial class EliminarEntrada : Form
    {
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        public EliminarEntrada()
        {
            InitializeComponent();
            cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario.ValueMember = "Nombre";

            cmb_propietario2.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario2.ValueMember = "Nombre";

            years();

        }


        public void years()
        {
            for (int i = 2019; i < 2050; i++)
            {
                cmb_year.Items.Add(i.ToString());
            }

        }
        public void EntradasFecha() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                //OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT * FROM encabezadoentrada a INNER JOIN detalleentrada b ON a.idEntrada=b.FK_encEntrada where fecha='" + dtp_fecha.Value.ToString("yyyyMMdd") + "'", con);//llama a la tabla de inventario para ver stock
                //OdbcDataReader queryResults = cmd.ExecuteReader();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT e.idEntrada as 'Codigo', e.fecha, e.FK_Distribuidor as 'Distribuidor', e.fk_trabajador AS 'Despacho', e.Entrego, e.FK_Tipo_Bodega AS 'Bodega', d.FK_producto as 'Producto', p.name as 'Producto', d.cantidad, d.comentario from encabezadoentrada e, producto p, detalleentrada d where e.fecha='" + dtp_fecha.Value.ToString("yyyyMMdd") + "' and p.idProducto=d.Fk_Producto and e.idEntrada=d.FK_encEntrada", con);

                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;

        }

        public void EntradasPropietario() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                //OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT * FROM encabezadoentrada a INNER JOIN detalleentrada b ON a.idEntrada=b.FK_encEntrada where FK_Distribuidor='" + cmb_propietario.Text.ToString() + "' and fecha='" + dtp_FechaPro.Value.ToString("yyyyMMdd") + "'", con);//llama a la tabla de inventario para ver stock

                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT e.idEntrada as 'Codigo', e.fecha, e.FK_Distribuidor as 'Distribuidor', e.fk_trabajador AS 'Despacho', e.Entrego, e.FK_Tipo_Bodega AS 'Bodega', d.FK_producto as 'Producto', p.name as 'Producto', d.cantidad, d.comentario from encabezadoentrada e, producto p, detalleentrada d where e.fecha='" + dtp_FechaPro.Value.ToString("yyyyMMdd") + "' and p.idProducto=d.Fk_Producto and e.idEntrada=d.FK_encEntrada and e.FK_Distribuidor='"+cmb_propietario.Text.ToString()+"'", con);//llama a la tabla de inventario para ver stock                                                                                                                                                                                                                                    

                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;

        }

        public void EntradasCodigo() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                //OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT * FROM encabezadoentrada a INNER JOIN detalleentrada b ON a.idEntrada=b.FK_encEntrada where identrada='" + txt_codigo.Text + "'", con);//llama a la tabla de inventario para ver stock
                //OdbcDataReader queryResults = cmd.ExecuteReader();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT e.idEntrada as 'Codigo', e.fecha, e.FK_Distribuidor as 'Distribuidor', e.fk_trabajador AS 'Despacho', e.Entrego, e.FK_Tipo_Bodega AS 'Bodega', p.name, d.cantidad, d.comentario from encabezadoentrada e, producto p, detalleentrada d where p.idProducto = d.Fk_Producto and e.idEntrada = d.FK_encEntrada AND e.idEntrada = '" + txt_codigo.Text+"'", con);//llama a la tabla de inventario para ver stock                                                                                                                                                                                                                                    

                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;

        }

        private void btn_aceptarDate_Click(object sender, EventArgs e)
        {
            EntradasFecha();
        }

        private void btn_aceptarCod_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Llene el campo de codigo");
            }
            else
                EntradasCodigo();
        }

        private void btn_aceparPro_Click(object sender, EventArgs e)
        {
            EntradasPropietario();
        }

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            dtp_fecha.Enabled = true;
            btn_aceptarDate.Enabled = true;

            txt_codigo.Enabled = false;
            btn_aceptarCod.Enabled = false;
            cmb_propietario.Enabled = false;
            btn_aceparPro.Enabled = false;
            dtp_FechaPro.Enabled = false;
        }

        private void btn_codigo_Click(object sender, EventArgs e)
        {
            txt_codigo.Enabled = true;
            btn_aceptarCod.Enabled = true;

            cmb_propietario.Enabled = false;
            dtp_FechaPro.Enabled = false;
            btn_aceparPro.Enabled = false;
            dtp_fecha.Enabled = false;
            btn_aceptarDate.Enabled = false;
        }

        private void btn_propietario_Click(object sender, EventArgs e)
        {
            cmb_propietario.Enabled = true;
            btn_aceparPro.Enabled = true;
            dtp_FechaPro.Enabled = true;

            dtp_fecha.Enabled = false;
            btn_aceptarDate.Enabled = false;
            txt_codigo.Enabled = false;
            btn_aceptarCod.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceparPro_Click_1(object sender, EventArgs e)
        {
            EntradasPropietario();
        }

        private void dgv_Entradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_codEntrada.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_producto.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[6].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_propietario.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[2].Value.ToString());
                txt_codDetalle.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_cantidad.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_propietario.Text == "" || txt_codEntrada.Text == "" || txt_producto.Text=="" || txt_codDetalle.Text=="" || txt_cantidad.Text=="")
            {
                MessageBox.Show("No se ha seleccionado algun articulo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar la entrada con el producto '" + txt_producto.Text + "' con la cantidad de '" + txt_cantidad.Text + " del distribuidor '"+txt_propietario.Text+"''?", "Nuevo", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                        OdbcCommand cmd1 = new OdbcCommand("DELETE FROM detalleentrada WHERE Fk_Producto='" + txt_producto.Text + "' AND FK_EncEntrada='" + txt_codEntrada.Text + "' AND cantidad='" + txt_cantidad.Text + "'  ", con);
                        con.Open();//abre la conexion ;
                        cmd1.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd4 = new OdbcCommand("UPDATE detalleinventario set cantidad=cantidad - '" + txt_cantidad.Text + "' WHERE Fk_Producto='" + txt_producto.Text + "' AND FK_Propietario='" + txt_propietario.Text.ToString() + "'", con);
                        con.Open();//abre la conexion ;
                        cmd4.ExecuteNonQuery();
                        con.Close();//cierra la conexion                    

                        dgv_Entradas.Rows.Remove(dgv_Entradas.CurrentRow);
                        txt_codDetalle.Text = "";
                        txt_codEntrada.Text = "";
                        txt_cantidad.Text = "";
                        txt_producto.Text = "";
                        txt_propietario.Text = "";
                    }catch(Exception ex)
                    {
                        //MessageBox.Show("No se ha seleccionado algun articulo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }

        public void mes()
        {
            if (cmb_mes.Text.ToString() == "Enero")
            {
                txt_numero.Text = "1";
            }
            else if (cmb_mes.Text.ToString() == "Febrero")
            {
                txt_numero.Text = "2";
            }
            else if (cmb_mes.Text.ToString() == "Marzo")
            {
                txt_numero.Text = "3";
            }
            else if (cmb_mes.Text.ToString() == "Abril")
            {
                txt_numero.Text = "4";
            }
            else if (cmb_mes.Text.ToString() == "Mayo")
            {
                txt_numero.Text = "5";
            }
            else if (cmb_mes.Text.ToString() == "Junio")
            {
                txt_numero.Text = "6";
            }
            else if (cmb_mes.Text.ToString() == "Julio")
            {
                txt_numero.Text = "7";
            }
            else if (cmb_mes.Text.ToString() == "Agosto")
            {
                txt_numero.Text = "8";
            }
            else if (cmb_mes.Text.ToString() == "Septiembre")
            {
                txt_numero.Text = "9";
            }
            else if (cmb_mes.Text.ToString() == "Octubre")
            {
                txt_numero.Text = "10";
            }
            else if (cmb_mes.Text.ToString() == "Noviembre")
            {
                txt_numero.Text = "11";
            }
            else if (cmb_mes.Text.ToString() == "Diciembre")
            {
                txt_numero.Text = "12";
            }
        }

        public void productoMensual()
        {
            mes();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                //OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT a.fk_encEntrada, a.fk_Producto, SUM(Cantidad) AS 'Cantidad' FROM detalleentrada a INNER JOIN encabezadoentrada b ON a.FK_encEntrada=b.idEntrada AND b.FK_Distribuidor='" + cmb_propietario2.Text.ToString() + "' AND b.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-1' AND '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-30' GROUP BY Fk_Producto", con);//llama a la tabla de inventario para ver stock
                //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT d.fk_encEntrada as 'Codigo', b.fecha, b.fk_trabajador as 'Despacho', b.Entrego, b.FK_Tipo_Bodega AS 'Bodega', p.name as 'Producto', d.cantidad AS 'Cantidad', d.comentario from detalleentrada d, producto p, encabezadoentrada b where d.FK_encEntrada=b.idEntrada AND b.FK_Distribuidor='" + cmb_propietario2.Text.ToString() + "' AND d.Fk_Producto=p.idProducto and b.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-01' AND '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-31'", con);//llama a la tabla de inventario para ver stock
                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;


        }

        private void btn_aceptarMes_Click(object sender, EventArgs e)
        {
            productoMensual();
        }
    }
}
