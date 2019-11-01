using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;

namespace Bodega
{
    public partial class Prinicipal : Form
    {
        public Prinicipal()
        {
            InitializeComponent();
            btn_reportes.Location = new Point(22, 289);


        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            if (pnl_subreportes.Visible == true)
            {
                pnl_subreportes.Visible = false;
                btn_chart.Location = new Point(22, 340);
                pnl_graficas.Location = new Point(0, 340);
                
            }
            else
            {
                btn_reportes.Location = new Point(22, 289);
                pnl_reportes.Location = new Point(0, 289);
                btn_chart.Location = new Point(22, 420);
                pnl_graficas.Location = new Point(0, 420);
                pnl_subreportes.Visible = true;
                pnl_subTraslados.Visible = false;
            }



        }

        private void btn_reportEntradas_Click(object sender, EventArgs e)
        {
            //pnl_subreportes.Visible = false;
            pnl_subTraslados.Visible = false;
            abrirFormHijo(new Reportes.ReportEntradas());
        }

        private void btn_reportSalidas_Click(object sender, EventArgs e)
        {
           // pnl_subreportes.Visible = false;
            pnl_subTraslados.Visible = false;
            abrirFormHijo(new Reportes.ReportSalidas());
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            btn_reportes.Location = new Point(22, 289);
            pnl_reportes.Location = new Point(0, 289);
            btn_chart.Location = new Point(22, 340);
            pnl_graficas.Location = new Point(0, 340);
            pnl_subreportes.Visible = false;
            pnl_subTraslados.Visible = false;
            abrirFormHijo(new Productos.ListadoProducto());
        }

        private void btn_traslados_Click(object sender, EventArgs e)
        {
            if (pnl_subTraslados.Visible == true)
            {
                pnl_subTraslados.Visible = false;
                btn_reportes.Location = new Point(22, 289);
                pnl_reportes.Location = new Point(0, 289);
                btn_chart.Location = new Point(22, 340);
                pnl_graficas.Location = new Point(0, 340);

            }
            else
            {
                pnl_subreportes.Visible = false;
                pnl_subTraslados.Visible = true;
                btn_reportes.Location = new Point(22, 370);
                pnl_reportes.Location = new Point(0, 370);
                btn_chart.Location = new Point(22, 420);
                pnl_graficas.Location = new Point(0, 420);
            }

        }
       

        public void abrirFormHijo(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = formHijo as Form; //no es formulario de nivel superior, si no secundario
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btn_trasladosEntradas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Traslados.EntradaProducto());
        }

        private void btn_trasladosSalidas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Traslados.SalidaProducto());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Prinicipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            //MANEJO DE PERMISOS DE USUARIO
            if (UserLoginCache.Perfil == Cargos.Trabajador)
            {
                pnl_reportes.Visible = false;
                pnl_subreportes.Visible = false;
                btn_reportes.Visible = false;
                pnl_graficas.Visible = false;
                btn_chart.Visible = false;
            }

            if (UserLoginCache.Perfil == Cargos.Administrador)
            {
               
            }
        }

        private void LoadUserData()
        {
            lbl_usuario.Text = UserLoginCache.username;
            
            if (UserLoginCache.Perfil == Cargos.Administrador)
                lbl_perfil.Text = Cargos.Administrador;
            else if (UserLoginCache.Perfil == Cargos.Trabajador)
            {
                lbl_perfil.Text = Cargos.Trabajador;
                
            }
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar sesion? \n Cualquier operacion que se este realizando se perdera.", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void lbl_usuario1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Reportes.ReportesEntradas());
        }

        private void btn_ajustes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Ajustes.AjustesPrincipal());
        }
    }
}
