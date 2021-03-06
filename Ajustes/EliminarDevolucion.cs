﻿using System;
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
    public partial class EliminarDevolucion : Form
    {
        //string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=35.222.102.30;Database=Bodega_Campito;uid=root;pwd=125654campUSER";
        public EliminarDevolucion()
        {
            InitializeComponent();
            dtp_fecha.Enabled = false;
            btn_aceptarDate.Enabled = false;

            txt_codigo.Enabled = false;
            btn_aceptarCod.Enabled = false;

            cmb_propietario.Enabled = false;
            btn_aceparPro.Enabled = false;
            dtp_FechaPro.Enabled = false;

            //cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            //cmb_propietario.ValueMember = "Nombre";

            this.tt_distribuidor.SetToolTip(this.lbl_distribuidor, "Ingrese el nombre del distribuidor que realizo la dovolucion");
            this.tt_distribuidor.SetToolTip(this.cmb_propietario, "Seleccione el nombre del distribuidor que realizo la dovolucion");
            this.tt_distribuidor.SetToolTip(this.btn_propietario, "Seleccione el nombre del distribuidor que realizo la dovolucion");

            //cmb_propietario2.DataSource = CapaDatosBodega.llenarPropietario();
            //cmb_propietario2.ValueMember = "Nombre";

            propietarios();

            years();
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
            cmb_propietario2.ValueMember = "Nombre";
            cmb_propietario2.DataSource = tabla;

        }

        public void years()
        {
            for (int i = 2019; i < 2050; i++)
            {
                cmb_year.Items.Add(i.ToString());
            }

        }

        public void DevCodigo() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                //OdbcDataAdapter cmd = new OdbcDataAdapter("select * from encabezadoDevoluciones b INNER JOIN DetalleDevoluciones a ON b.idDevoluciones=a.FK_EncDevoluciones WHERE b.idDevoluciones='" + txt_codigo.Text + "' AND a.FK_encDevoluciones= '" + txt_codigo.Text + "'   ", con);//llama a la tabla de inventario para ver stock


                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idDevoluciones as 'Codigo', d.fk_codDetallePrestamo as 'ID', d.idDetalleDevoluciones as 'Codigo2', e.fecha, e.fk_trabajador as 'Encargado', e.fk_propietario as 'Propietario', e.fk_prestador as 'Prestador', e.fk_bodega as 'Bodega', e.entrego, d.fk_producto as 'Cod Producto', p.name as 'Producto', d.cantidad, d.comentario from EncabezadoDevoluciones e, DetalleDevoluciones d, Producto p where e.idDevoluciones='" + txt_codigo.Text+ "' and p.idProducto=d.Fk_Producto and e.idDevoluciones=d.FK_EncDevoluciones", con);
                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;

        }

        public void DevFecha() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                //OdbcDataAdapter cmd = new OdbcDataAdapter("select * from encabezadoDevoluciones b INNER JOIN DetalleDevoluciones a ON b.idDevoluciones=a.FK_EncDevoluciones WHERE b.fecha='" + dtp_fecha.Value.ToString("yyyyMMdd") + "'", con);//llama a la tabla de inventario para ver stock

                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idDevoluciones as 'Codigo', d.fk_codDetallePrestamo as 'ID', d.idDetalleDevoluciones as 'Codigo2', e.fecha, e.fk_trabajador as 'Encargado', e.fk_propietario as 'Propietario', e.fk_prestador as 'Prestador', e.fk_bodega as 'Bodega', e.entrego, d.fk_producto as 'Cod Producto', p.name as 'Producto', d.cantidad, d.comentario from EncabezadoDevoluciones e, DetalleDevoluciones d, Producto p where e.idDevoluciones=d.FK_EncDevoluciones and p.idProducto=d.Fk_Producto and e.fecha='" + dtp_fecha.Value.ToString("yyyyMMdd") + "'", con);
                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;

        }

        public void DevPropietario() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                //OdbcDataAdapter cmd = new OdbcDataAdapter("select * from encabezadoDevoluciones b INNER JOIN DetalleDevoluciones a ON b.idDevoluciones=a.FK_EncDevoluciones WHERE b.fecha='" + dtp_fecha.Value.ToString("yyyyMMdd") + "' and b.FK_Prestador='" + cmb_propietario.Text.ToString() + "'", con);//llama a la tabla de inventario para ver stock


                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idDevoluciones as 'Codigo', d.fk_codDetallePrestamo as 'ID', d.idDetalleDevoluciones as 'Codigo2', e.fecha, e.fk_trabajador as 'Encargado', e.fk_propietario as 'Propietario', e.fk_prestador as 'Prestador', e.fk_bodega as 'Bodega', e.entrego, d.fk_producto as 'Cod Producto', p.name as 'Producto', d.cantidad, d.comentario from EncabezadoDevoluciones e, DetalleDevoluciones d, Producto p where e.idDevoluciones=d.FK_EncDevoluciones and p.idProducto=d.Fk_Producto and e.fecha='" + dtp_FechaPro.Value.ToString("yyyyMMdd") + "' and e.FK_Prestador='" + cmb_propietario.Text.ToString() + "'", con);
                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;

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
            cmb_mes.Enabled = false;
            cmb_propietario2.Enabled = false;
            cmb_year.Enabled = false;
            
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
            cmb_mes.Enabled = false;
            cmb_propietario2.Enabled = false;
            cmb_year.Enabled = false;
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
            cmb_mes.Enabled = false;
            cmb_propietario2.Enabled = false;
            cmb_year.Enabled = false;
        }

        private void btn_aceptarDate_Click(object sender, EventArgs e)
        {
            DevFecha();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptarCod_Click(object sender, EventArgs e)
        {
            DevCodigo();
        }

        private void btn_aceparPro_Click(object sender, EventArgs e)
        {
            DevPropietario();
        }

        private void dgv_Entradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_codPrestamo.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_producto.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[9].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_propietario.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[5].Value.ToString());
                txt_codDetalle.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[2].Value.ToString());
                txt_cantidad.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[11].Value.ToString());
                txt_prestador.Text = Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[6].Value.ToString());
                txt_codDetallePrestamo.Text= Convert.ToString(dgv_Entradas.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_propietario.Text == "" || txt_codPrestamo.Text == "" || txt_producto.Text == "" || txt_codDetalle.Text == "" || txt_cantidad.Text == "")
            {
                MessageBox.Show("No se ha seleccionado algun articulo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el prestamo con el producto '" + txt_producto.Text + "' con la cantidad de '" + txt_cantidad.Text + " del propietario '" + txt_propietario.Text + "' y prestador '" + txt_prestador.Text + "''?", "Nuevo", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                        OdbcCommand cmd1 = new OdbcCommand("DELETE FROM DetalleDevoluciones WHERE Fk_Producto='" + txt_producto.Text + "' AND FK_encdevoluciones='" + txt_codPrestamo.Text + "' AND cantidad='" + txt_cantidad.Text + "' AND idDetalleDevoluciones='" + txt_codDetalle.Text + "' ", con);
                        con.Open();//abre la conexion ;
                        cmd1.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd3 = new OdbcCommand("DELETE FROM DetalleDevoluciones_respaldo WHERE Fk_Producto='" + txt_producto.Text + "' AND FK_EncDevoluciones_resp='" + txt_codPrestamo.Text + "' AND cantidad='" + txt_cantidad.Text + "' AND idDetalleDevoluciones='" + txt_codDetalle.Text + "' ", con);
                        con.Open();//abre la conexion ;
                        cmd3.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd4 = new OdbcCommand("UPDATE DetalleInventario set cantidad=cantidad - '" + txt_cantidad.Text + "' WHERE Fk_Producto='" + txt_producto.Text + "' AND FK_Propietario='" + txt_propietario.Text + "'", con);
                        con.Open();//abre la conexion ;
                        cmd4.ExecuteNonQuery();
                        con.Close();//cierra la conexion       

                        OdbcCommand cmd2 = new OdbcCommand("UPDATE DetalleInventario set cantidad=cantidad + '" + txt_cantidad.Text + "' WHERE Fk_Producto='" + txt_producto.Text + "' AND FK_Propietario='" + txt_prestador.Text + "'", con);
                        con.Open();//abre la conexion ;
                        cmd2.ExecuteNonQuery();
                        con.Close();//cierra la conexion      

                        OdbcCommand cmd5 = new OdbcCommand("update DetallePrestamo set estado=1 WHERE Fk_Producto='" + txt_producto.Text + "' AND idDetallePrestamo='" + txt_codDetallePrestamo.Text + "' AND cantidad='" + txt_cantidad.Text + "'", con);
                        con.Open();//abre la conexion ;
                        cmd5.ExecuteNonQuery();
                        con.Close();//cierra la conexion            

                        if (btn_Fecha.Enabled == true && btn_codigo.Enabled == false && btn_propietario.Enabled == false)
                        {
                            DevFecha();
                        }
                        else if (btn_Fecha.Enabled == false && btn_codigo.Enabled == true && btn_propietario.Enabled == false)
                        {
                            DevCodigo();
                        }
                        else if (btn_Fecha.Enabled == false && btn_codigo.Enabled == false && btn_propietario.Enabled == true)
                        {
                            DevPropietario();
                        }

                        txt_codDetalle.Text = "";
                        txt_codPrestamo.Text = "";
                        txt_cantidad.Text = "";
                        txt_producto.Text = "";
                        txt_propietario.Text = "";
                        txt_prestador.Text = "";
                    }
                    catch (Exception ex)
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

        public void Devolucion_Mensual()
        {
            mes();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idDevoluciones as 'Codigo', d.fk_codDetallePrestamo as 'ID', d.idDetalleDevoluciones as 'Codigo2', e.fecha, e.fk_trabajador as 'Encargado', e.fk_propietario as 'Propietario', e.fk_prestador as 'Prestador', e.fk_bodega as 'Bodega', e.entrego, d.fk_producto as 'Cod Producto', p.name as 'Producto', d.cantidad, d.comentario from EncabezadoDevoluciones e, DetalleDevoluciones d, Producto p where e.idDevoluciones=d.FK_EncDevoluciones AND e.FK_Prestador='" + cmb_propietario2.Text.ToString() + "' AND e.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-1' AND '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-30' and d.Fk_Producto=p.idproducto", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;


        }

        private void btn_aceptarMes_Click(object sender, EventArgs e)
        {
            Devolucion_Mensual();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_mes.Enabled = true;
            cmb_propietario2.Enabled = true;
            cmb_year.Enabled = true;

            cmb_propietario.Enabled = false;
            btn_aceparPro.Enabled = false;
            dtp_FechaPro.Enabled = false;

            dtp_fecha.Enabled = false;
            btn_aceptarDate.Enabled = false;
            txt_codigo.Enabled = false;
            btn_aceptarCod.Enabled = false;
            
        }
    }
}
