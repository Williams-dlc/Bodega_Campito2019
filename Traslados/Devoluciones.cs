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
using System.Diagnostics;
namespace Bodega.Traslados
{
    public partial class Devoluciones : Form
    {

        CapaDatosBodega conexion = new CapaDatosBodega();
        //string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=35.222.102.30;Database=Bodega_Campito;uid=root;pwd=125654campUSER";
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
                //OdbcDataAdapter cmd = new OdbcDataAdapter("select a.FK_EncPrestamo AS 'Codigo', a.Cantidad, a.FK_Producto AS 'idProducto', a.estado from detalleprestamo a INNER JOIN encabezadoprestamo b ON b.idPrestamo=a.FK_EncPrestamo WHERE b.FK_Prestador='"+ cmb_prestador.Text.ToString() + "' AND b.FK_Propietario = '" +cmb_propietario.Text.ToString()+"' AND a.estado=1", con);//
                //OdbcDataReader queryResults = cmd.ExecuteReader();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idPrestamo as 'Codigo',  d.idDetallePrestamo as 'Codigo2', e.Fecha, e.FK_trabajador as 'Entrego', e.Recibio, d.Cantidad, p.Name as 'Producto', d.FK_Producto as 'Cod Producto', d.comentario from EncabezadoPrestamo e, DetallePrestamo d, Producto p where e.idPrestamo=d.FK_EncPrestamo and e.FK_Prestador='" + cmb_prestador.Text.ToString()+"' AND e.FK_Propietario = '"+cmb_propietario.Text.ToString()+ "' AND p.idProducto=d.Fk_Producto AND d.estado=1", con);
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
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_producto AS 'idProducto', cantidad, FK_Propietario AS 'Distribuidor'from DetalleInventario where FK_Producto= '" + txt_codProducto.Text + "' AND FK_Propietario='" + cmb_prestador.Text.ToString() + "'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                                                  //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_productos2.DataSource = tabla;

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
            if (txt_codigo.Text == "" || cmb_prestador.SelectedIndex == -1 || cmb_propietario.SelectedIndex == -1 || cmb_tipoBodega.SelectedIndex == -1 || txt_entrego.Text=="")
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

                    OdbcCommand cmd1 = new OdbcCommand("insert into EncabezadoDevoluciones values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '" + txt_encargado.Text + "', '" + cmb_propietario.Text.ToString() + "', '" + cmb_prestador.Text.ToString() + "', '" + cmb_tipoBodega.Text.ToString() + "', '"+txt_entrego.Text+"')", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    OdbcCommand cmd2 = new OdbcCommand("insert into EncabezadoDevoluciones_respaldo values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '" + txt_encargado.Text + "', '" + cmb_propietario.Text.ToString() + "', '" + cmb_prestador.Text.ToString() + "', '" + cmb_tipoBodega.Text.ToString() + "', '" + txt_entrego.Text + "')", con);
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

        public void pedido()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con1 = new OdbcConnection(ConnStr))
            {
                con1.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select  p.name, d.Cantidad from DetalleDevoluciones d, Producto p where FK_EncDevoluciones = '" + txt_detalle.Text + "' and p.idProducto=d.Fk_Producto", con1);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                              //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgb_pedido.DataSource = tabla;
        }



