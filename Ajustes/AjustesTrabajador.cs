using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodega.Ajustes
{
    public partial class AjustesTrabajador : Form
    {
        public AjustesTrabajador()
        {
            InitializeComponent();
        }

        private void btn_eliminarEntrada_Click(object sender, EventArgs e)
        {
            EliminarEntrada entrada = new EliminarEntrada();
            entrada.Show();
        }

        private void btn_EliminarSalida_Click(object sender, EventArgs e)
        {
            EliminarSalida salida = new EliminarSalida();
            salida.Show();
        }

        private void btn_eliminarPrestamo_Click(object sender, EventArgs e)
        {
            EliminarPrestamo prestamo = new EliminarPrestamo();
            prestamo.Show();
        }

        private void btn_eliminarDevolucion_Click(object sender, EventArgs e)
        {
            EliminarDevolucion devolucion = new EliminarDevolucion();
            devolucion.Show();
        }
    }
}
