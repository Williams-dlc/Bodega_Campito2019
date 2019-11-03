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
    public partial class ElliminarSalida : Form
    {
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        public ElliminarSalida()
        {
            InitializeComponent();
        }

        public void SalidasCodigo() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT * FROM encabezadoPedido a INNER JOIN detallepedido b ON a.idPedido=b.FK_encPedido where idPedido='" + txt_codigo.Text + "'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                    //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;

        }

        public void SalidasFecha() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT * FROM encabezadoPedido a INNER JOIN detallepedido b ON a.idPedido=b.FK_encPedido where fecha='" + dtp_fecha.Value.ToString("yyyyMMdd") + "'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                                                      //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;

        }

        public void SalidasPropietario() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("SELECT * FROM encabezadoPedido a INNER JOIN detallepedido b ON a.idPedido=b.FK_encPedido where FK_usuario='" + cmb_propietario.Text.ToString() + "' and fecha='" + dtp_FechaPro.Value.ToString("yyyyMMdd") + "'", con);//llama a la tabla de inventario para ver stock

                cmd.Fill(tabla);

            }

            dgv_Entradas.DataSource = tabla;

        }

        private void btn_aceptarDate_Click(object sender, EventArgs e)
        {
            SalidasFecha();
        }

        private void btn_aceptarCod_Click(object sender, EventArgs e)
        {
            SalidasCodigo();
        }

        private void btn_aceparPro_Click(object sender, EventArgs e)
        {
            SalidasPropietario();
        }
    }
}
