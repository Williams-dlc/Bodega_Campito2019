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

namespace Bodega.Reportes
{
    public partial class ReportDevoluciones : Form
    {
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        public ReportDevoluciones()
        {
            InitializeComponent();
            dtp_fecha.Enabled = false;
            btn_aceptarDate.Enabled = false;

            txt_codigo.Enabled = false;
            btn_aceptarCod.Enabled = false;

            cmb_propietario.Enabled = false;
            btn_aceparPro.Enabled = false;
            dtp_FechaPro.Enabled = false;

            cmb_mes.Enabled = false;
            cmb_propietario2.Enabled = false;
            cmb_year.Enabled = false;

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

        public void DevCodigo() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                //OdbcDataAdapter cmd = new OdbcDataAdapter("select * from encabezadoDevoluciones b INNER JOIN DetalleDevoluciones a ON b.idDevoluciones=a.FK_EncDevoluciones WHERE b.idDevoluciones='" + txt_codigo.Text + "' AND a.FK_encDevoluciones= '" + txt_codigo.Text + "'   ", con);//llama a la tabla de inventario para ver stock


                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idDevoluciones as 'Codigo', d.fk_codDetallePrestamo as 'ID', d.idDetalleDevoluciones as 'Codigo2', e.fecha, e.fk_trabajador as 'Encargado', e.fk_propietario as 'Propietario', e.fk_prestador as 'Prestador', e.fk_bodega as 'Bodega', e.entrego, d.fk_producto as 'Cod Producto', p.name as 'Producto', d.cantidad, d.comentario from encabezadodevoluciones e, detalledevoluciones d, producto p where e.idDevoluciones='" + txt_codigo.Text + "' and p.idProducto=d.Fk_Producto and e.idDevoluciones=d.FK_EncDevoluciones", con);
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

                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idDevoluciones as 'Codigo', d.fk_codDetallePrestamo as 'ID', d.idDetalleDevoluciones as 'Codigo2', e.fecha, e.fk_trabajador as 'Encargado', e.fk_propietario as 'Propietario', e.fk_prestador as 'Prestador', e.fk_bodega as 'Bodega', e.entrego, d.fk_producto as 'Cod Producto', p.name as 'Producto', d.cantidad, d.comentario from encabezadodevoluciones e, detalledevoluciones d, producto p where e.idDevoluciones=d.FK_EncDevoluciones and p.idProducto=d.Fk_Producto and e.fecha='" + dtp_fecha.Value.ToString("yyyyMMdd") + "'", con);
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


                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idDevoluciones as 'Codigo', d.fk_codDetallePrestamo as 'ID', d.idDetalleDevoluciones as 'Codigo2', e.fecha, e.fk_trabajador as 'Encargado', e.fk_propietario as 'Propietario', e.fk_prestador as 'Prestador', e.fk_bodega as 'Bodega', e.entrego, d.fk_producto as 'Cod Producto', p.name as 'Producto', d.cantidad, d.comentario from encabezadodevoluciones e, detalledevoluciones d, producto p where e.idDevoluciones=d.FK_EncDevoluciones and p.idProducto=d.Fk_Producto and e.fecha='" + dtp_FechaPro.Value.ToString("yyyyMMdd") + "' and e.FK_Prestador='" + cmb_propietario.Text.ToString() + "'", con);
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

            btn_imprimir.Visible = true;
            btn_imprimirCod.Visible = false;
            btn_imprimirPropietario.Visible = false;
            btn_imprimirMensual.Visible = false;
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

            btn_imprimir.Visible = false;
            btn_imprimirCod.Visible = false;
            btn_imprimirPropietario.Visible = false;
            btn_imprimirMensual.Visible = true;
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

            btn_imprimir.Visible = false;
            btn_imprimirCod.Visible = true;
            btn_imprimirPropietario.Visible = false;
            btn_imprimirMensual.Visible = false;
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

            btn_imprimir.Visible = false;
            btn_imprimirCod.Visible = false;
            btn_imprimirPropietario.Visible = true;
            btn_imprimirMensual.Visible = false;
        }

        private void btn_aceptarDate_Click(object sender, EventArgs e)
        {
            DevFecha();
        }

        private void btn_aceptarCod_Click(object sender, EventArgs e)
        {
            DevCodigo();
        }

