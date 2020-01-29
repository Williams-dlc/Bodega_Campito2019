namespace Bodega.Reportes
{
    partial class ReportDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDevoluciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.cmb_propietario2 = new System.Windows.Forms.ComboBox();
            this.btn_aceptarMes = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.btn_mensual = new System.Windows.Forms.Button();
            this.dgv_Entradas = new System.Windows.Forms.DataGridView();
            this.dtp_FechaPro = new System.Windows.Forms.DateTimePicker();
            this.cmb_propietario = new System.Windows.Forms.ComboBox();
            this.btn_aceparPro = new System.Windows.Forms.Button();
            this.btn_aceptarCod = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_aceptarDate = new System.Windows.Forms.Button();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_distribuidor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_propietario = new System.Windows.Forms.Button();
            this.btn_codigo = new System.Windows.Forms.Button();
            this.btn_Fecha = new System.Windows.Forms.Button();
            this.btn_imprimirMensual = new System.Windows.Forms.Panel();
            this.btn_imprimirPropietario = new System.Windows.Forms.Panel();
            this.btn_imprimirCod = new System.Windows.Forms.Panel();
            this.btn_imprimir = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.prt_doc = new System.Drawing.Printing.PrintDocument();
            this.prt_preview = new System.Windows.Forms.PrintPreviewDialog();
            this.prt_docCod = new System.Drawing.Printing.PrintDocument();
            this.prt_docPropietario = new System.Drawing.Printing.PrintDocument();
            this.prt_docMensual = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 56);
            this.panel1.TabIndex = 154;
            // 
            // btn_salir
            // 
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(822, 17);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(27, 27);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 31;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(284, 12);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(378, 32);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "REPORTE DE DEVOLUCIONES";
            // 
            // cmb_year
            // 
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(268, 177);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(121, 21);
            this.cmb_year.TabIndex = 175;
            // 
            // cmb_propietario2
            // 
            this.cmb_propietario2.FormattingEnabled = true;
            this.cmb_propietario2.Location = new System.Drawing.Point(268, 204);
            this.cmb_propietario2.Name = "cmb_propietario2";
            this.cmb_propietario2.Size = new System.Drawing.Size(121, 21);
            this.cmb_propietario2.TabIndex = 174;
            // 
            // btn_aceptarMes
            // 
            this.btn_aceptarMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_aceptarMes.FlatAppearance.BorderSize = 0;
            this.btn_aceptarMes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_aceptarMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_aceptarMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarMes.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceptarMes.Location = new System.Drawing.Point(287, 236);
            this.btn_aceptarMes.Name = "btn_aceptarMes";
            this.btn_aceptarMes.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarMes.TabIndex = 173;
            this.btn_aceptarMes.Tag = "3";
            this.btn_aceptarMes.Text = "Aceptar";
            this.btn_aceptarMes.UseVisualStyleBackColor = false;
            this.btn_aceptarMes.Click += new System.EventHandler(this.btn_aceptarMes_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(388, 109);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(46, 20);
            this.txt_numero.TabIndex = 172;
            this.txt_numero.Visible = false;
            // 
            // cmb_mes
            // 
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_mes.Location = new System.Drawing.Point(268, 152);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(121, 21);
            this.cmb_mes.TabIndex = 171;
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes.Location = new System.Drawing.Point(311, 64);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(38, 18);
            this.lbl_mes.TabIndex = 170;
            this.lbl_mes.Text = "Mes";
            // 
            // btn_mensual
            // 
            this.btn_mensual.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_mensual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mensual.FlatAppearance.BorderSize = 0;
            this.btn_mensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mensual.Image = ((System.Drawing.Image)(resources.GetObject("btn_mensual.Image")));
            this.btn_mensual.Location = new System.Drawing.Point(296, 85);
            this.btn_mensual.Name = "btn_mensual";
            this.btn_mensual.Size = new System.Drawing.Size(67, 61);
            this.btn_mensual.TabIndex = 169;
            this.btn_mensual.UseVisualStyleBackColor = false;
            this.btn_mensual.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_Entradas
            // 
            this.dgv_Entradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Entradas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Entradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Entradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Entradas.EnableHeadersVisualStyles = false;
            this.dgv_Entradas.Location = new System.Drawing.Point(13, 281);
            this.dgv_Entradas.Name = "dgv_Entradas";
            this.dgv_Entradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv_Entradas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Entradas.Size = new System.Drawing.Size(785, 322);
            this.dgv_Entradas.TabIndex = 168;
            // 
            // dtp_FechaPro
            // 
            this.dtp_FechaPro.Location = new System.Drawing.Point(646, 178);
            this.dtp_FechaPro.Name = "dtp_FechaPro";
            this.dtp_FechaPro.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaPro.TabIndex = 167;
            // 
            // cmb_propietario
            // 
            this.cmb_propietario.FormattingEnabled = true;
            this.cmb_propietario.Location = new System.Drawing.Point(677, 151);
            this.cmb_propietario.Name = "cmb_propietario";
            this.cmb_propietario.Size = new System.Drawing.Size(121, 21);
            this.cmb_propietario.TabIndex = 166;
            // 
            // btn_aceparPro
            // 
            this.btn_aceparPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_aceparPro.FlatAppearance.BorderSize = 0;
            this.btn_aceparPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_aceparPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_aceparPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceparPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceparPro.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceparPro.Location = new System.Drawing.Point(693, 236);
            this.btn_aceparPro.Name = "btn_aceparPro";
            this.btn_aceparPro.Size = new System.Drawing.Size(84, 31);
            this.btn_aceparPro.TabIndex = 165;
            this.btn_aceparPro.Tag = "3";
            this.btn_aceparPro.Text = "Aceptar";
            this.btn_aceparPro.UseVisualStyleBackColor = false;
            this.btn_aceparPro.Click += new System.EventHandler(this.btn_aceparPro_Click);
            // 
            // btn_aceptarCod
            // 
            this.btn_aceptarCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_aceptarCod.FlatAppearance.BorderSize = 0;
            this.btn_aceptarCod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_aceptarCod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_aceptarCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarCod.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceptarCod.Location = new System.Drawing.Point(498, 236);
            this.btn_aceptarCod.Name = "btn_aceptarCod";
            this.btn_aceptarCod.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarCod.TabIndex = 164;
            this.btn_aceptarCod.Tag = "3";
            this.btn_aceptarCod.Text = "Aceptar";
            this.btn_aceptarCod.UseVisualStyleBackColor = false;
            this.btn_aceptarCod.Click += new System.EventHandler(this.btn_aceptarCod_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(472, 177);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(121, 20);
            this.txt_codigo.TabIndex = 163;
            // 
            // btn_aceptarDate
            // 
            this.btn_aceptarDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_aceptarDate.FlatAppearance.BorderSize = 0;
            this.btn_aceptarDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_aceptarDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_aceptarDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptarDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarDate.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceptarDate.Location = new System.Drawing.Point(71, 236);
            this.btn_aceptarDate.Name = "btn_aceptarDate";
            this.btn_aceptarDate.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarDate.TabIndex = 162;
            this.btn_aceptarDate.Tag = "3";
            this.btn_aceptarDate.Text = "Aceptar";
            this.btn_aceptarDate.UseVisualStyleBackColor = false;
            this.btn_aceptarDate.Click += new System.EventHandler(this.btn_aceptarDate_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(12, 177);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 161;
            // 
            // lbl_distribuidor
            // 
            this.lbl_distribuidor.AutoSize = true;
            this.lbl_distribuidor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_distribuidor.Location = new System.Drawing.Point(690, 63);
            this.lbl_distribuidor.Name = "lbl_distribuidor";
            this.lbl_distribuidor.Size = new System.Drawing.Size(90, 18);
            this.lbl_distribuidor.TabIndex = 160;
            this.lbl_distribuidor.Text = "Distribuidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 159;
            this.label3.Text = "Código";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(81, 63);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(54, 18);
            this.lbl_fecha.TabIndex = 158;
            this.lbl_fecha.Text = "Fecha";
            // 
            // btn_propietario
            // 
            this.btn_propietario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_propietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_propietario.FlatAppearance.BorderSize = 0;
            this.btn_propietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_propietario.Image = ((System.Drawing.Image)(resources.GetObject("btn_propietario.Image")));
            this.btn_propietario.Location = new System.Drawing.Point(704, 84);
            this.btn_propietario.Name = "btn_propietario";
            this.btn_propietario.Size = new System.Drawing.Size(67, 61);
            this.btn_propietario.TabIndex = 157;
            this.btn_propietario.UseVisualStyleBackColor = false;
            this.btn_propietario.Click += new System.EventHandler(this.btn_propietario_Click);
            // 
            // btn_codigo
            // 
            this.btn_codigo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_codigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_codigo.FlatAppearance.BorderSize = 0;
            this.btn_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_codigo.Image = ((System.Drawing.Image)(resources.GetObject("btn_codigo.Image")));
            this.btn_codigo.Location = new System.Drawing.Point(498, 84);
            this.btn_codigo.Name = "btn_codigo";
            this.btn_codigo.Size = new System.Drawing.Size(67, 61);
            this.btn_codigo.TabIndex = 156;
            this.btn_codigo.UseVisualStyleBackColor = false;
            this.btn_codigo.Click += new System.EventHandler(this.btn_codigo_Click);
            // 
            // btn_Fecha
            // 
            this.btn_Fecha.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fecha.FlatAppearance.BorderSize = 0;
            this.btn_Fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fecha.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fecha.Image")));
            this.btn_Fecha.Location = new System.Drawing.Point(75, 84);
            this.btn_Fecha.Name = "btn_Fecha";
            this.btn_Fecha.Size = new System.Drawing.Size(67, 61);
            this.btn_Fecha.TabIndex = 155;
            this.btn_Fecha.UseVisualStyleBackColor = false;
            this.btn_Fecha.Click += new System.EventHandler(this.btn_Fecha_Click);
            // 
            // btn_imprimirMensual
            // 
            this.btn_imprimirMensual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimirMensual.BackgroundImage")));
            this.btn_imprimirMensual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_imprimirMensual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_imprimirMensual.Location = new System.Drawing.Point(807, 536);
            this.btn_imprimirMensual.Name = "btn_imprimirMensual";
            this.btn_imprimirMensual.Size = new System.Drawing.Size(42, 38);
            this.btn_imprimirMensual.TabIndex = 179;
            this.btn_imprimirMensual.Visible = false;
            this.btn_imprimirMensual.Click += new System.EventHandler(this.btn_imprimirMensual_Click);
            // 
            // btn_imprimirPropietario
            // 
            this.btn_imprimirPropietario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimirPropietario.BackgroundImage")));
            this.btn_imprimirPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_imprimirPropietario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_imprimirPropietario.Location = new System.Drawing.Point(807, 541);
            this.btn_imprimirPropietario.Name = "btn_imprimirPropietario";
            this.btn_imprimirPropietario.Size = new System.Drawing.Size(42, 38);
            this.btn_imprimirPropietario.TabIndex = 177;
            this.btn_imprimirPropietario.Visible = false;
            this.btn_imprimirPropietario.Click += new System.EventHandler(this.btn_imprimirPropietario_Click);
            // 
            // btn_imprimirCod
            // 
            this.btn_imprimirCod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimirCod.BackgroundImage")));
            this.btn_imprimirCod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_imprimirCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_imprimirCod.Location = new System.Drawing.Point(807, 552);
            this.btn_imprimirCod.Name = "btn_imprimirCod";
            this.btn_imprimirCod.Size = new System.Drawing.Size(42, 38);
            this.btn_imprimirCod.TabIndex = 178;
            this.btn_imprimirCod.Visible = false;
            this.btn_imprimirCod.Click += new System.EventHandler(this.btn_imprimirCod_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.BackgroundImage")));
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_imprimir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_imprimir.Location = new System.Drawing.Point(807, 562);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(42, 38);
            this.btn_imprimir.TabIndex = 176;
            this.btn_imprimir.Visible = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(740, 312);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 180;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // prt_doc
            // 
            this.prt_doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prt_doc_PrintPage);
            // 
            // prt_preview
            // 
            this.prt_preview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prt_preview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prt_preview.ClientSize = new System.Drawing.Size(400, 300);
            this.prt_preview.Enabled = true;
            this.prt_preview.Icon = ((System.Drawing.Icon)(resources.GetObject("prt_preview.Icon")));
            this.prt_preview.Name = "prt_preview";
            this.prt_preview.Visible = false;
            // 
            // prt_docCod
            // 
            this.prt_docCod.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prt_docCod_PrintPage);
            // 
            // prt_docPropietario
            // 
            this.prt_docPropietario.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prt_docPropietario_PrintPage);
            // 
            // prt_docMensual
            // 
            this.prt_docMensual.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prt_docMensual_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ReportDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 615);
            this.Controls.Add(this.btn_imprimirMensual);
            this.Controls.Add(this.btn_imprimirPropietario);
            this.Controls.Add(this.btn_imprimirCod);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.cmb_propietario2);
            this.Controls.Add(this.btn_aceptarMes);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.cmb_mes);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.btn_mensual);
            this.Controls.Add(this.dgv_Entradas);
            this.Controls.Add(this.dtp_FechaPro);
            this.Controls.Add(this.cmb_propietario);
            this.Controls.Add(this.btn_aceparPro);
            this.Controls.Add(this.btn_aceptarCod);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_aceptarDate);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.lbl_distribuidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.btn_propietario);
            this.Controls.Add(this.btn_codigo);
            this.Controls.Add(this.btn_Fecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportDevoluciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.ComboBox cmb_propietario2;
        private System.Windows.Forms.Button btn_aceptarMes;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.Button btn_mensual;
        private System.Windows.Forms.DataGridView dgv_Entradas;
        private System.Windows.Forms.DateTimePicker dtp_FechaPro;
        private System.Windows.Forms.ComboBox cmb_propietario;
        private System.Windows.Forms.Button btn_aceparPro;
        private System.Windows.Forms.Button btn_aceptarCod;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_aceptarDate;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lbl_distribuidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button btn_propietario;
        private System.Windows.Forms.Button btn_codigo;
        private System.Windows.Forms.Button btn_Fecha;
        private System.Windows.Forms.Panel btn_imprimirMensual;
        private System.Windows.Forms.Panel btn_imprimirPropietario;
        private System.Windows.Forms.Panel btn_imprimirCod;
        private System.Windows.Forms.Panel btn_imprimir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Drawing.Printing.PrintDocument prt_doc;
        private System.Windows.Forms.PrintPreviewDialog prt_preview;
        private System.Drawing.Printing.PrintDocument prt_docCod;
        private System.Drawing.Printing.PrintDocument prt_docPropietario;
        private System.Drawing.Printing.PrintDocument prt_docMensual;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}