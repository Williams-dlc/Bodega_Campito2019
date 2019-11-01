namespace Bodega.Ajustes
{
    partial class AjustesPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjustesPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ajustes = new System.Windows.Forms.Label();
            this.btn_usuario = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_producto = new System.Windows.Forms.Panel();
            this.lbl_newProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminarUsuario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_EliminarProducto = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CambiarPass = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_ajustes);
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 70);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ajustes
            // 
            this.lbl_ajustes.AutoSize = true;
            this.lbl_ajustes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajustes.Location = new System.Drawing.Point(355, 18);
            this.lbl_ajustes.Name = "lbl_ajustes";
            this.lbl_ajustes.Size = new System.Drawing.Size(200, 32);
            this.lbl_ajustes.TabIndex = 1;
            this.lbl_ajustes.Text = "Configuración";
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_usuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_usuario.BackgroundImage")));
            this.btn_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_usuario.Location = new System.Drawing.Point(83, 105);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(82, 77);
            this.btn_usuario.TabIndex = 4;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            this.btn_usuario.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_usuario_Paint);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(65, 204);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(118, 38);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Ingresar \r\nnuevo Usuario";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_producto
            // 
            this.btn_producto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_producto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_producto.BackgroundImage")));
            this.btn_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_producto.Location = new System.Drawing.Point(521, 105);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(82, 77);
            this.btn_producto.TabIndex = 5;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // lbl_newProduct
            // 
            this.lbl_newProduct.AutoSize = true;
            this.lbl_newProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newProduct.Location = new System.Drawing.Point(498, 204);
            this.lbl_newProduct.Name = "lbl_newProduct";
            this.lbl_newProduct.Size = new System.Drawing.Size(131, 38);
            this.lbl_newProduct.TabIndex = 6;
            this.lbl_newProduct.Text = "Ingresar \r\nnuevo Producto\r\n";
            this.lbl_newProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eliminar\r\nUsuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_eliminarUsuario
            // 
            this.btn_eliminarUsuario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_eliminarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminarUsuario.BackgroundImage")));
            this.btn_eliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_eliminarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_eliminarUsuario.Location = new System.Drawing.Point(232, 105);
            this.btn_eliminarUsuario.Name = "btn_eliminarUsuario";
            this.btn_eliminarUsuario.Size = new System.Drawing.Size(82, 77);
            this.btn_eliminarUsuario.TabIndex = 8;
            this.btn_eliminarUsuario.Click += new System.EventHandler(this.btn_eliminarUsuario_Click);
            this.btn_eliminarUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Eliminar \r\nProducto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_EliminarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProducto.BackgroundImage")));
            this.btn_EliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_EliminarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_EliminarProducto.Location = new System.Drawing.Point(674, 105);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(82, 77);
            this.btn_EliminarProducto.TabIndex = 9;
            this.btn_EliminarProducto.Click += new System.EventHandler(this.btn_EliminarProducto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 57);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cambiar \r\nContraseña de \r\nusuario\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CambiarPass
            // 
            this.btn_CambiarPass.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_CambiarPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CambiarPass.BackgroundImage")));
            this.btn_CambiarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CambiarPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_CambiarPass.Location = new System.Drawing.Point(373, 105);
            this.btn_CambiarPass.Name = "btn_CambiarPass";
            this.btn_CambiarPass.Size = new System.Drawing.Size(82, 77);
            this.btn_CambiarPass.TabIndex = 12;
            this.btn_CambiarPass.Click += new System.EventHandler(this.btn_CambiarPass_Click);
            this.btn_CambiarPass.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_CambiarPass_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Restaurar Producto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(83, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 77);
            this.panel2.TabIndex = 11;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // AjustesPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 615);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_CambiarPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_EliminarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminarUsuario);
            this.Controls.Add(this.lbl_newProduct);
            this.Controls.Add(this.btn_producto);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjustesPrincipal";
            this.Text = "AjustesPrincipal";
            this.Load += new System.EventHandler(this.AjustesPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ajustes;
        private System.Windows.Forms.Panel btn_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Panel btn_producto;
        private System.Windows.Forms.Label lbl_newProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel btn_eliminarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel btn_EliminarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel btn_CambiarPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}