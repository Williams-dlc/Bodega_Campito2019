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
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Bodega.Traslados
{
    public partial class SalidaProducto : Form
    {
        CapaDatosBodega conexion = new CapaDatosBodega();
        //string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=35.222.102.30;Database=Bodega_Campito;uid=root;pwd=125654campUSER";
        public SalidaProducto()
        {
            InitializeComponent();

            //dgv_producto.DataSource = CapaDatosBodega.llenarproducto();
            //cmb_encargado.DataSource = CapaDatosBodega.llenarTrabajador();//llama la tabla trabajador
            //cmb_encargado.ValueMember = "Nombre";
            txt_encargado.Text= UserLoginCache.username;

            /*cmb_bodega.DataSource = CapaDatosBodega.llenarBodega();
            cmb_bodega.ValueMember = "tipo_bodega";

            cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario.ValueMember = "Nombre";*/
            propietarios();
            bodegas();
            productos();
            

            Random r_aleatgenerador = new Random();
            int numero_generado;
            numero_generado = r_aleatgenerador.Next();
            txt_codigo.Text = Convert.ToString(numero_generado);
            
            txt_cantidad.Enabled = false;
            txt_producto.Enabled = false;
            txt_disponible.Enabled = false;
            btn_aceptar.Enabled = false;
            txt_codProducto.Enabled = false;

            dgv_producto.Enabled = false;
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
            dgv_producto.DataSource = tabla;

        }

        public void bodegas() 

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from Bodega", con);//llama a la tabla de inventario para ver stock
                                                                                       //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }
            cmb_bodega.ValueMember = "tipo_bodega";
            cmb_bodega.DataSource = tabla;

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

            dgv_producto.DataSource = tabla;
        }

        private void btn_prestar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.Show();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || txt_encargado.Text == "" || cmb_propietario.SelectedIndex == -1 || cmb_bodega.SelectedIndex == -1 || txt_Recibio.Text=="")
            {
                MessageBox.Show("llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC


                    OdbcCommand cmd = new OdbcCommand("insert into EncabezadoPedido values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '" + cmb_propietario.Text.ToString() + "', '" + txt_encargado.Text + "', '" + cmb_bodega.Text.ToString() + "', '"+txt_Recibio.Text+"')", con);
                    con.Open();//abre la conexion 
                    cmd.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion
                    txt_producto.Enabled = true;
                    txt_cantidad.Enabled = true;
                    txt_disponible.Enabled = true;
                    btn_aceptar.Enabled = true;
                    btn_continuar.Enabled = false;
                    txt_codProducto.Enabled = true;
                    dgv_producto.Enabled = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                
                txt_detalle.Text = txt_codigo.Text;
            }
        }

        public void disponibilidad() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_producto AS 'idProducto', cantidad, FK_Propietario AS 'Distribuidor' from DetalleInventario where FK_Producto= '"+txt_codProducto.Text+"' AND FK_Propietario='"+cmb_propietario.Text.ToString()+"'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                      //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_producto.DataSource = tabla;
            
        }

        private void dgv_producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_producto.Text == "")
            {
                try
                {
                    txt_codProducto.Text = Convert.ToString(dgv_producto.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                    txt_producto.Text = Convert.ToString(dgv_producto.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
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

                    txt_disponible.Text = Convert.ToString(dgv_producto.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid

                    producto();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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
                MessageBox.Show("llene todos los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                int disponible = Convert.ToInt32(txt_disponible.Text);
                int cantidad = Convert.ToInt32(txt_cantidad.Text);
                if (disponible < cantidad)
                {
                    MessageBox.Show("No hay suficiente producto para hacer la salida de producto", "Error de disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgb_pedido.DataSource = null;
                    dgb_pedido.Refresh();
                }
                else
                {
                    try
                    {
                        OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                        OdbcCommand cmd1 = new OdbcCommand("insert into DetallePedido values (NULL,'" + txt_cantidad.Text + "', '" + txt_detalle.Text + "', '" + txt_codProducto.Text + "','" + txt_comentario.Text + "')", con);
                        con.Open();//abre la conexion ;
                        cmd1.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd2 = new OdbcCommand("update DetalleInventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);//elimina de stock lo solicitado
                        con.Open();//abre la conexion ;               
                        cmd2.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        txt_producto.Text = "";
                        txt_cantidad.Text = "";
                        txt_disponible.Text = "";
                        txt_codProducto.Text = "";
                        txt_comentario.Text = "";
                        producto();

                        btn_imprimirMensual.Visible = true;
                        pedido();//LLenar el datagrid con los productos que se estan operando
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

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
            txt_Recibio.Text = "";
            dgb_pedido.DataSource = null;
            dgb_pedido.Refresh();

            btn_continuar.Enabled = true;
            txt_producto.Enabled = false;
            txt_disponible.Enabled = false;
            txt_cantidad.Enabled = false;
            btn_aceptar.Enabled = false;
            txt_codProducto.Enabled = false;
            dgv_producto.Enabled = false;
            txt_comentario.Text = "";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseas realizar nueva salida con diferente propietario?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                nuevaEntrada();
                btn_printAgain.Visible = false;
                btn_imprimirMensual.Enabled = true;
                btn_imprimirMensual.Visible = false;
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar esta operación?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (dgb_pedido.Rows.Count == 0) { 
                txt_producto.Text = "";
                txt_cantidad.Text = "";

                OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                OdbcCommand cmd1 = new OdbcCommand("delete from EncabezadoPedido where idPedido='" + txt_codigo.Text + "'", con);
                con.Open();//abre la conexion 
                cmd1.ExecuteNonQuery();//ejecuta el query
                con.Close();//cierra la conexion

                

                btn_continuar.Enabled = true;
                txt_producto.Enabled = false;
                txt_cantidad.Enabled = false;
                btn_aceptar.Enabled = false;
                nuevaEntrada();
                }
                else {
                    nuevaEntrada();
                }

            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void cmb_propietario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SalidaProducto_Load(object sender, EventArgs e)
        {
            txt_encargado.Text = UserLoginCache.username;
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            txt_producto.Text = "";
            txt_codProducto.Text = "";
            txt_cantidad.Text = "";
            txt_disponible.Text = "";
            txt_comentario.Text = "";
            producto();
        }

        private void btn_prestamo_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.Show();
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

                    OdbcCommand cmd1 = new OdbcCommand("DELETE FROM DetallePedido WHERE Fk_Producto='" + txt_deleteCod.Text + "' AND FK_EncPedido='" + txt_codigo.Text + "'", con);
                    con.Open();//abre la conexion ;
                    cmd1.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd4 = new OdbcCommand("UPDATE Detalleinventario set cantidad=cantidad + '" + txt_deleteCant.Text + "' WHERE Fk_Producto='" + txt_deleteCod.Text + "' AND FK_Propietario='" + cmb_propietario.Text.ToString() + "'", con);
                    con.Open();//abre la conexion ;
                    cmd4.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    txt_deleteCant.Text = "";
                    txt_deleteCod.Text = "";

                    dgb_pedido.Rows.Remove(dgb_pedido.CurrentRow);
                }
                else if (result == DialogResult.Yes)
                {

                }
            }
        }

        public void facturaSalida()
        {
            
            Facturas.FactSalida salida = new Facturas.FactSalida();
            salida.ShowDialog();

            
            
        }

        public static string FormatedSpace(string val, int fixedLen)

        {
            int len = 0;
            string retVal = string.Empty;
            try

            {
                len = val.Length;
                retVal = val;
                for (int cnt = 0; cnt < fixedLen - len - 1; cnt++)               
{

                    retVal = retVal + " ";
                }

            }
            catch (Exception)

            {
                throw;

            }
            return retVal;

        }

        private Font verdana10Font;
        private StreamReader reader;

        private void btn_imprimirMensual_Click(object sender, EventArgs e)
        {
           
            StreamWriter file = new StreamWriter("Salida"+txt_codigo.Text+".txt");
            file.WriteLine("***SALIDA DE PRODUCTO***");
            file.WriteLine("");
            file.WriteLine("Codigo: "+txt_codigo.Text);
            file.WriteLine("Encargado: " + txt_encargado.Text);
            file.WriteLine("Fecha: " + dtp_fecha.Text.ToString());
            file.WriteLine("Propietario Producto: " + cmb_propietario.Text.ToString());
            file.WriteLine("Recibio: " + txt_Recibio.Text);
            file.WriteLine("");
            file.WriteLine("Producto");

            DataTable table = new DataTable();
            for (int i = 0; i < dgb_pedido.Rows.Count - 1; i++)
            {
                for (int j=0;j<dgb_pedido.Columns.Count; j++)
                {
                    file.Write(dgb_pedido.Rows[i].Cells[j].Value.ToString()+"\n");
                }
                //file.WriteLine("");
            }
            file.WriteLine("\r\r");
            file.WriteLine(DateTime.Now.ToString());
            //MessageBox.Show("Imprimiendo factura");
            file.Close();

            /*PrintDialog pDlg = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Salida" + txt_codigo.Text + ".txt";
            pDlg.Document = pDoc;
            pDlg.AllowSelection = true;
            pDlg.AllowSomePages = true;
            if (pDlg.ShowDialog() == DialogResult.OK)
            {
                reader = new StreamReader("Salida"+txt_codigo.Text+".txt");
                //Create a Verdana font with size 10  
                verdana10Font = new Font("Verdana", 9);
                //Create a PrintDocument object  
                PrintDocument pd = new PrintDocument();
                //Add PrintPage event handler  
                pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
                //Call Print Method  
                pd.Print();
                //Close the reader  
            }
            else
            {
                MessageBox.Show("Print Cancelled");
            }

            if (reader != null)
                reader.Close();*/

            reader = new StreamReader("Salida" + txt_codigo.Text + ".txt");
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

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            

        }

        private void dgv_factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prt_doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            
        }

        private void btn_printAgain_Click(object sender, EventArgs e)
        {
            reader = new StreamReader("Salida" + txt_codigo.Text + ".txt");
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
