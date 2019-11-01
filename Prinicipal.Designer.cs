namespace Bodega
{
    partial class Prinicipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prinicipal));
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.btn_minizar = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Panel();
            this.pnl_subreportes = new System.Windows.Forms.Panel();
            this.btn_reportSalidas = new System.Windows.Forms.Button();
            this.btn_reportEntradas = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_graficas = new System.Windows.Forms.Panel();
            this.pnl_subTraslados = new System.Windows.Forms.Panel();
            this.btn_trasladosEntradas = new System.Windows.Forms.Button();
            this.btn_trasladosSalidas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_chart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ajustes = new System.Windows.Forms.Button();
            this.lbl_perfil1 = new System.Windows.Forms.Label();
            this.lbl_usuario1 = new System.Windows.Forms.Label();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.pnl_traslados = new System.Windows.Forms.Panel();
            this.btn_traslados = new System.Windows.Forms.Button();
            this.pnl_reportes = new System.Windows.Forms.Panel();
            this.pnl_productos = new System.Windows.Forms.Panel();
            this.btn_producto = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.menu.SuspendLayout();
            this.pnl_subreportes.SuspendLayout();
            this.pnl_subTraslados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.pnl_titulo.Controls.Add(this.btn_minizar);
            this.pnl_titulo.Controls.Add(this.btn_salir);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1070, 35);
            this.pnl_titulo.TabIndex = 0;
            this.pnl_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_titulo_Paint);
            this.pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseDown);
            // 
            // btn_minizar
            // 
            this.btn_minizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minizar.Image")));
            this.btn_minizar.Location = new System.Drawing.Point(992, 0);
            this.btn_minizar.Name = "btn_minizar";
            this.btn_minizar.Size = new System.Drawing.Size(33, 35);
            this.btn_minizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minizar.TabIndex = 2;
            this.btn_minizar.TabStop = false;
            this.btn_minizar.Click += new System.EventHandler(this.btn_minizar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(1029, 0);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(37, 35);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 1;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu.Controls.Add(this.pnl_subreportes);
            this.menu.Controls.Add(this.pnl_graficas);
            this.menu.Controls.Add(this.pnl_subTraslados);
            this.menu.Controls.Add(this.btn_chart);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.btn_ajustes);
            this.menu.Controls.Add(this.lbl_perfil1);
            this.menu.Controls.Add(this.lbl_usuario1);
            this.menu.Controls.Add(this.lbl_perfil);
            this.menu.Controls.Add(this.lbl_usuario);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.btn_logOut);
            this.menu.Controls.Add(this.btn_reportes);
            this.menu.Controls.Add(this.pnl_traslados);
            this.menu.Controls.Add(this.btn_traslados);
            this.menu.Controls.Add(this.pnl_reportes);
            this.menu.Controls.Add(this.pnl_productos);
            this.menu.Controls.Add(this.btn_producto);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 35);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(220, 615);
            this.menu.TabIndex = 1;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_Paint);
            // 
            // pnl_subreportes
            // 
            this.pnl_subreportes.Controls.Add(this.btn_reportSalidas);
            this.pnl_subreportes.Controls.Add(this.btn_reportEntradas);
            this.pnl_subreportes.Controls.Add(this.panel6);
            this.pnl_subreportes.Controls.Add(this.panel3);
            this.pnl_subreportes.Location = new System.Drawing.Point(22, 340);
            this.pnl_subreportes.Name = "pnl_subreportes";
            this.pnl_subreportes.Size = new System.Drawing.Size(200, 75);
            this.pnl_subreportes.TabIndex = 3;
            this.pnl_subreportes.Visible = false;
            // 
            // btn_reportSalidas
            // 
            this.btn_reportSalidas.FlatAppearance.BorderSize = 0;
            this.btn_reportSalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_reportSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportSalidas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportSalidas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reportSalidas.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportSalidas.Image")));
            this.btn_reportSalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportSalidas.Location = new System.Drawing.Point(10, 40);
            this.btn_reportSalidas.Name = "btn_reportSalidas";
            this.btn_reportSalidas.Size = new System.Drawing.Size(190, 34);
            this.btn_reportSalidas.TabIndex = 4;
            this.btn_reportSalidas.Text = "Salidas";
            this.btn_reportSalidas.UseVisualStyleBackColor = true;
            this.btn_reportSalidas.Click += new System.EventHandler(this.btn_reportSalidas_Click);
            // 
            // btn_reportEntradas
            // 
            this.btn_reportEntradas.FlatAppearance.BorderSize = 0;
            this.btn_reportEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_reportEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportEntradas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportEntradas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reportEntradas.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportEntradas.Image")));
            this.btn_reportEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportEntradas.Location = new System.Drawing.Point(10, 0);
            this.btn_reportEntradas.Name = "btn_reportEntradas";
            this.btn_reportEntradas.Size = new System.Drawing.Size(190, 34);
            this.btn_reportEntradas.TabIndex = 2;
            this.btn_reportEntradas.Text = "Entradas";
            this.btn_reportEntradas.UseVisualStyleBackColor = true;
            this.btn_reportEntradas.Click += new System.EventHandler(this.btn_reportEntradas_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 34);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 34);
            this.panel3.TabIndex = 1;
            // 
            // pnl_graficas
            // 
            this.pnl_graficas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.pnl_graficas.Location = new System.Drawing.Point(0, 340);
            this.pnl_graficas.Name = "pnl_graficas";
            this.pnl_graficas.Size = new System.Drawing.Size(16, 45);
            this.pnl_graficas.TabIndex = 15;
            // 
            // pnl_subTraslados
            // 
            this.pnl_subTraslados.Controls.Add(this.btn_trasladosEntradas);
            this.pnl_subTraslados.Controls.Add(this.btn_trasladosSalidas);
            this.pnl_subTraslados.Controls.Add(this.panel5);
            this.pnl_subTraslados.Controls.Add(this.panel8);
            this.pnl_subTraslados.Location = new System.Drawing.Point(22, 289);
            this.pnl_subTraslados.Name = "pnl_subTraslados";
            this.pnl_subTraslados.Size = new System.Drawing.Size(200, 75);
            this.pnl_subTraslados.TabIndex = 7;
            this.pnl_subTraslados.Visible = false;
            // 
            // btn_trasladosEntradas
            // 
            this.btn_trasladosEntradas.FlatAppearance.BorderSize = 0;
            this.btn_trasladosEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_trasladosEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trasladosEntradas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trasladosEntradas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_trasladosEntradas.Image = ((System.Drawing.Image)(resources.GetObject("btn_trasladosEntradas.Image")));
            this.btn_trasladosEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trasladosEntradas.Location = new System.Drawing.Point(10, 0);
            this.btn_trasladosEntradas.Name = "btn_trasladosEntradas";
            this.btn_trasladosEntradas.Size = new System.Drawing.Size(190, 34);
            this.btn_trasladosEntradas.TabIndex = 2;
            this.btn_trasladosEntradas.Text = "Entradas";
            this.btn_trasladosEntradas.UseVisualStyleBackColor = true;
            this.btn_trasladosEntradas.Click += new System.EventHandler(this.btn_trasladosEntradas_Click);
            // 
            // btn_trasladosSalidas
            // 
            this.btn_trasladosSalidas.FlatAppearance.BorderSize = 0;
            this.btn_trasladosSalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_trasladosSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trasladosSalidas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trasladosSalidas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_trasladosSalidas.Image = ((System.Drawing.Image)(resources.GetObject("btn_trasladosSalidas.Image")));
            this.btn_trasladosSalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trasladosSalidas.Location = new System.Drawing.Point(10, 40);
            this.btn_trasladosSalidas.Name = "btn_trasladosSalidas";
            this.btn_trasladosSalidas.Size = new System.Drawing.Size(190, 34);
            this.btn_trasladosSalidas.TabIndex = 4;
            this.btn_trasladosSalidas.Text = "Salidas";
            this.btn_trasladosSalidas.UseVisualStyleBackColor = true;
            this.btn_trasladosSalidas.Click += new System.EventHandler(this.btn_trasladosSalidas_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 34);
            this.panel5.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 34);
            this.panel8.TabIndex = 1;
            // 
            // btn_chart
            // 
            this.btn_chart.FlatAppearance.BorderSize = 0;
            this.btn_chart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_chart.Image = ((System.Drawing.Image)(resources.GetObject("btn_chart.Image")));
            this.btn_chart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chart.Location = new System.Drawing.Point(16, 340);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Size = new System.Drawing.Size(204, 45);
            this.btn_chart.TabIndex = 16;
            this.btn_chart.Text = "Graficas";
            this.btn_chart.UseVisualStyleBackColor = true;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.panel2.Location = new System.Drawing.Point(0, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 45);
            this.panel2.TabIndex = 13;
            // 
            // btn_ajustes
            // 
            this.btn_ajustes.FlatAppearance.BorderSize = 0;
            this.btn_ajustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajustes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajustes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ajustes.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajustes.Image")));
            this.btn_ajustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajustes.Location = new System.Drawing.Point(16, 528);
            this.btn_ajustes.Name = "btn_ajustes";
            this.btn_ajustes.Size = new System.Drawing.Size(204, 45);
            this.btn_ajustes.TabIndex = 14;
            this.btn_ajustes.Text = "Ajustes";
            this.btn_ajustes.UseVisualStyleBackColor = true;
            this.btn_ajustes.Click += new System.EventHandler(this.btn_ajustes_Click);
            // 
            // lbl_perfil1
            // 
            this.lbl_perfil1.AutoSize = true;
            this.lbl_perfil1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perfil1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_perfil1.Location = new System.Drawing.Point(118, 78);
            this.lbl_perfil1.Name = "lbl_perfil1";
            this.lbl_perfil1.Size = new System.Drawing.Size(43, 18);
            this.lbl_perfil1.TabIndex = 12;
            this.lbl_perfil1.Text = "Perfil";
            // 
            // lbl_usuario1
            // 
            this.lbl_usuario1.AutoSize = true;
            this.lbl_usuario1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_usuario1.Location = new System.Drawing.Point(118, 37);
            this.lbl_usuario1.Name = "lbl_usuario1";
            this.lbl_usuario1.Size = new System.Drawing.Size(62, 18);
            this.lbl_usuario1.TabIndex = 11;
            this.lbl_usuario1.Text = "Usuario";
            this.lbl_usuario1.Click += new System.EventHandler(this.lbl_usuario1_Click);
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perfil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_perfil.Location = new System.Drawing.Point(118, 100);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(38, 17);
            this.lbl_perfil.TabIndex = 10;
            this.lbl_perfil.Text = "Perfil";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_usuario.Location = new System.Drawing.Point(118, 57);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(54, 17);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 36);
            this.panel1.TabIndex = 4;
            // 
            // btn_logOut
            // 
            this.btn_logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_logOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_logOut.Image")));
            this.btn_logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logOut.Location = new System.Drawing.Point(16, 579);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(204, 36);
            this.btn_logOut.TabIndex = 8;
            this.btn_logOut.Text = "Cerrar Sesion";
            this.btn_logOut.UseVisualStyleBackColor = false;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportes.Image")));
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(16, 289);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(204, 45);
            this.btn_reportes.TabIndex = 4;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // pnl_traslados
            // 
            this.pnl_traslados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.pnl_traslados.Location = new System.Drawing.Point(0, 238);
            this.pnl_traslados.Name = "pnl_traslados";
            this.pnl_traslados.Size = new System.Drawing.Size(16, 45);
            this.pnl_traslados.TabIndex = 5;
            // 
            // btn_traslados
            // 
            this.btn_traslados.FlatAppearance.BorderSize = 0;
            this.btn_traslados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_traslados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_traslados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traslados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_traslados.Image = ((System.Drawing.Image)(resources.GetObject("btn_traslados.Image")));
            this.btn_traslados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traslados.Location = new System.Drawing.Point(16, 238);
            this.btn_traslados.Name = "btn_traslados";
            this.btn_traslados.Size = new System.Drawing.Size(204, 45);
            this.btn_traslados.TabIndex = 6;
            this.btn_traslados.Text = "Traslados";
            this.btn_traslados.UseVisualStyleBackColor = true;
            this.btn_traslados.Click += new System.EventHandler(this.btn_traslados_Click);
            // 
            // pnl_reportes
            // 
            this.pnl_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.pnl_reportes.Location = new System.Drawing.Point(0, 289);
            this.pnl_reportes.Name = "pnl_reportes";
            this.pnl_reportes.Size = new System.Drawing.Size(16, 45);
            this.pnl_reportes.TabIndex = 3;
            // 
            // pnl_productos
            // 
            this.pnl_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.pnl_productos.Location = new System.Drawing.Point(0, 187);
            this.pnl_productos.Name = "pnl_productos";
            this.pnl_productos.Size = new System.Drawing.Size(16, 45);
            this.pnl_productos.TabIndex = 0;
            // 
            // btn_producto
            // 
            this.btn_producto.FlatAppearance.BorderSize = 0;
            this.btn_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_producto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_producto.Image")));
            this.btn_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_producto.Location = new System.Drawing.Point(16, 187);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(204, 45);
            this.btn_producto.TabIndex = 0;
            this.btn_producto.Text = "Productos";
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(850, 615);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // Prinicipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prinicipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prinicipal";
            this.Load += new System.EventHandler(this.Prinicipal_Load);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pnl_subreportes.ResumeLayout(false);
            this.pnl_subTraslados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox btn_minizar;
        private System.Windows.Forms.Panel pnl_productos;
        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Panel pnl_reportes;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_reportEntradas;
        private System.Windows.Forms.Panel pnl_traslados;
        private System.Windows.Forms.Button btn_traslados;
        private System.Windows.Forms.Panel pnl_subreportes;
        private System.Windows.Forms.Button btn_reportSalidas;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnl_subTraslados;
        private System.Windows.Forms.Button btn_trasladosSalidas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_trasladosEntradas;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_perfil;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_perfil1;
        private System.Windows.Forms.Label lbl_usuario1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ajustes;
        private System.Windows.Forms.Panel pnl_graficas;
        private System.Windows.Forms.Button btn_chart;
    }
}