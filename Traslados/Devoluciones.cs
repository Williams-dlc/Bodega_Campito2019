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
namespace Bodega.Traslados
{
    public partial class Devoluciones : Form
    {

        CapaDatosBodega conexion = new CapaDatosBodega();
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";

        public Devoluciones()
        {
            InitializeComponent();
          
            cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario.ValueMember = "Nombre";

            cmb_prestador.DataSource = CapaDatosBodega.llenarPrestador();
            cmb_prestador.ValueMember = "Nombre";

            txt_encargado.Text = UserLoginCache.username;
            

            cmb_tipoBodega.DataSource = CapaDatosBodega.llenarBodega();
            cmb_tipoBodega.ValueMember = "tipo_bodega";

            Random r_aleatgenerador = new Random();
            int numero_generado;
            numero_generado = r_aleatgenerador.Next();
            txt_codigo.Text = Convert.ToString(numero_generado);

            txt_idPrestamo.Enabled = false;
            txt_ProductoPrestamo.Enabled = false;
            txt_CantidadPrestamo.Enabled = false;

            btn_continuar.Enabled = false;
            dtp_fecha.Enabled = false;
            txt_encargado.Enabled = false;
            cmb_tipoBodega.Enabled = false;

            txt_producto.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_disponible.Enabled = false;
            txt_codProducto.Enabled = false;
            btn_introducir.Enabled = false;

            btn_ok.Enabled = false;
                    
        }

        public void verPrestamos() {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select a.FK_EncPrestamo, a.Cantidad, a.FK_Producto, a.estado from detalleprestamo a INNER JOIN encabezadoprestamo b ON b.idPrestamo=a.FK_EncPrestamo WHERE b.FK_Prestador='"+ cmb_prestador.Text.ToString() + "' AND b.FK_Propietario = '" +cmb_propietario.Text.ToString()+"' AND a.estado=1", con);//
                                                                                              //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);
            }
            dgv_productos.DataSource = tabla;

        }