        private void btn_introducir_Click(object sender, EventArgs e)
        {
            if (txt_codProducto.Text == "" || txt_cantidad.Text == "" || txt_disponible.Text == "")
                MessageBox.Show("llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int disponible = Convert.ToInt32(txt_disponible.Text);
                int cantidad = Convert.ToInt32(txt_cantidad.Text);
                int cantidadPrestamo = Convert.ToInt32(txt_CantidadPrestamo.Text);

                if (disponible < cantidad)
                {
                    MessageBox.Show("No hay suficiente producto para hacer la devolución", "Error de disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if (cantidad > cantidadPrestamo)
                {
                    MessageBox.Show("La cantidad que ingreso es mayor a la cantidad del prestamo, vuelva a ingresar los datos", "Error de disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_producto.Text = "";
                    txt_codProducto.Text = "";
                    txt_cantidad.Text = "";
                    txt_disponible.Text = "";
                    producto();
                }
                else if (cantidad < cantidadPrestamo)
                {
                    //MessageBox.Show("No hay suficiente producto para hacer la devolución", "Error de disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult result = MessageBox.Show("Deseas realizar una devolucion parcial", "Devolucion parcial", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                        OdbcCommand cmd1 = new OdbcCommand("insert into DetalleDevoluciones values (NULL,'" + txt_cantidad.Text + "', '" + txt_detalle.Text + "', '" + txt_codProducto.Text + "', 'pendiente: " + txt_comentario.Text + "','"+ txt_codDetallePrestamo.Text+ "')", con);
                        con.Open();//abre la conexion ;
                        cmd1.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd5 = new OdbcCommand("insert into DetalleDevoluciones_respaldo values (NULL,'" + txt_cantidad.Text + "', '" + txt_detalle.Text + "', '" + txt_codProducto.Text + "','pendiente: " + txt_comentario.Text + "','" + txt_codDetallePrestamo.Text + "')", con);
                        con.Open();//abre la conexion ;
                        cmd5.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd2 = new OdbcCommand("update DetalleInventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_prestador.Text.ToString() + "' AND FK_producto='" + txt_producto.Text + " '", con);
                        con.Open();//abre la conexion ;               
                        cmd2.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd = new OdbcCommand("update DetalleInventario set Cantidad= Cantidad + '" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                        con.Open();//abre la conexion 
                        cmd.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion

                        OdbcCommand cmd6 = new OdbcCommand("update DetalleInventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_prestador.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                        con.Open();//abre la conexion ;               
                        cmd6.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd4 = new OdbcCommand("update DetallePrestamo set estado=1 where fk_encprestamo= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con);
                        con.Open();//abre la conexion 
                        cmd4.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion


                        OdbcCommand cmd3 = new OdbcCommand("update DetallePrestamo_respaldo set estado=1 where fk_encprestamo_resp= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con);
                        con.Open();//abre la conexion 
                        cmd3.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion  //NO SE EJECUTARA ESTE DELETE PORQUE LO USA ENCABEZADO PRESTAMO RESPALDO

                        OdbcCommand cmd7 = new OdbcCommand("update DetallePrestamo_respaldo set Cantidad='" + txt_CantidadPrestamo.Text + "'- '" + txt_cantidad.Text + "' where fk_encprestamo_resp= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con);
                        con.Open();//abre la conexion 
                        cmd7.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion  //NO SE EJECUTARA ESTE DELETE PORQUE LO USA ENCABEZADO PRESTAMO RESPALDO

                        OdbcCommand cmd8 = new OdbcCommand("update DetallePrestamo set Cantidad='" + txt_CantidadPrestamo.Text + "'- '" + txt_cantidad.Text + "' where fk_encprestamo='" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con);
                        con.Open();//abre la conexion 
                        cmd8.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion  //NO SE EJECUTARA ESTE DELETE PORQUE LO USA ENCABEZADO PRESTAMO RESPALDO

                        OdbcCommand cmd9 = new OdbcCommand("update DetallePrestamo set Comentario= 'Devolucion parcial: \n"+txt_comentario.Text+" "+txt_comentarioPrest.Text+"' where fk_encprestamo='" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con);
                        con.Open();//abre la conexion 
                        cmd9.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion  //NO SE EJECUTARA ESTE DELETE PORQUE LO USA ENCABEZADO PRESTAMO RESPALDO

                        OdbcCommand cmd10 = new OdbcCommand("update DetallePrestamo_respaldo set Comentario= 'Devolucion parcial: " + txt_comentario.Text + " " + txt_comentarioPrest.Text + "' where fk_encprestamo_resp= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con);
                        con.Open();//abre la conexion 
                        cmd10.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion  //NO SE EJECUTARA ESTE DELETE PORQUE LO USA ENCABEZADO PRESTAMO RESPALDO

                        producto();
                        pedido();
                        btn_nuevo.Enabled = true;
                        btn_introducir.Enabled = false;

                        btn_imprimir.Visible = true;

                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("No hay suficiente producto para hacer la devolución", "Error de disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                if (txt_codProducto.Text == txt_ProductoPrestamo.Text && txt_cantidad.Text == txt_CantidadPrestamo.Text)
                {
                    try
                    {
                        OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                        OdbcCommand cmd1 = new OdbcCommand("insert into DetalleDevoluciones values (NULL,'" + txt_cantidad.Text + "', '" + txt_detalle.Text + "', '" + txt_codProducto.Text + "','" + txt_comentario.Text + "','" + txt_codDetallePrestamo.Text + "')", con);
                        con.Open();//abre la conexion ;
                        cmd1.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd5 = new OdbcCommand("insert into DetalleDevoluciones_respaldo values (NULL,'" + txt_cantidad.Text + "', '" + txt_detalle.Text + "', '" + txt_codProducto.Text + "','" + txt_comentario.Text + "','" + txt_codDetallePrestamo.Text + "')", con);
                        con.Open();//abre la conexion ;
                        cmd5.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd2 = new OdbcCommand("update DetalleInventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_prestador.Text.ToString() + "' AND FK_producto='" + txt_producto.Text + " '", con);
                        con.Open();//abre la conexion ;               
                        cmd2.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd = new OdbcCommand("update DetalleInventario set Cantidad= Cantidad + '" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                        con.Open();//abre la conexion 
                        cmd.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion

                        OdbcCommand cmd6 = new OdbcCommand("update DetalleInventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_prestador.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
                        con.Open();//abre la conexion ;               
                        cmd6.ExecuteNonQuery();
                        con.Close();//cierra la conexion

                        OdbcCommand cmd4 = new OdbcCommand("update DetallePrestamo set estado=0 where fk_encprestamo= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con);
                        con.Open();//abre la conexion 
                        cmd4.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion


                        OdbcCommand cmd3 = new OdbcCommand("update DetallePrestamo_respaldo set estado=0 where fk_encprestamo_resp= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con);
                        con.Open();//abre la conexion 
                        cmd3.ExecuteNonQuery();//ejecuta el query
                        con.Close();//cierra la conexion  //NO SE EJECUTARA ESTE DELETE PORQUE LO USA ENCABEZADO PRESTAMO RESPALDO

                        MessageBox.Show("Se ha realizado la devolucion con exito", "Devolucion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                        btn_imprimir.Visible = true;
                        producto();
                        pedido();
                        btn_nuevo.Enabled = true;
                        btn_introducir.Enabled = false;
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
                    txt_comentario.Text = "";

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
            txt_cantidad.Text = "";
            txt_disponible.Text = "";
            txt_entrego.Text = "";

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
            txt_entrego.Enabled = false;
            txt_comentario.Enabled = false;
            txt_comentario.Text = "";
            dgb_pedido.DataSource = null;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseas realizar una nueva devolucion con diferente propietario y prestador?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                nuevaEntrada();
                btn_printAgain.Visible = false;
                btn_imprimir.Enabled = true;
                btn_imprimir.Visible = false;
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

                txt_CantidadPrestamo.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[5].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_idPrestamo.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_ProductoPrestamo.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[7].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_comentarioPrest.Text= Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[8].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                txt_codDetallePrestamo.Text= Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
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
            txt_entrego.Enabled = true;
            txt_comentario.Enabled = true;

            btn_aceptar.Enabled = false;
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar esta operación reciente?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //if (dgb_pedido.Rows.Count != 0)
                //{
                    OdbcConnection con2 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd3 = new OdbcCommand("delete from DetalleDevoluciones_respaldo where fk_encdevoluciones_resp='" + txt_codigo.Text + "'", con2);
                    con2.Open();//abre la conexion 
                    cmd3.ExecuteNonQuery();//ejecuta el query
                    con2.Close();//cierra la conexion

                    OdbcConnection con3 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd4 = new OdbcCommand("delete from DetalleDevoluciones where fk_encdevoluciones='" + txt_codigo.Text + "'", con3);
                    con3.Open();//abre la conexion 
                    cmd4.ExecuteNonQuery();//ejecuta el query
                    con3.Close();//cierra la conexion

                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd1 = new OdbcCommand("delete from EncabezadoDevoluciones where idDevoluciones='" + txt_codigo.Text + "'", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    OdbcConnection con1 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd2 = new OdbcCommand("delete from EncabezadoDevoluciones_respaldo where idDevoluciones='" + txt_codigo.Text + "'", con1);
                    con1.Open();//abre la conexion 
                    cmd2.ExecuteNonQuery();//ejecuta el query
                    con1.Close();//cierra la conexion

                    OdbcConnection con5 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd5 = new OdbcCommand("update DetallePrestamo set estado=1 where fk_encprestamo= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con5);
                    con5.Open();//abre la conexion 
                    cmd5.ExecuteNonQuery();//ejecuta el query
                    con5.Close();//cierra la conexion

                    OdbcConnection con6 = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd6 = new OdbcCommand("update DetallePrestamo_respaldo set estado=1 where fk_encprestamo_resp= '" + txt_idPrestamo.Text + "' and fk_producto= '" + txt_ProductoPrestamo.Text + "'", con6);
                    con6.Open();//abre la conexion 
                    cmd6.ExecuteNonQuery();//ejecuta el query
                    con6.Close();//cierra la conexion  //NO SE EJECUTARA ESTE DELETE PORQUE LO USA ENCABEZADO PRESTAMO RESPALDO

                    OdbcCommand cmd7 = new OdbcCommand("update DetalleInventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);//elimina de stock lo solicitado
                    con.Open();//abre la conexion ;               
                    cmd7.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd8 = new OdbcCommand("update DetalleInventario set Cantidad= Cantidad + '" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_prestador.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);
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
        private Font verdana10Font;
        private StreamReader reader;
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("devolucion" + txt_codigo.Text + ".txt");
            file.WriteLine("***DEVOLUCIÓN DE PRODUCTO***");
            file.WriteLine("");
            file.WriteLine("Codigo: " + txt_codigo.Text);
            file.WriteLine("Encargado: " + txt_encargado.Text);
            file.WriteLine("Fecha: " + dtp_fecha.Text.ToString());
            file.WriteLine("Propietario Producto: " + cmb_propietario.Text.ToString());
            file.WriteLine("Devolvio: " + cmb_prestador.Text.ToString() );
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

            /*PrintDialog pDlg = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "devolucion" + txt_codigo.Text + ".txt";
            pDlg.Document = pDoc;
            pDlg.AllowSelection = true;
            pDlg.AllowSomePages = true;
            if (pDlg.ShowDialog() == DialogResult.OK)
            {

            reader = new StreamReader("devolucion" + txt_codigo.Text + ".txt");
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
            reader = new StreamReader("devolucion" + txt_codigo.Text + ".txt");
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

            btn_imprimir.Enabled = false;
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
            reader = new StreamReader("devolucion" + txt_codigo.Text + ".txt");
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
