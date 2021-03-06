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
using Common.Cache;
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using System.Diagnostics;
using Datos;

namespace Bodega.Traslados
{
    public partial class EntradaProducto : Form
    {

        CapaDatosBodega conexion = new CapaDatosBodega();
        

        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=35.222.102.30;Database=Bodega_Campito;uid=root;pwd=125654campUSER";
       

        
        public EntradaProducto()
        {
            
            InitializeComponent();
            txt_producto.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_codProducto.Enabled = false;
            txt_disponible.Enabled = false;
            //cmb_propietario.Enabled = false;
            btn_aceptar.Enabled = false;

            //dgv_productos.DataSource = CapaDatosBodega.llenarproducto();
            productos();
            txt_encargado.Text = UserLoginCache.username;
            propietarios();
            
            bodegas();

            dgv_productos.Enabled = false;

            Random r_aleatgenerador = new Random();
            int numero_generado;
            numero_generado = r_aleatgenerador.Next();
            txt_codigo.Text = Convert.ToString(numero_generado);
        }

        public void abrirFormHijo(object formHijo)
        {
            Prinicipal prin = new Prinicipal();
            if (prin.panelContenedor.Controls.Count > 0)
                prin.panelContenedor.Controls.RemoveAt(0);

            Form fh = formHijo as Form; //no es formulario de nivel superior, si no secundario
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            prin.panelContenedor.Controls.Add(fh);
            prin.panelContenedor.Tag = fh;
            fh.Show();
            
        }

        public void productos()

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select idProducto, name AS 'Nombre' from Producto where estado=1", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                                                               //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }
            dgv_productos.DataSource = tabla;

        }

