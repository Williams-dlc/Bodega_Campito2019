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
using System.Data.Odbc;
using System.Data;
using Dominio;
using Datos;

namespace Bodega
{
    public partial class Login : Form
    {

        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";

        CapaDatosBodega dc = new CapaDatosBodega();
        //USER user = new USER();

        //TRANSFERIR A OTRO FORM

        public static string T_username;
        public static string T_role;

        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "USUARIO")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text="USUARIO";
                txt_usuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "CONTRASEÑA")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.LightGray;
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "")
            {
                txt_contraseña.Text = "CONTRASEÑA";
                txt_contraseña.ForeColor = Color.DimGray;
                txt_contraseña.UseSystemPasswordChar = false;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            UsuarioModel user = new UsuarioModel();
            DatosUsuario data = new DatosUsuario();
            if (txt_usuario.Text != "USUARIO")
            {
                if (txt_contraseña.Text != "CONTRASEÑA")
                {
                    
                    var validLogin = user.LoginUser(txt_usuario.Text, txt_contraseña.Text);
                    if (validLogin == true)
                    {
                        Prinicipal mainMenu = new Prinicipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += logout;

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta, intente nuevamente",data.user2 );
                        txt_contraseña.Clear();
                        txt_usuario.Focus();
                    }
                }
                else MessageBox.Show("Llene todos los campos");
            }
            else MessageBox.Show("Llene todos los campos");
        }

        

        private void logout(object sender, FormClosedEventArgs e)
        {
            txt_contraseña.Text = "CONTRASEÑA";//Aparecer marca de agua despues de cerrar sesion
            txt_contraseña.UseSystemPasswordChar = false;
            txt_usuario.Text = "USUARIO";//Aparecer marca de agua despues de cerrar sesion
            this.Show();
        }
    }
}
