namespace Bodega.Reportes
{
    partial class ReportEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportEntradas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_Fecha = new System.Windows.Forms.Button();
            this.btn_codigo = new System.Windows.Forms.Button();
            this.btn_propietario = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_aceptarDate = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_aceptarCod = new System.Windows.Forms.Button();
            this.btn_aceparPro = new System.Windows.Forms.Button();
            this.cmb_propietario = new System.Windows.Forms.ComboBox();
            this.dtp_FechaPro = new System.Windows.Forms.DateTimePicker();
            this.btn_imprimir = new System.Windows.Forms.Panel();
            this.prt_doc = new System.Drawing.Printing.PrintDocument();
            this.prt_preview = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_imprimirCod = new System.Windows.Forms.Panel();
            this.btn_imprimirPropietario = new System.Windows.Forms.Panel();
            this.prt_docCod = new System.Drawing.Printing.PrintDocument();
            this.prt_docPropietario = new System.Drawing.Printing.PrintDocument();
            this.dgv_Entradas = new System.Windows.Forms.DataGridView();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_aceptarMes = new System.Windows.Forms.Button();
            this.cmb_propietario2 = new System.Windows.Forms.ComboBox();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.btn_imprimirMensual = new System.Windows.Forms.Panel();
            this.prt_docMensual = new System.Drawing.Printing.PrintDocument();
            this.cmb_printer = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btn_ReportePrestamos = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entradas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 70);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(289, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(307, 32);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "REPORTE DE ENTRADAS";
            // 
            // btn_Fecha
            // 
            this.btn_Fecha.BackColor = System.Drawing.Color.Orange;
            this.btn_Fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fecha.FlatAppearance.BorderSize = 0;
            this.btn_Fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fecha.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fecha.Image")));
            this.btn_Fecha.Location = new System.Drawing.Point(74, 93);
            this.btn_Fecha.Name = "btn_Fecha";
            this.btn_Fecha.Size = new System.Drawing.Size(67, 61);
            this.btn_Fecha.TabIndex = 6;
            this.btn_Fecha.UseVisualStyleBackColor = false;
            this.btn_Fecha.Click += new System.EventHandler(this.btn_Fecha_Click);
            // 
            // btn_codigo
            // 
            this.btn_codigo.BackColor = System.Drawing.Color.Orange;
            this.btn_codigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_codigo.FlatAppearance.BorderSize = 0;
            this.btn_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_codigo.Image = ((System.Drawing.Image)(resources.GetObject("btn_codigo.Image")));
            this.btn_codigo.Location = new System.Drawing.Point(480, 93);
            this.btn_codigo.Name = "btn_codigo";
            this.btn_codigo.Size = new System.Drawing.Size(67, 61);
            this.btn_codigo.TabIndex = 7;
            this.btn_codigo.UseVisualStyleBackColor = false;
            this.btn_codigo.Click += new System.EventHandler(this.btn_codigo_Click);
            // 
            // btn_propietario
            // 
            this.btn_propietario.BackColor = System.Drawing.Color.Orange;
            this.btn_propietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_propietario.FlatAppearance.BorderSize = 0;
            this.btn_propietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_propietario.Image = ((System.Drawing.Image)(resources.GetObject("btn_propietario.Image")));
            this.btn_propietario.Location = new System.Drawing.Point(696, 93);
            this.btn_propietario.Name = "btn_propietario";
            this.btn_propietario.Size = new System.Drawing.Size(67, 61);
            this.btn_propietario.TabIndex = 8;
            this.btn_propietario.UseVisualStyleBackColor = false;
            this.btn_propietario.Click += new System.EventHandler(this.btn_propietario_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(80, 72);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(54, 18);
            this.lbl_fecha.TabIndex = 9;
            this.lbl_fecha.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Propietario";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(28, 188);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 12;
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
            this.btn_aceptarDate.Location = new System.Drawing.Point(74, 239);
            this.btn_aceptarDate.Name = "btn_aceptarDate";
            this.btn_aceptarDate.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarDate.TabIndex = 14;
            this.btn_aceptarDate.Tag = "3";
            this.btn_aceptarDate.Text = "Aceptar";
            this.btn_aceptarDate.UseVisualStyleBackColor = false;
            this.btn_aceptarDate.Click += new System.EventHandler(this.btn_aceptarDate_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(462, 188);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(121, 20);
            this.txt_codigo.TabIndex = 15;
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
            this.btn_aceptarCod.Location = new System.Drawing.Point(475, 239);
            this.btn_aceptarCod.Name = "btn_aceptarCod";
            this.btn_aceptarCod.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarCod.TabIndex = 16;
            this.btn_aceptarCod.Tag = "3";
            this.btn_aceptarCod.Text = "Aceptar";
            this.btn_aceptarCod.UseVisualStyleBackColor = false;
            this.btn_aceptarCod.Click += new System.EventHandler(this.btn_aceptarCod_Click);
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
            this.btn_aceparPro.Location = new System.Drawing.Point(692, 239);
            this.btn_aceparPro.Name = "btn_aceparPro";
            this.btn_aceparPro.Size = new System.Drawing.Size(84, 31);
            this.btn_aceparPro.TabIndex = 18;
            this.btn_aceparPro.Tag = "3";
            this.btn_aceparPro.Text = "Aceptar";
            this.btn_aceparPro.UseVisualStyleBackColor = false;
            this.btn_aceparPro.Click += new System.EventHandler(this.btn_aceparPro_Click);
            // 
            // cmb_propietario
            // 
            this.cmb_propietario.FormattingEnabled = true;
            this.cmb_propietario.Location = new System.Drawing.Point(669, 160);
            this.cmb_propietario.Name = "cmb_propietario";
            this.cmb_propietario.Size = new System.Drawing.Size(121, 21);
            this.cmb_propietario.TabIndex = 20;
            // 
            // dtp_FechaPro
            // 
            this.dtp_FechaPro.Location = new System.Drawing.Point(638, 188);
            this.dtp_FechaPro.Name = "dtp_FechaPro";
            this.dtp_FechaPro.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaPro.TabIndex = 21;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.BackgroundImage")));
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_imprimir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_imprimir.Location = new System.Drawing.Point(796, 540);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(42, 38);
            this.btn_imprimir.TabIndex = 22;
            this.btn_imprimir.Visible = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            this.btn_imprimir.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_imprimir_Paint);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(796, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btn_imprimirCod
            // 
            this.btn_imprimirCod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimirCod.BackgroundImage")));
            this.btn_imprimirCod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_imprimirCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_imprimirCod.Location = new System.Drawing.Point(796, 530);
            this.btn_imprimirCod.Name = "btn_imprimirCod";
            this.btn_imprimirCod.Size = new System.Drawing.Size(42, 38);
            this.btn_imprimirCod.TabIndex = 23;
            this.btn_imprimirCod.Visible = false;
            this.btn_imprimirCod.Click += new System.EventHandler(this.btn_imprimirCod_Click);
            // 
            // btn_imprimirPropietario
            // 
            this.btn_imprimirPropietario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimirPropietario.BackgroundImage")));
            this.btn_imprimirPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_imprimirPropietario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_imprimirPropietario.Location = new System.Drawing.Point(796, 519);
            this.btn_imprimirPropietario.Name = "btn_imprimirPropietario";
            this.btn_imprimirPropietario.Size = new System.Drawing.Size(42, 38);
            this.btn_imprimirPropietario.TabIndex = 23;
            this.btn_imprimirPropietario.Visible = false;
            this.btn_imprimirPropietario.Click += new System.EventHandler(this.btn_imprimirPropietario_Click);
            // 
            // prt_docCod
            // 
            this.prt_docCod.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prt_docCod_PrintPage);
            // 
            // prt_docPropietario
            // 
            this.prt_docPropietario.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prt_docPropietario_PrintPage);
            // 
            // dgv_Entradas
            // 
            this.dgv_Entradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Entradas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Entradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Entradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Entradas.EnableHeadersVisualStyles = false;
            this.dgv_Entradas.Location = new System.Drawing.Point(28, 276);
            this.dgv_Entradas.Name = "dgv_Entradas";
            this.dgv_Entradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Entradas.RowHeadersVisible = false;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv_Entradas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Entradas.Size = new System.Drawing.Size(762, 292);
            this.dgv_Entradas.TabIndex = 24;
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes.Location = new System.Drawing.Point(326, 72);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(38, 18);
            this.lbl_mes.TabIndex = 26;
            this.lbl_mes.Text = "Mes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(311, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 61);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cmb_mes.Location = new System.Drawing.Point(283, 160);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(121, 21);
            this.cmb_mes.TabIndex = 27;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(403, 134);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(46, 20);
            this.txt_numero.TabIndex = 28;
            this.txt_numero.Visible = false;
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
            this.btn_aceptarMes.Location = new System.Drawing.Point(295, 239);
            this.btn_aceptarMes.Name = "btn_aceptarMes";
            this.btn_aceptarMes.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarMes.TabIndex = 30;
            this.btn_aceptarMes.Tag = "3";
            this.btn_aceptarMes.Text = "Aceptar";
            this.btn_aceptarMes.UseVisualStyleBackColor = false;
            this.btn_aceptarMes.Click += new System.EventHandler(this.btn_aceptarMes_Click);
            // 
            // cmb_propietario2
            // 
            this.cmb_propietario2.FormattingEnabled = true;
            this.cmb_propietario2.Location = new System.Drawing.Point(283, 212);
            this.cmb_propietario2.Name = "cmb_propietario2";
            this.cmb_propietario2.Size = new System.Drawing.Size(121, 21);
            this.cmb_propietario2.TabIndex = 31;
            // 
            // cmb_year
            // 
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(283, 185);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(121, 21);
            this.cmb_year.TabIndex = 32;
            // 
            // btn_imprimirMensual
            // 
            this.btn_imprimirMensual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimirMensual.BackgroundImage")));
            this.btn_imprimirMensual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_imprimirMensual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_imprimirMensual.Location = new System.Drawing.Point(796, 514);
            this.btn_imprimirMensual.Name = "btn_imprimirMensual";
            this.btn_imprimirMensual.Size = new System.Drawing.Size(42, 38);
            this.btn_imprimirMensual.TabIndex = 39;
            this.btn_imprimirMensual.Visible = false;
            this.btn_imprimirMensual.Click += new System.EventHandler(this.btn_imprimirMensual_Click);
            // 
            // prt_docMensual
            // 
            this.prt_docMensual.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prt_docMensual_PrintPage);
            // 
            // cmb_printer
            // 
            this.cmb_printer.FormattingEnabled = true;
            this.cmb_printer.Location = new System.Drawing.Point(669, 584);
            this.cmb_printer.Name = "cmb_printer";
            this.cmb_printer.Size = new System.Drawing.Size(121, 21);
            this.cmb_printer.TabIndex = 40;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btn_ReportePrestamos
            // 
            this.btn_ReportePrestamos.BackColor = System.Drawing.Color.Orange;
            this.btn_ReportePrestamos.FlatAppearance.BorderSize = 0;
            this.btn_ReportePrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_ReportePrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ReportePrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReportePrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportePrestamos.ForeColor = System.Drawing.Color.Black;
            this.btn_ReportePrestamos.Location = new System.Drawing.Point(28, 574);
            this.btn_ReportePrestamos.Name = "btn_ReportePrestamos";
            this.btn_ReportePrestamos.Size = new System.Drawing.Size(200, 31);
            this.btn_ReportePrestamos.TabIndex = 49;
            this.btn_ReportePrestamos.Tag = "3";
            this.btn_ReportePrestamos.Text = "Reporte Prestamos";
            this.btn_ReportePrestamos.UseVisualStyleBackColor = false;
            this.btn_ReportePrestamos.Click += new System.EventHandler(this.btn_ReportePrestamos_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ReportEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 615);
            this.Controls.Add(this.btn_ReportePrestamos);
            this.Controls.Add(this.cmb_printer);
            this.Controls.Add(this.btn_imprimirMensual);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.cmb_propietario2);
            this.Controls.Add(this.btn_aceptarMes);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.cmb_mes);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Entradas);
            this.Controls.Add(this.btn_imprimirPropietario);
            this.Controls.Add(this.btn_imprimirCod);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.dtp_FechaPro);
            this.Controls.Add(this.cmb_propietario);
            this.Controls.Add(this.btn_aceparPro);
            this.Controls.Add(this.btn_aceptarCod);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_aceptarDate);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.btn_propietario);
            this.Controls.Add(this.btn_codigo);
            this.Controls.Add(this.btn_Fecha);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportEntradas";
            this.Text = "ReportEntradas";
            this.Load += new System.EventHandler(this.ReportEntradas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_Fecha;
        private System.Windows.Forms.Button btn_codigo;
        private System.Windows.Forms.Button btn_propietario;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Button btn_aceptarDate;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_aceptarCod;
        private System.Windows.Forms.Button btn_aceparPro;
        private System.Windows.Forms.ComboBox cmb_propietario;
        private System.Windows.Forms.DateTimePicker dtp_FechaPro;
        private System.Windows.Forms.Panel btn_imprimir;
        private System.Drawing.Printing.PrintDocument prt_doc;
        private System.Windows.Forms.PrintPreviewDialog prt_preview;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel btn_imprimirCod;
        private System.Windows.Forms.Panel btn_imprimirPropietario;
        private System.Drawing.Printing.PrintDocument prt_docCod;
        private System.Drawing.Printing.PrintDocument prt_docPropietario;
        private System.Windows.Forms.DataGridView dgv_Entradas;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_aceptarMes;
        private System.Windows.Forms.ComboBox cmb_propietario2;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.Panel btn_imprimirMensual;
        private System.Drawing.Printing.PrintDocument prt_docMensual;
        private System.Windows.Forms.ComboBox cmb_printer;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btn_ReportePrestamos;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}