        public void disponibilidad() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_producto, cantidad, FK_Propietario from DetalleInventario where FK_Producto= '" + txt_codProducto.Text + "' AND FK_Propietario='" + cmb_prestador.Text.ToString() + "'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                  //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos2.DataSource = tabla;

        }

        public void prestamo()////////////////////////////////////////////////Prestamos pendientes
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from detallePrestamo", con);//llama a la tabla de inventario para ver stock
                                                                                         //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos.DataSource = tabla;
        }

        public void producto()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from producto", con);//llama a la tabla de inventario para ver stock
                                                                                         //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos2.DataSource = tabla;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (cmb_propietario.Text.ToString() == cmb_prestador.Text.ToString())
            {
                MessageBox.Show("El nombre del propietario y el nombre del prestador tiene que ser diferentes", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                verPrestamos();
            
            
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || cmb_prestador.SelectedIndex == -1 || cmb_propietario.SelectedIndex == -1 || cmb_tipoBodega.SelectedIndex == -1)
            {
                MessageBox.Show("llene todos los campos");//lanza mensaje
            }
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC


                    OdbcCommand cmd = new OdbcCommand("insert into EncabezadoInvetarioBodega values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '" + txt_encargado.Text + "', '" + cmb_tipoBodega.Text.ToString() + "')", con);
                    con.Open();//abre la conexion 
                    cmd.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    OdbcCommand cmd1 = new OdbcCommand("insert into EncabezadoDevoluciones values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '" + txt_encargado.Text + "', '" + cmb_propietario.Text.ToString() + "', '" + cmb_prestador.Text.ToString() + "', '" + cmb_tipoBodega.Text.ToString() + "')", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    OdbcCommand cmd2 = new OdbcCommand("insert into EncabezadoDevoluciones_respaldo values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '" + txt_encargado.Text + "', '" + cmb_propietario.Text.ToString() + "', '" + cmb_prestador.Text.ToString() + "', '" + cmb_tipoBodega.Text.ToString() + "')", con);
                    con.Open();//abre la conexion 
                    cmd2.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    cmb_propietario.Enabled = true;
                    txt_detalle.Text = txt_codigo.Text;
                    txt_producto.Enabled = true;
                    txt_cantidad.Enabled = true;
                    txt_disponible.Enabled = true;
                    txt_codProducto.Enabled = true;
                    btn_continuar.Enabled = false;
                    btn_introducir.Enabled = true; ;
                    btn_nuevo.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dgv_productos2.DataSource = CapaDatosBodega.llenarproducto();

            }
        }

        private void dgv_productos2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_producto.Text == "")
            {
                try
                {
                    txt_codProducto.Text = Convert.ToString(dgv_productos2.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                    txt_producto.Text = Convert.ToString(dgv_productos2.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
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

                    txt_disponible.Text = Convert.ToString(dgv_productos2.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid

                    producto();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }



        private void btn_introducir_Click(object sender, EventArgs e)
        {
            int disponible = Convert.ToInt32(txt_disponible.Text);
            int cantidad = Convert.ToInt32(txt_cantidad.Text);
            if (disponible<cantidad)
            {
                MessageBox.Show("No hay suficiente producto para hacer la devolución", "Error de disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_codProducto.Text==txt_ProductoPrestamo.Text && txt_cantidad.Text==txt_CantidadPrestamo.Text) {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd1 = new OdbcCommand("insert into DetalleDevoluciones values (NULL,'" + txt_cantidad.Text + "', '" + txt_detalle.Text + "', '" + txt_codProducto.Text + "')", con);
                    con.Open();//abre la conexion ;
                    cmd1.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd5 = new OdbcCommand("insert into DetalleDevoluciones_respaldo values (NULL,'" + txt_cantidad.Text + "', '" + txt_detalle.Text + "', '" + txt_codProducto.Text + "')", con);
                    con.Open();//abre la conexion ;
                    cmd5.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd2 = new OdbcCommand("update detalleinventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_prestador.Text.ToString() + "' AND FK_producto='" + txt_producto.Text + " '", con);
                    con.Open();//abre la conexion ;               
                    cmd2.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd = new OdbcCommand("update detalleinventario set Cantidad= Cantidad + '" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                    con.Open();//abre la conexion 
                    cmd.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    OdbcCommand cmd6 = new OdbcCommand("update detalleinventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_prestador.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                    con.Open();//abre la conexion ;               
                    cmd6.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd4 = new OdbcCommand("update detalleprestamo set estado=0 where fk_encprestamo= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con);
                    con.Open();//abre la conexion 
                    cmd4.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion


                    OdbcCommand cmd3 = new OdbcCommand("update detalleprestamo_respaldo set estado=0 where fk_encprestamo_resp= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con);
                    con.Open();//abre la conexion 
                    cmd3.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion  //NO SE EJECUTARA ESTE DELETE PORQUE LO USA ENCABEZADO PRESTAMO RESPALDO



                    
                    producto();
                    btn_nuevo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            else
            {
                MessageBox.Show("El campo de producto o de cantidad no coinciden con el prestamo seleccionado, por favor inserte de nuevo los datos del producto", "Error de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_codProducto.Text = "";
                txt_producto.Text = "";
                txt_cantidad.Text = "";
                txt_disponible.Text = "";

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
            txt_cantidad.Text = "";
            txt_disponible.Text = "";

            btn_aceptar.Enabled = true;
            btn_ok.Enabled = false;
            btn_continuar.Enabled = false;
            txt_codProducto.Enabled = false;
            txt_codProducto.Text = "";
            txt_producto.Enabled = false;
            txt_ProductoPrestamo.Text = "";
            txt_cantidad.Enabled = false;
            txt_CantidadPrestamo.Text = "";
            txt_disponible.Enabled = false;
            cmb_tipoBodega.Enabled = false;
            btn_introducir.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseas realizar una nueva devolucion con diferente propietario y prestador?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                nuevaEntrada();
            }
            else if (result == DialogResult.No)
            {
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
            try
            {

                txt_CantidadPrestamo.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_idPrestamo.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_ProductoPrestamo.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[2].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                btn_ok.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            btn_continuar.Enabled = true;
            dtp_fecha.Enabled = true;
            cmb_tipoBodega.Enabled = true;

            txt_producto.Enabled = true;
            txt_cantidad.Enabled = true;
            txt_disponible.Enabled = true;
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            btn_continuar.Enabled = true;
            dtp_fecha.Enabled = true;
            cmb_tipoBodega.Enabled = true;

            btn_aceptar.Enabled = false;
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar esta operación?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //if (dgb_pedido.Rows.Count != 0)
                //{
                    OdbcConnection con2 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd3 = new OdbcCommand("delete from detalledevoluciones_respaldo where fk_encdevoluciones_resp='" + txt_codigo.Text + "'", con2);
                    con2.Open();//abre la conexion 
                    cmd3.ExecuteNonQuery();//ejecuta el query
                    con2.Close();//cierra la conexion

                    OdbcConnection con3 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd4 = new OdbcCommand("delete from detalledevoluciones where fk_encdevoluciones='" + txt_codigo.Text + "'", con3);
                    con3.Open();//abre la conexion 
                    cmd4.ExecuteNonQuery();//ejecuta el query
                    con3.Close();//cierra la conexion

                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd1 = new OdbcCommand("delete from encabezadodevoluciones where idDevoluciones='" + txt_codigo.Text + "'", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    OdbcConnection con1 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd2 = new OdbcCommand("delete from encabezadodevoluciones_respaldo where idDevoluciones='" + txt_codigo.Text + "'", con1);
                    con1.Open();//abre la conexion 
                    cmd2.ExecuteNonQuery();//ejecuta el query
                    con1.Close();//cierra la conexion

                    OdbcConnection con5 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd5 = new OdbcCommand("update detalleprestamo set estado=1 where fk_encprestamo= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con5);
                    con5.Open();//abre la conexion 
                    cmd5.ExecuteNonQuery();//ejecuta el query
                    con5.Close();//cierra la conexion

                    OdbcConnection con6 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd6 = new OdbcCommand("update detalleprestamo_respaldo set estado=1 where fk_encprestamo_resp= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con6);
                    con6.Open();//abre la conexion 
                    cmd6.ExecuteNonQuery();//ejecuta el query
                    con6.Close();//cierra la conexion  //NO SE EJECUTARA ESTE DELETE PORQUE LO USA ENCABEZADO PRESTAMO RESPALDO

                    OdbcCommand cmd7 = new OdbcCommand("update detalleinventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);//elimina de stock lo solicitado
                    con.Open();//abre la conexion ;               
                    cmd7.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd8 = new OdbcCommand("update detalleinventario set Cantidad= Cantidad + '" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_prestador.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                    con.Open();//abre la conexion 
                    cmd8.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion


                nuevaEntrada();
                    
                /*}
                else
                {
                    nuevaEntrada();
                }*/

            }
            else if (result == DialogResult.No)
            {
            }
            
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            txt_producto.Text = "";
            txt_codProducto.Text = "";
            txt_cantidad.Text = "";
            txt_disponible.Text = "";
            producto();
        }
    }
}