        public void bodegas() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from Bodega", con);//llama a la tabla de inventario para ver stock
                                                                                                    //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }
            cmb_tipoBodega.ValueMember = "tipo_bodega";
            cmb_tipoBodega.DataSource = tabla;

        }

        public void propietarios() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

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

        public void disponibilidad() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_producto AS 'Producto', cantidad AS 'Cantidad', FK_Propietario AS 'Distribuidor' from DetalleInventario where FK_Producto= '" + txt_codProducto.Text + "' AND FK_Propietario='" + cmb_propietario.Text.ToString() + "'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                   //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos.DataSource = tabla;

        }

        public void pedido()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con1 = new OdbcConnection(ConnStr))
            {
                con1.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select  p.name, d.Cantidad from DetallePedido d, Producto p where FK_EncPedido = '" + txt_detalle.Text + "' and p.idProducto=d.Fk_Producto", con1);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                              //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgb_pedido.DataSource = tabla;
        }



        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_codProducto.Text == "" || txt_cantidad.Text == "" || txt_disponible.Text == "")
                MessageBox.Show("llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                    OdbcCommand cmd = new OdbcCommand("insert into DetalleEntrada values (null, '" + txt_cantidad.Text + "','" + txt_codigo.Text + "','" + txt_codProducto.Text + "','" + txt_comentario.Text + "')", con);
                    con.Open();//abre la conexion ;
                    cmd.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd1 = new OdbcCommand("update DetalleInventario set Cantidad= Cantidad + '" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                    con.Open();//abre la conexion ;
                    cmd1.ExecuteNonQuery();
                    con.Close();//cierra la conexion
                                //INSERT INTO detalleinventario (idDetalleInventario, FK_EncaDetalle, Fk_Producto, Cantidad, FK_Propietario) SELECT * FROM (SELECT '13','3','104','50','Jorge') AS tmp WHERE NOT EXISTS (SELECT Fk_Producto FROM detalleinventario WHERE Fk_Producto=104) LIMIT 1


                    OdbcCommand cmd3 = new OdbcCommand("INSERT INTO DetalleInventario (idDetalleInventario, FK_EncaDetalle, Fk_Producto, Cantidad, FK_Propietario) SELECT * FROM (SELECT null,'" + txt_codigo.Text + "','" + txt_codProducto.Text + "','" + txt_cantidad.Text + "','" + cmb_propietario.Text.ToString() + "') AS tmp WHERE NOT EXISTS (SELECT Fk_Producto FROM DetalleInventario WHERE Fk_Producto='" + txt_codProducto.Text + "' and fk_propietario='" + cmb_propietario.Text.ToString() + "') ", con);
                    con.Open();//abre la conexion ;
                    cmd3.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    btn_imprimirMensual.Visible = true;
                    DataTable tabla = new DataTable();
                    using (OdbcConnection con1 = new OdbcConnection(ConnStr))
                    {
                        con1.Open();

                        OdbcDataAdapter cmd2 = new OdbcDataAdapter("select p.name, d.Cantidad from DetalleEntrada d, Producto p where FK_EncEntrada= '" + txt_detalle.Text + "' and p.idProducto=d.Fk_Producto ", con1);//ver salida de producto
                                                                                                                                                                                           //OdbcDataReader queryResults = cmd.ExecuteReader();
                        cmd2.Fill(tabla);

                    }

                    dgb_pedido.DataSource = tabla;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || txt_encargado.Text == "" || txt_Entrego.Text=="")
            {
                MessageBox.Show("llene todos los campos");//lanza mensaje
            }
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd1 = new OdbcCommand("insert into EncabezadoEntrada values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '"+ cmb_propietario.Text.ToString() + "', '" + txt_encargado.Text + "', '" + cmb_tipoBodega.Text.ToString() + "','"+txt_Entrego.Text+"')", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    OdbcCommand cmd = new OdbcCommand("insert into EncabezadoInvetarioBodega values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '" + txt_encargado.Text + "', '" + cmb_tipoBodega.Text.ToString() + "')", con);
                    con.Open();//abre la conexion 
                    cmd.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion
                    txt_producto.Enabled = true;
                    txt_cantidad.Enabled = true;
                    cmb_propietario.Enabled = false;
                    cmb_tipoBodega.Enabled = false;
                    txt_Entrego.Enabled = false;
                    btn_aceptar.Enabled = true;
                    btn_continuar.Enabled = false;
                    txt_codProducto.Enabled = true;
                    txt_disponible.Enabled = true;
                    dgv_productos.Enabled = true;
                    txt_producto.Text = "";
                    txt_cantidad.Text = "";
                    txt_codProducto.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                DataTable tabla = new DataTable();
                using (OdbcConnection con = new OdbcConnection(ConnStr))
                {
                    con.Open();
                    OdbcDataAdapter cmd = new OdbcDataAdapter("select idProducto, name AS 'Nombre' from Producto where estado=1", con);//llama a la tabla de inventario para ver stock
                                                                                                  //OdbcDataReader queryResults = cmd.ExecuteReader();
                    cmd.Fill(tabla);

                }

                dgv_productos.DataSource = tabla;
                txt_detalle.Text = txt_codigo.Text;
            }
        }

        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            


            if (txt_producto.Text == "")
            {
                try
                {
                    txt_codProducto.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                    txt_producto.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                    disponibilidad();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {

                    txt_disponible.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid

                    producto();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

        public void nuevaEntrada()
        {
            Random r_aleatgenerador = new Random();//////////////////////////metodo para numero random
            int numero_generado;
            numero_generado = r_aleatgenerador.Next();
            txt_codigo.Text = Convert.ToString(numero_generado);

            txt_detalle.Text = "";
            txt_codProducto.Text = "";
            txt_producto.Text = "";
            txt_disponible.Text = "";
            txt_cantidad.Text = "";
            txt_Entrego.Text = "";
     
            btn_continuar.Enabled = true;
            txt_producto.Enabled = false;
            txt_cantidad.Enabled = false;
            cmb_propietario.Enabled = true;
            cmb_tipoBodega.Enabled = true;
            dgb_pedido.DataSource = null;
            dgb_pedido.Refresh();
            txt_codProducto.Enabled = false;
            txt_disponible.Enabled = false;
            dgv_productos.Enabled = false;
            txt_Entrego.Enabled = true;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Deseas realizar nueva entrada con diferente propietario?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                btn_continuar.Enabled = true;
                nuevaEntrada();
                btn_printAgain.Visible = false;
                btn_imprimirMensual.Enabled = true;
                btn_imprimirMensual.Visible = false;
            }
            else if (result == DialogResult.No)
            {
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Devoluciones dev = new Devoluciones();
            dev.Show();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar esta operación?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (dgb_pedido.Rows.Count == 0)
                {                    

                     OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC                

                    OdbcCommand cmd1 = new OdbcCommand("delete from EncabezadoEntrada where idEntrada='" + txt_codigo.Text + "'", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    

                    txt_producto.Text = "";
                    txt_cantidad.Text = "";
                    txt_codProducto.Text = "";
                    txt_disponible.Text = "";

                    btn_continuar.Enabled = true;
                    txt_producto.Enabled = false;
                    txt_cantidad.Enabled = false;
                    txt_disponible.Enabled = false;
                    btn_aceptar.Enabled = false;
                    dgv_productos.Enabled = false;
                    
                    abrirFormHijo(new Productos.ListadoProducto());
                    nuevaEntrada();
                }
                else if(dgb_pedido.Rows.Count != 0)
                {

                    
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd5 = new OdbcCommand("update DetalleInventario set Cantidad='" + txt_disponible.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                    con.Open();//abre la conexion ;
                    cmd5.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd1 = new OdbcCommand("delete from DetalleEntrada where fk_encEntrada='" + txt_codigo.Text + "'", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion
                    

                    OdbcCommand cmd3 = new OdbcCommand("delete from EncabezadoEntrada where idEntrada='" + txt_codigo.Text + "'", con);
                    con.Open();//abre la conexion 
                    cmd3.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    txt_producto.Text = "";
                    txt_cantidad.Text = "";
                    txt_codProducto.Text = "";
                    txt_disponible.Text = "";

                    nuevaEntrada();

                    

                    btn_continuar.Enabled = true;
                    txt_producto.Enabled = false;
                    txt_cantidad.Enabled = false;
                    btn_aceptar.Enabled = false;
                }

            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void EntradaProducto_Load(object sender, EventArgs e)
        {
            txt_encargado.Text = UserLoginCache.username;
            foreach (string printer in PrinterSettings.InstalledPrinters)
                cmb_printer.Items.Add(printer);
        }

        public void producto()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select idProducto, Name AS 'Nombre' from Producto where estado=1", con);//llama a la tabla de inventario para ver stock
                                                                                         //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos.DataSource = tabla;
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            txt_producto.Text = "";
            txt_codProducto.Text = "";
            txt_cantidad.Text = "";
            txt_disponible.Text = "";
            producto();
        }

        private void btn_prestamo_Click(object sender, EventArgs e)
        {
            Devoluciones dev = new Devoluciones();
            dev.Show();
        }

        private void dgb_pedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_deleteCod.Text = Convert.ToString(dgb_pedido.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_deleteCant.Text = Convert.ToString(dgb_pedido.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_deleteCant.Text == "" || txt_deleteCod.Text == "")
            {
                MessageBox.Show("No se ha seleccionado algun articulo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea cancelar el producto '" + txt_deleteCod.Text + "' con la cantidad de '" + txt_deleteCant.Text + "'?", "Nuevo", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd1 = new OdbcCommand("DELETE FROM DetalleEntrada WHERE Fk_Producto='" + txt_deleteCod.Text + "' AND FK_EncEntrada='" + txt_codigo.Text + "'", con);
                    con.Open();//abre la conexion ;
                    cmd1.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd4 = new OdbcCommand("UPDATE DetalleInventario set cantidad=cantidad - '" + txt_deleteCant.Text + "' WHERE Fk_Producto='" + txt_deleteCod.Text + "' AND FK_Propietario='" + cmb_propietario.Text.ToString() + "'", con);
                    con.Open();//abre la conexion ;
                    cmd4.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    txt_deleteCant.Text = "";
                    txt_deleteCod.Text = "";

                    dgb_pedido.Rows.Remove(dgb_pedido.CurrentRow);
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }

        private void txt_deleteCant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_deleteCod_TextChanged(object sender, EventArgs e)
        {

        }


        private Font verdana10Font;
        private StreamReader reader;
        private void btn_imprimirMensual_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("Entrada" + txt_codigo.Text + ".txt");
            file.WriteLine("***ENTRADA DE PRODUCTO***");
            file.WriteLine("");
            file.WriteLine("Codigo: " + txt_codigo.Text);
            file.WriteLine("Encargado: " + txt_encargado.Text);
            file.WriteLine("Fecha: " + dtp_fecha.Text.ToString());
            file.WriteLine("Propietario Producto: " + cmb_propietario.Text.ToString());
            file.WriteLine("Entrego: " + txt_Entrego.Text);
            file.WriteLine("");
            file.WriteLine("Producto");

            DataTable table = new DataTable();
            for (int i = 0; i < dgb_pedido.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgb_pedido.Columns.Count; j++)
                {
                    file.Write(dgb_pedido.Rows[i].Cells[j].Value.ToString() + "\n");
                }
                //file.WriteLine("");
            }
            file.WriteLine("\r\r");
            file.WriteLine(DateTime.Now.ToString());
            //MessageBox.Show("Imprimiendo factura");
            file.Close();

            PrintDialog pDlg = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Entrada" + txt_codigo.Text + ".txt";
            pDlg.Document = pDoc;
            //pDlg.AllowSelection = true;
            //pDlg.AllowSomePages = true;
            /*PrintDialog printDialog1 = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Entrada" + txt_codigo.Text + ".txt";
            printDialog1.Document = pDoc;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                //print

            }
            btn_imprimirMensual.Enabled = false;
            btn_printAgain.Visible = true;*/
            

            reader = new StreamReader("Entrada" + txt_codigo.Text + ".txt");
            //Create a Verdana font with size 10  
            verdana10Font = new Font("Verdana", 9);
            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();
            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                pd.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                pd.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
            }
            //Call Print Method  
            pd.Print();
            //Close the reader  
            if (reader != null)
                reader.Close();
            btn_imprimirMensual.Enabled = false;
            btn_printAgain.Visible = true;
        }

        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            //Get the Graphics object  
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs  
            float leftMargin = 0;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font  
            linesPerPage = ppeArgs.MarginBounds.Height / verdana10Font.GetHeight(g);
            //Now read lines one by one, using StreamReader  
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position  
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                //Draw text  
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                //Move to next line  
                count++;
            }
            //If PrintPageEventArgs has more pages to print  
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }

        private void btn_printAgain_Click(object sender, EventArgs e)
        {
            /*PrintDialog pDlg = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Entrada" + txt_codigo.Text + ".txt";
            pDlg.Document = pDoc;
            pDlg.AllowSelection = true;
            pDlg.AllowSomePages = true;*/
            reader = new StreamReader("Entrada" + txt_codigo.Text + ".txt");
            //Create a Verdana font with size 10  
            verdana10Font = new Font("Verdana", 9);
            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();
            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                pd.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                pd.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
            }
            //Call Print Method  
            pd.Print();
            //Close the reader  
            if (reader != null)
                reader.Close();
        }
    }
}
