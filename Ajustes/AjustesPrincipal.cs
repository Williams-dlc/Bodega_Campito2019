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
    public partial class AjustesPrincipal : Form
    {
        public AjustesPrincipal()
        {
            InitializeComponent();
        }

        private void AjustesPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_usuario_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevo = new NuevoUsuario();
            nuevo.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_eliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminar = new EliminarUsuario();
            eliminar.Show();
        }

        private void btn_CambiarPass_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_CambiarPass_Click(object sender, EventArgs e)
        {
            CambiarContraseña pass = new CambiarContraseña();
            pass.Show();
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            NuevoProducto producto = new NuevoProducto();
            producto.Show();
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto eliminar = new EliminarProducto();
            eliminar.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            RestaurarProducto restaurar = new RestaurarProducto();
            restaurar.Show();
        }
    }
}
