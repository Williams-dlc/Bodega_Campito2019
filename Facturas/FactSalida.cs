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

namespace Bodega.Facturas
{
    public partial class FactSalida : Form
    {
        CapaDatosBodega conexion = new CapaDatosBodega();
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";
        public FactSalida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataSet dst = new DataSet();
            using (OdbcConnection con1 = new OdbcConnection(ConnStr))
            {
                con1.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select e.idpedido, e.fecha, e.fk_usuario, e.fk_trabajador, e.fk_tipo_bodega, e.recibio, d.fk_EncPedido, d.cantidad, d.fk_Producto, d.comentario, p.idProducto, p.name from encabezadopedido e, detallepedido d, producto p where e.idpedido=1311539069 and d.fk_encpedido=1311539069 and p.idProducto= d.Fk_Producto", con1);//llama a la tabla de inventario para ver stock
                //OdbcDataAdapter cmd = new OdbcDataAdapter("select * from producto", con1);                    //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);
                cmd.Fill(dst, "producto");
                Facturas.DataSetSalidas factura = new Facturas.DataSetSalidas();
                factura.Load("@C:\\dataset.rpt");
                factura.SetDataSource(dst);
                crystalReportViewer2.ReportSource = factura;

            }
        }
    }
}
