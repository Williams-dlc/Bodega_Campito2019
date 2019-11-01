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
using System.Data;
using Common.Cache;

namespace Bodega.Traslados
{
    public partial class EntradaProducto : Form
    {

        CapaDatosBodega conexion = new CapaDatosBodega();
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";


        
        public EntradaProducto()
        {
            
            InitializeComponent();
            txt_producto.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_codProducto.Enabled = false;
            txt_disponible.Enabled = false;
            //cmb_propietario.Enabled = false;
            btn_aceptar.Enabled = false;

            dgv_productos.DataSource = CapaDatosBodega.llenarproducto();
            //dtp_fecha.Format = DateTimePickerFormat.Custom;
            //Display the date as "Mon 27 Feb 2012".  
            //dtp_fecha.CustomFormat = "yyyy MM dd";
            //cmb_encargado.DataSource = CapaDatosBodega.llenarTrabajador();//llama la tabla trabajador
            //cmb_encargado.ValueMember = "Nombre";
            txt_encargado.Text = UserLoginCache.username;

            cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario.ValueMember = "Nombre";

            cmb_tipoBodega.DataSource = CapaDatosBodega.llenarBodega();
            cmb_tipoBodega.ValueMember = "tipo_bodega";

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

        public void disponibilidad() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_producto, cantidad, FK_Propietario from DetalleInventario where FK_Producto= '" + txt_codProducto.Text + "' AND FK_Propietario='" + cmb_propietario.Text.ToString() + "'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                   //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos.DataSource = tabla;

        }



        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
                OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                OdbcCommand cmd = new OdbcCommand("insert into detalleentrada values (null, '" + txt_cantidad.Text + "','" + txt_codigo.Text + "','" + txt_codProducto.Text + "')", con);
                con.Open();//abre la conexion ;
                cmd.ExecuteNonQuery();
                con.Close();//cierra la conexion

                OdbcCommand cmd1 = new OdbcCommand("update detalleinventario set Cantidad= Cantidad + '" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                con.Open();//abre la conexion ;
                cmd1.ExecuteNonQuery();
                con.Close();//cierra la conexion
                //INSERT INTO detalleinventario (idDetalleInventario, FK_EncaDetalle, Fk_Producto, Cantidad, FK_Propietario) SELECT * FROM (SELECT '13','3','104','50','Jorge') AS tmp WHERE NOT EXISTS (SELECT Fk_Producto FROM detalleinventario WHERE Fk_Producto=104) LIMIT 1
                OdbcCommand cmd3 = new OdbcCommand("INSERT INTO detalleinventario (idDetalleInventario, FK_EncaDetalle, Fk_Producto, Cantidad, FK_Propietario) SELECT * FROM (SELECT null,'"+txt_codigo.Text+"','"+txt_codProducto.Text+"','"+txt_cantidad.Text+ "','" + cmb_propietario.Text.ToString() + "') AS tmp WHERE NOT EXISTS (SELECT Fk_Producto FROM detalleinventario WHERE Fk_Producto='"+txt_codProducto.Text+"' and fk_propietario='"+cmb_propietario.Text.ToString()+"') ", con);
                con.Open();//abre la conexion ;
                cmd3.ExecuteNonQuery();
                con.Close();//cierra la conexion

                
                DataTable tabla = new DataTable();
                using (OdbcConnection con1 = new OdbcConnection(ConnStr))
                {
                    con1.Open();

                    OdbcDataAdapter cmd2 = new OdbcDataAdapter("select FK_producto, cantidad from DetalleEntrada where FK_EncEntrada= '" + txt_detalle.Text + "'", con1);//llama a la tabla de inventario para ver stock
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

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || txt_encargado.Text == "")
            {
                MessageBox.Show("llene todos los campos");//lanza mensaje
            }
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd1 = new OdbcCommand("insert into encabezadoentrada values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '"+ cmb_propietario.Text.ToString() + "', '" + txt_encargado.Text + "', '" + cmb_tipoBodega.Text.ToString() + "')", con);
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
                    OdbcDataAdapter cmd = new OdbcDataAdapter("select * from producto", con);//llama a la tabla de inventario para ver stock
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
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Deseas realizar nueva entrada con diferente propietario?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                btn_continuar.Enabled = true;
                nuevaEntrada();
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

                    OdbcCommand cmd1 = new OdbcCommand("delete from encabezadoentrada where idEntrada='" + txt_codigo.Text + "'", con);
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

                    OdbcCommand cmd5 = new OdbcCommand("update detalleinventario set Cantidad='" + txt_disponible.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                    con.Open();//abre la conexion ;
                    cmd5.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd1 = new OdbcCommand("delete from detalleentrada where fk_encEntrada='" + txt_codigo.Text + "'", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion
                    

                    OdbcCommand cmd3 = new OdbcCommand("delete from encabezadoentrada where idEntrada='" + txt_codigo.Text + "'", con);
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
        }

        public void producto()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select idProducto, Name from producto", con);//llama a la tabla de inventario para ver stock
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

                    OdbcCommand cmd1 = new OdbcCommand("DELETE FROM detalleentrada WHERE Fk_Producto='" + txt_deleteCod.Text + "' AND FK_EncEntrada='" + txt_codigo.Text + "'", con);
                    con.Open();//abre la conexion ;
                    cmd1.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd4 = new OdbcCommand("UPDATE detalleinventario set cantidad=cantidad - '" + txt_deleteCant.Text + "' WHERE Fk_Producto='" + txt_deleteCod.Text + "' AND FK_Propietario='" + cmb_propietario.Text.ToString() + "'", con);
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

        private void txt_deleteCant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_deleteCod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
