using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace Bodega.Reportes
{
    public partial class ReportesEntradas : Form
    {

        CapaDatosBodega conexion = new CapaDatosBodega();
        //string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=35.222.102.30;Database=Bodega_Campito;uid=root;pwd=125654campUSER";
        bool salidas;
        public ReportesEntradas()
        {

            InitializeComponent();
            years();
            cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario.ValueMember = "Nombre";

            cmb_mes.SelectedIndex = 0;

            grf_Barras.Visible = false;
            grf_pie.Visible = false;
            grf_barrasSalidas.Visible = false;
            grf_pieSalidas.Visible = false;

            cmb_year.Enabled = false;
            cmb_mes.Enabled = false;
            btn_aceptar.Enabled = false;
            btn_salidas.Enabled = false;

            if (rdb_Mes.Checked == true)
            {
                cmb_mes.Enabled = true;
                cmb_year.Enabled = true;
            }
            else if (rdb_año.Checked == true)
            {
                cmb_mes.Enabled = false;
                cmb_year.Enabled = true;
            }

        }

        public void mes()
        {
            if (cmb_mes.Text.ToString() == "Enero")
            {
                txt_numero.Text = "1";
            }else if (cmb_mes.Text.ToString() == "Febrero")
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
        
        public void years()
        {
            for (int i = 2019; i < 2050; i++)
            {
                cmb_year.Items.Add(i.ToString());
            }
            
        }

        public void radiob()
        {
            if (rdb_año.Checked == false && rdb_Mes.Checked == false)
            {
                MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                btn_aceptar.Enabled = true;
                btn_salidas.Enabled = true;
                if (rdb_Mes.Checked == true)
                {
                    cmb_mes.Enabled = true;
                    cmb_year.Enabled = true;
                }
                else if (rdb_año.Checked == true)
                {
                    cmb_mes.Enabled = false;
                    cmb_year.Enabled = true;
                }
            }
        }

        public void Barras_producto()
        {
            mes();
            grf_Barras.Series["Series1"].LegendText = cmb_propietario.Text.ToString();
            grf_Barras.Series["Series1"].XValueMember = "name";
            grf_Barras.Series["Series1"].YValueMembers = "Cantidad";
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT d.fk_encEntrada, p.name, SUM(Cantidad) AS 'Cantidad' from DetalleEntrada d, Producto p, EncabezadoEntrada b where d.FK_encEntrada=b.idEntrada AND b.FK_Distribuidor='" + cmb_propietario.Text.ToString() + "' AND b.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-1' AND '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-30' and p.idProducto=d.Fk_Producto GROUP BY Fk_Producto", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                               //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }
            
            grf_Barras.DataSource = tabla;

            
        }

        public void pie_producto()
        {
            mes();
            grf_pie.Series["Series1"].IsValueShownAsLabel = true;
            grf_pie.Series["Series1"].XValueMember = "name";
            grf_pie.Series["Series1"].YValueMembers = "Cantidad";
            grf_pie.Series["Series1"].Points.AddXY("FK_Producto","Cantidad");
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT d.fk_encEntrada, p.name, SUM(d.Cantidad) AS 'Cantidad' from Detalleentrada d, Producto p, EncabezadoEntrada b where d.FK_encEntrada=b.idEntrada AND b.FK_Distribuidor='" + cmb_propietario.Text.ToString() + "' AND b.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-1' AND '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-30' and p.idProducto=d.Fk_Producto GROUP BY Fk_Producto", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                     //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                     //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                     //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }

            grf_pie.DataSource = tabla;
        }

        public void Barras_productoAnual()
        {

            grf_Barras.Series["Series1"].LegendText = cmb_propietario.Text.ToString();
            grf_Barras.Series["Series1"].XValueMember = "name";
            grf_Barras.Series["Series1"].YValueMembers = "Cantidad";
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT d.fk_encEntrada, p.name, SUM(d.Cantidad) AS 'Cantidad' from DetalleEntrada d, Producto p, EncabezadoEntrada b where d.FK_encEntrada=b.idEntrada AND b.FK_Distribuidor='" + cmb_propietario.Text.ToString() + "' AND b.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-1-1' AND '" + cmb_year.Text.ToString() + "-12-31' and p.idProducto=d.Fk_Producto GROUP BY Fk_Producto", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                     //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                     //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                     //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }//prueba

            grf_Barras.DataSource = tabla;


        }

        public void pie_productoAnual()
        {

            grf_pie.Series["Series1"].IsValueShownAsLabel = true;
            grf_pie.Series["Series1"].XValueMember = "name";
            grf_pie.Series["Series1"].YValueMembers = "Cantidad";
            grf_pie.Series["Series1"].Points.AddXY("name", "Cantidad");
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT d.fk_encEntrada, p.name, SUM(d.Cantidad) AS 'Cantidad' from DetalleEntrada d, Producto p, EncabezadoEntrada b where d.FK_encEntrada=b.idEntrada AND b.FK_Distribuidor='" + cmb_propietario.Text.ToString() + "' AND b.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-1-1' AND '" + cmb_year.Text.ToString() + "-12-31' and p.idProducto=d.Fk_Producto GROUP BY Fk_Producto", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                     //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                     //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                     //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }

            grf_pie.DataSource = tabla;
        }


        public void Barras_productoSalidas()
        {
            mes();
            grf_barrasSalidas.Series["Series1"].LegendText = cmb_propietario.Text.ToString();
            grf_barrasSalidas.Series["Series1"].XValueMember = "Producto";
            grf_barrasSalidas.Series["Series1"].YValueMembers = "Cantidad";
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT d.FK_EncPedido as 'Codigo', p.name as 'Producto', SUM(d.Cantidad) AS 'Cantidad' from DetallePedido d, Producto p, EncabezadoPedido b where d.FK_EncPedido=b.idPedido AND b.FK_Usuario='" + cmb_propietario.Text.ToString() + "' AND b.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-1' AND '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-30' and p.idProducto=d.Fk_Producto GROUP BY Fk_Producto", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                                                                                                                                                                     //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                                                                                                                                                                                                                                     //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                                                                                                                                                                                                                                     //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }

            grf_barrasSalidas.DataSource = tabla;


        }

        public void pie_productoSalidas()
        {
            mes();
            grf_pieSalidas.Series["Series1"].IsValueShownAsLabel = true;
            grf_pieSalidas.Series["Series1"].XValueMember = "Producto";
            grf_pieSalidas.Series["Series1"].YValueMembers = "Cantidad";
            grf_pieSalidas.Series["Series1"].Points.AddXY("Producto", "Cantidad");
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT d.FK_EncPedido as 'Codigo', p.name as 'Producto', SUM(d.Cantidad) AS 'Cantidad' from DetallePedido d, Producto p, EncabezadoPedido b where d.FK_EncPedido=b.idPedido AND b.FK_Usuario='" + cmb_propietario.Text.ToString() + "' AND b.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-1' AND '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-30' and p.idProducto=d.Fk_Producto GROUP BY Fk_Producto", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                                                                                                                                                                     //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                                                                                                                                                                                                                                     //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                                                                                                                                                                                                                                     //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }

            grf_pieSalidas.DataSource = tabla;
        }

        public void Barras_productoAnualSalidas()
        {

            grf_barrasSalidas.Series["Series1"].LegendText = cmb_propietario.Text.ToString();
            grf_barrasSalidas.Series["Series1"].XValueMember = "Producto";
            grf_barrasSalidas.Series["Series1"].YValueMembers = "Cantidad";
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT d.FK_EncPedido as 'Codigo', p.name as 'Producto', SUM(d.Cantidad) AS 'Cantidad' from DetallePedido d, Producto p, EncabezadoPedido b where d.FK_EncPedido=b.idPedido AND b.FK_Usuario='" + cmb_propietario.Text.ToString() + "' AND b.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-01-1' AND '" + cmb_year.Text.ToString() + "-12-31' and p.idProducto=d.Fk_Producto GROUP BY Fk_Producto", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                                                                                         //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                                                                                                                                                         //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                                                                                                                                                         //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }

            grf_barrasSalidas.DataSource = tabla;


        }

        public void pie_productoAnualSalidas()
        {

            grf_pieSalidas.Series["Series1"].IsValueShownAsLabel = true;
            grf_pieSalidas.Series["Series1"].XValueMember = "Producto";
            grf_pieSalidas.Series["Series1"].YValueMembers = "Cantidad";
            grf_pieSalidas.Series["Series1"].Points.AddXY("FK_Producto", "Cantidad");
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT d.FK_EncPedido as 'Codigo', p.name as 'Producto', SUM(d.Cantidad) AS 'Cantidad' from DetallePedido d, Producto p, EncabezadoPedido b where d.FK_EncPedido=b.idPedido AND b.FK_Usuario='" + cmb_propietario.Text.ToString() + "' AND b.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-01-1' AND '" + cmb_year.Text.ToString() + "-12-31' and p.idProducto=d.Fk_Producto GROUP BY Fk_Producto", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                                                                                         //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                                                                                                                                                         //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                                                                                                                                                         //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }

            grf_pieSalidas.DataSource = tabla;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (cmb_mes.SelectedIndex == -1 || cmb_year.SelectedIndex == -1 && rdb_Mes.Checked == true)
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            if (cmb_year.SelectedIndex == -1 && rdb_año.Checked==true)
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                btn_barras.Visible = true;
                btn_pie.Visible = true;

                btn_pieSalidas.Visible = false;
                btn_barrasSalidas.Visible = false;
                grf_barrasSalidas.Visible = false;
                grf_pieSalidas.Visible = false;

                if (rdb_año.Checked == false && rdb_Mes.Checked == false)
                {
                    MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    grf_Barras.Visible = true;
                    grf_pie.Visible = false;
                    if (rdb_Mes.Checked == true)
                    {
                        Barras_producto();


                    }
                    else if (rdb_año.Checked == true)
                    {
                        Barras_productoAnual();

                    }
                }
            }
        }

        private void btn_barras_Click(object sender, EventArgs e)
        {
            if (rdb_año.Checked == false && rdb_Mes.Checked == false)
            {
                MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                grf_Barras.Visible = true;
                grf_pie.Visible = false;
                if (rdb_Mes.Checked == true)
                {
                    Barras_producto();


                }
                else if (rdb_año.Checked == true)
                {
                    Barras_productoAnual();

                }
            }            

        }

        private void btn_pie_Click(object sender, EventArgs e)
        {

            if (rdb_año.Checked == false && rdb_Mes.Checked == false)
            {
                MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                grf_Barras.Visible = false;
                grf_pie.Visible = true;
                if (rdb_Mes.Checked == true)
                {
                    pie_producto();


                }
                else if (rdb_año.Checked == true)
                {
                    pie_productoAnual();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_mes.SelectedIndex == -1 || cmb_year.SelectedIndex == -1 && rdb_Mes.Checked==true)
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmb_year.SelectedIndex == -1 && rdb_año.Checked == true)
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                btn_pieSalidas.Visible = true;
                btn_barrasSalidas.Visible = true;
                btn_barras.Visible = false;
                btn_pie.Visible = false;
                grf_Barras.Visible = false;
                grf_pie.Visible = false;


                if (rdb_año.Checked == false && rdb_Mes.Checked == false)
                {
                    MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    grf_barrasSalidas.Visible = true;
                    grf_pieSalidas.Visible = false;
                    if (rdb_Mes.Checked == true)
                    {
                        Barras_productoSalidas();


                    }
                    else if (rdb_año.Checked == true)
                    {
                        Barras_productoAnualSalidas();

                    }
                }
            }
        }

        private void btn_barrasSalidas_Click(object sender, EventArgs e)
        {
            if (rdb_año.Checked == false && rdb_Mes.Checked == false)
            {
                MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            else
            {
                grf_barrasSalidas.Visible = true;
                grf_pieSalidas.Visible = false;
                if (rdb_Mes.Checked == true)
                {
                    Barras_productoSalidas();


                }
                else if (rdb_año.Checked == true)
                {
                    Barras_productoAnualSalidas();

                }
            }
        }

        private void btn_pieSalidas_Click(object sender, EventArgs e)
        {
            if (rdb_año.Checked == false && rdb_Mes.Checked == false)
            {
                MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
            else
            {
                grf_barrasSalidas.Visible = false;
                grf_pieSalidas.Visible = true;
                if (rdb_Mes.Checked == true)
                {
                    pie_productoSalidas();
                }
                else if (rdb_año.Checked == true)
                {
                    pie_productoAnualSalidas();

                }
            }
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            
            radiob();
        }
    }
}
