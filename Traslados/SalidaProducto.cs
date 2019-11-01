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
    public partial class SalidaProducto : Form
    {
        CapaDatosBodega conexion = new CapaDatosBodega();
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";

        public SalidaProducto()
        {
            InitializeComponent();

            dgv_producto.DataSource = CapaDatosBodega.llenarproducto();
            //cmb_encargado.DataSource = CapaDatosBodega.llenarTrabajador();//llama la tabla trabajador
            //cmb_encargado.ValueMember = "Nombre";
            txt_encargado.Text= UserLoginCache.username;

            cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario.ValueMember = "Nombre";

            cmb_bodega.DataSource = CapaDatosBodega.llenarBodega();
            cmb_bodega.ValueMember = "tipo_bodega";

            Random r_aleatgenerador = new Random();
            int numero_generado;
            numero_generado = r_aleatgenerador.Next();
            txt_codigo.Text = Convert.ToString(numero_generado);
            
            txt_cantidad.Enabled = false;
            txt_producto.Enabled = false;
            txt_disponible.Enabled = false;
            btn_aceptar.Enabled = false;
            txt_codProducto.Enabled = false;
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

            dgv_producto.DataSource = tabla;
        }

        private void btn_prestar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.Show();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || txt_encargado.Text == "" || cmb_propietario.SelectedIndex == -1 || cmb_bodega.SelectedIndex == -1)
            {
                MessageBox.Show("llene todos los campos");//lanza mensaje
            }
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC


                    OdbcCommand cmd = new OdbcCommand("insert into encabezadopedido values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '" + cmb_propietario.Text.ToString() + "', '" + txt_encargado.Text + "', '" + cmb_bodega.Text.ToString() + "')", con);
                    con.Open();//abre la conexion 
                    cmd.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion
                    txt_producto.Enabled = true;
                    txt_cantidad.Enabled = true;
                    txt_disponible.Enabled = true;
                    btn_aceptar.Enabled = true;
                    btn_continuar.Enabled = false;
                    txt_codProducto.Enabled = true;


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
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_producto, cantidad, FK_Propietario from DetalleInventario where FK_Producto= '"+txt_codProducto.Text+"' AND FK_Propietario='"+cmb_propietario.Text.ToString()+"'", con);//llama a la tabla de inventario para ver stock
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
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_producto, cantidad from Detallepedido where FK_EncPedido= '" + txt_detalle.Text + "'", con1);//llama a la tabla de inventario para ver stock
                                                                                                                                                                  //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgb_pedido.DataSource = tabla;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            int disponible = Convert.ToInt32(txt_disponible.Text);
            int cantidad = Convert.ToInt32(txt_cantidad.Text);
            if (disponible < cantidad)
            {
                MessageBox.Show("No hay suficiente producto para hacer la salida de producto", "Error de disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgb_pedido.DataSource = null;
                dgb_pedido.Refresh();
            }
            try
            {
                OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                OdbcCommand cmd1 = new OdbcCommand("insert into DetallePedido values (NULL,'" + txt_cantidad.Text + "', '" + txt_detalle.Text + "', '" + txt_codProducto.Text + "')", con);
                con.Open();//abre la conexion ;
                cmd1.ExecuteNonQuery();
                con.Close();//cierra la conexion

                OdbcCommand cmd2 = new OdbcCommand("update detalleinventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_codProducto.Text + " '", con);//elimina de stock lo solicitado
                con.Open();//abre la conexion ;               
                cmd2.ExecuteNonQuery();
                con.Close();//cierra la conexion

                txt_producto.Text = "";
                txt_cantidad.Text = "";
                txt_disponible.Text = "";
                txt_codProducto.Text = "";
                producto();

                pedido();//LLenar el datagrid con los productos que se estan operando
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void nuevaEntrada()
        {
            Random r_aleatgenerador = new Random();//////////////////////////metodo para numero random
            int numero_generado;
            numero_generado = r_aleatgenerador.Next();
            txt_codigo.Text = Convert.ToString(numero_generado);

            txt_detalle.Text = "";
            dgb_pedido.DataSource = null;
            dgb_pedido.Refresh();

            btn_continuar.Enabled = true;
            txt_producto.Enabled = false;
            txt_disponible.Enabled = false;
            txt_cantidad.Enabled = false;
            btn_aceptar.Enabled = false;
            txt_codProducto.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseas realizar nueva salida con diferente propietario?", "Nuevo", MessageBoxButtons.YesNo);

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
            DialogResult result = MessageBox.Show("¿Desea cancelar esta operación?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (dgb_pedido.Rows.Count == 0) { 
                txt_producto.Text = "";
                txt_cantidad.Text = "";

                OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                OdbcCommand cmd1 = new OdbcCommand("delete from encabezadopedido where idPedido='" + txt_codigo.Text + "'", con);
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

                    OdbcCommand cmd1 = new OdbcCommand("DELETE FROM detallepedido WHERE Fk_Producto='" + txt_deleteCod.Text + "' AND FK_EncPedido='" + txt_codigo.Text + "'", con);
                    con.Open();//abre la conexion ;
                    cmd1.ExecuteNonQuery();
                    con.Close();//cierra la conexion

                    OdbcCommand cmd4 = new OdbcCommand("UPDATE detalleinventario set cantidad=cantidad + '" + txt_deleteCant.Text + "' WHERE Fk_Producto='" + txt_deleteCod.Text + "' AND FK_Propietario='" + cmb_propietario.Text.ToString() + "'", con);
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
    }
}