        private void btn_aceparPro_Click(object sender, EventArgs e)
        {
            DevPropietario();
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
                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idDevoluciones as 'Codigo', d.fk_codDetallePrestamo as 'ID', d.idDetalleDevoluciones as 'Codigo2', e.fecha, e.fk_trabajador as 'Encargado', e.fk_propietario as 'Propietario', e.fk_prestador as 'Prestador', e.fk_bodega as 'Bodega', e.entrego, d.fk_producto as 'Cod Producto', p.name as 'Producto', d.cantidad, d.comentario from encabezadodevoluciones e, detalledevoluciones d, producto p where e.idDevoluciones=d.FK_EncDevoluciones AND e.FK_Prestador='" + cmb_propietario2.Text.ToString() + "' AND e.Fecha BETWEEN '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-1' AND '" + cmb_year.Text.ToString() + "-" + txt_numero.Text + "-30' and d.Fk_Producto=p.idproducto", con);//llama a la tabla de inventario para ver stock
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

        private void prt_doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgv_Entradas.Height;
            dgv_Entradas.Height = dgv_Entradas.RowCount * dgv_Entradas.RowTemplate.Height * 2;//Imprimir el tama;o del datagridview con todos los resultados 
            Bitmap objbmp = new Bitmap(this.dgv_Entradas.Width, this.dgv_Entradas.Height);
            dgv_Entradas.DrawToBitmap(objbmp, new Rectangle(0, 0, this.dgv_Entradas.Width, this.dgv_Entradas.Height));
            dgv_Entradas.Height = height;

            e.Graphics.DrawImage(objbmp, 20, 150);

            Bitmap objicon = new Bitmap(95, 95);
            pictureBox2.DrawToBitmap(objicon, new Rectangle(0, 0, 200, 200));

            e.Graphics.DrawImage(objicon, 30, 30);

            string titulo = lbl_titulo.Text + "\n" + dtp_fecha.Value.ToString("dd/MM/yyyy");

            e.Graphics.DrawString(titulo, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(175, 50));
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            /*if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                prt_docMensual.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                prt_docMensual.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
            }

            prt_preview.Document = prt_doc;
            prt_preview.ShowDialog();*/

            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = prt_doc;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                prt_doc.Print();

            }
        }

        private void prt_docCod_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgv_Entradas.Height;
            dgv_Entradas.Height = dgv_Entradas.RowCount * dgv_Entradas.RowTemplate.Height * 2;//Imprimir el tama;o del datagridview con todos los resultados 
            Bitmap objbmp = new Bitmap(this.dgv_Entradas.Width, this.dgv_Entradas.Height);
            dgv_Entradas.DrawToBitmap(objbmp, new Rectangle(0, 0, this.dgv_Entradas.Width, this.dgv_Entradas.Height));
            dgv_Entradas.Height = height;

            e.Graphics.DrawImage(objbmp, 20, 150);

            Bitmap objicon = new Bitmap(95, 95);
            pictureBox2.DrawToBitmap(objicon, new Rectangle(0, 0, 200, 200));

            e.Graphics.DrawImage(objicon, 30, 30);

            string titulo = lbl_titulo.Text + "\nCon codigo" + txt_codigo.Text;

            e.Graphics.DrawString(titulo, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(175, 50));
        }

        private void btn_imprimirCod_Click(object sender, EventArgs e)
        {
            /*if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                prt_docMensual.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                prt_docMensual.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
            }
            prt_preview.Document = prt_docCod;
            prt_preview.ShowDialog();*/

            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = prt_docCod;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                prt_docCod.Print();

            }
        }

        private void prt_docPropietario_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgv_Entradas.Height;
            dgv_Entradas.Height = dgv_Entradas.RowCount * dgv_Entradas.RowTemplate.Height * 2;//Imprimir el tama;o del datagridview con todos los resultados 
            Bitmap objbmp = new Bitmap(this.dgv_Entradas.Width, this.dgv_Entradas.Height);
            dgv_Entradas.DrawToBitmap(objbmp, new Rectangle(0, 0, this.dgv_Entradas.Width, this.dgv_Entradas.Height));
            dgv_Entradas.Height = height;

            e.Graphics.DrawImage(objbmp, 20, 150);

            Bitmap objicon = new Bitmap(95, 95);
            pictureBox2.DrawToBitmap(objicon, new Rectangle(0, 0, 200, 200));

            e.Graphics.DrawImage(objicon, 30, 30);

            string titulo = lbl_titulo.Text + "\n De " + cmb_propietario.Text.ToString() + " del " + dtp_FechaPro.Value.ToString("dd/MM/yyyy");

            e.Graphics.DrawString(titulo, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(175, 50));
        }

        private void btn_imprimirPropietario_Click(object sender, EventArgs e)
        {
            /*if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                prt_docMensual.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                prt_docMensual.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
            }
            prt_preview.Document = prt_docPropietario;
            prt_preview.ShowDialog();*/

            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = prt_docPropietario;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                prt_docPropietario.Print();

            }
        }

        private void prt_docMensual_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgv_Entradas.Height;
            dgv_Entradas.Height = dgv_Entradas.RowCount * dgv_Entradas.RowTemplate.Height * 2;//Imprimir el tama;o del datagridview con todos los resultados 
            Bitmap objbmp = new Bitmap(this.dgv_Entradas.Width, this.dgv_Entradas.Height);
            dgv_Entradas.DrawToBitmap(objbmp, new Rectangle(0, 0, this.dgv_Entradas.Width, this.dgv_Entradas.Height));
            dgv_Entradas.Height = height;

            e.Graphics.DrawImage(objbmp, 20, 150);

            Bitmap objicon = new Bitmap(95, 95);
            pictureBox2.DrawToBitmap(objicon, new Rectangle(0, 0, 200, 200));

            e.Graphics.DrawImage(objicon, 30, 30);

            string titulo = lbl_titulo.Text + "\n De " + cmb_propietario2.Text.ToString() + " del mes de " + cmb_mes.Text.ToString() + " del año " + cmb_year.Text.ToString();

            e.Graphics.DrawString(titulo, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(175, 50));
        }

        private void btn_imprimirMensual_Click(object sender, EventArgs e)
        {
            /*if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                prt_docMensual.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                prt_docMensual.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
            }

            prt_preview.Document = prt_docMensual;
            prt_preview.ShowDialog();*/

            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = prt_docMensual;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                prt_docMensual.Print();

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
