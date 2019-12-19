namespace Bodega.Ajustes
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_ver = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_perfil = new System.Windows.Forms.ComboBox();
            this.chb_produtos = new System.Windows.Forms.CheckBox();
            this.chb_traslados = new System.Windows.Forms.CheckBox();
            this.chb_reportes = new System.Windows.Forms.CheckBox();
            this.chb_graficas = new System.Windows.Forms.CheckBox();
            this.chb_confAdmin = new System.Windows.Forms.CheckBox();
            this.chb_confTrabajador = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(149)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 31);
            this.panel1.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(374, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(27, 27);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 30;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre de usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(16, 71);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(220, 20);
            this.txt_usuario.TabIndex = 33;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(16, 127);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(220, 20);
            this.txt_contraseña.TabIndex = 34;
            this.txt_contraseña.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // btn_ver
            // 
            this.btn_ver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ver.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver.Image")));
            this.btn_ver.Location = new System.Drawing.Point(242, 127);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(33, 20);
            this.btn_ver.TabIndex = 35;
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aceptar.Location = new System.Drawing.Point(142, 324);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(94, 30);
            this.btn_aceptar.TabIndex = 36;
            this.btn_aceptar.Tag = "3";
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Silver;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.Location = new System.Drawing.Point(266, 324);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 30);
            this.btn_cancelar.TabIndex = 37;
            this.btn_cancelar.Tag = "3";
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tipo de usuario";
            // 
            // cmb_perfil
            // 
            this.cmb_perfil.FormattingEnabled = true;
            this.cmb_perfil.Location = new System.Drawing.Point(16, 187);
            this.cmb_perfil.Name = "cmb_perfil";
            this.cmb_perfil.Size = new System.Drawing.Size(220, 21);
            this.cmb_perfil.TabIndex = 39;
            this.cmb_perfil.SelectedIndexChanged += new System.EventHandler(this.cmb_perfil_SelectedIndexChanged);
            // 
            // chb_produtos
            // 
            this.chb_produtos.AutoSize = true;
            this.chb_produtos.Enabled = false;
            this.chb_produtos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_produtos.Location = new System.Drawing.Point(16, 224);
            this.chb_produtos.Name = "chb_produtos";
            this.chb_produtos.Size = new System.Drawing.Size(107, 25);
            this.chb_produtos.TabIndex = 40;
            this.chb_produtos.Text = "Productos";
            this.chb_produtos.UseVisualStyleBackColor = true;
            // 
            // chb_traslados
            // 
            this.chb_traslados.AutoSize = true;
            this.chb_traslados.Enabled = false;
            this.chb_traslados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_traslados.Location = new System.Drawing.Point(16, 278);
            this.chb_traslados.Name = "chb_traslados";
            this.chb_traslados.Size = new System.Drawing.Size(100, 25);
            this.chb_traslados.TabIndex = 41;
            this.chb_traslados.Text = "Traslados";
            this.chb_traslados.UseVisualStyleBackColor = true;
            // 
            // chb_reportes
            // 
            this.chb_reportes.AutoSize = true;
            this.chb_reportes.Enabled = false;
            this.chb_reportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_reportes.Location = new System.Drawing.Point(142, 224);
            this.chb_reportes.Name = "chb_reportes";
            this.chb_reportes.Size = new System.Drawing.Size(98, 25);
            this.chb_reportes.TabIndex = 42;
            this.chb_reportes.Text = "Reportes";
            this.chb_reportes.UseVisualStyleBackColor = true;
            // 
            // chb_graficas
            // 
            this.chb_graficas.AutoSize = true;
            this.chb_graficas.Enabled = false;
            this.chb_graficas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_graficas.Location = new System.Drawing.Point(142, 278);
            this.chb_graficas.Name = "chb_graficas";
            this.chb_graficas.Size = new System.Drawing.Size(94, 25);
            this.chb_graficas.TabIndex = 43;
            this.chb_graficas.Text = "Graficas";
            this.chb_graficas.UseVisualStyleBackColor = true;
            // 
            // chb_confAdmin
            // 
            this.chb_confAdmin.AutoSize = true;
            this.chb_confAdmin.Enabled = false;
            this.chb_confAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_confAdmin.Location = new System.Drawing.Point(255, 213);
            this.chb_confAdmin.Name = "chb_confAdmin";
            this.chb_confAdmin.Size = new System.Drawing.Size(133, 44);
            this.chb_confAdmin.TabIndex = 44;
            this.chb_confAdmin.Text = "Configuración\r\nAdministrador";
            this.chb_confAdmin.UseVisualStyleBackColor = true;
            // 
            // chb_confTrabajador
            // 
            this.chb_confTrabajador.AutoSize = true;
            this.chb_confTrabajador.Enabled = false;
            this.chb_confTrabajador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_confTrabajador.Location = new System.Drawing.Point(255, 267);
            this.chb_confTrabajador.Name = "chb_confTrabajador";
            this.chb_confTrabajador.Size = new System.Drawing.Size(140, 46);
            this.chb_confTrabajador.TabIndex = 45;
            this.chb_confTrabajador.Text = "Configuración\r\nTrabajador";
            this.chb_confTrabajador.UseVisualStyleBackColor = true;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 366);
            this.Controls.Add(this.chb_confTrabajador);
            this.Controls.Add(this.chb_confAdmin);
            this.Controls.Add(this.chb_graficas);
            this.Controls.Add(this.chb_reportes);
            this.Controls.Add(this.chb_traslados);
            this.Controls.Add(this.chb_produtos);
            this.Controls.Add(this.cmb_perfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoUsuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_perfil;
        private System.Windows.Forms.CheckBox chb_produtos;
        private System.Windows.Forms.CheckBox chb_traslados;
        private System.Windows.Forms.CheckBox chb_reportes;
        private System.Windows.Forms.CheckBox chb_graficas;
        private System.Windows.Forms.CheckBox chb_confAdmin;
        private System.Windows.Forms.CheckBox chb_confTrabajador;
    }
}