﻿namespace Bodega.Ajustes
{
    partial class EliminarSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarSalida));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_codDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Entradas = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_propietario = new System.Windows.Forms.TextBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_codSalida = new System.Windows.Forms.TextBox();
            this.dtp_FechaPro = new System.Windows.Forms.DateTimePicker();
            this.cmb_propietario = new System.Windows.Forms.ComboBox();
            this.btn_aceparPro = new System.Windows.Forms.Button();
            this.btn_aceptarCod = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_aceptarDate = new System.Windows.Forms.Button();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_propietario = new System.Windows.Forms.Button();
            this.btn_codigo = new System.Windows.Forms.Button();
            this.btn_Fecha = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entradas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(149)))), ((int)(((byte)(171)))));
            this.pnl_titulo.Controls.Add(this.btn_salir);
            this.pnl_titulo.Controls.Add(this.label1);
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(761, 31);
            this.pnl_titulo.TabIndex = 3;
            // 
            // btn_salir
            // 
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(728, 1);
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
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(349, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 92;
            this.label7.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(353, 554);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(121, 20);
            this.txt_cantidad.TabIndex = 91;
            // 
            // txt_codDetalle
            // 
            this.txt_codDetalle.Location = new System.Drawing.Point(138, 554);
            this.txt_codDetalle.Name = "txt_codDetalle";
            this.txt_codDetalle.Size = new System.Drawing.Size(48, 20);
            this.txt_codDetalle.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(487, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 89;
            this.label6.Text = "Distribuidor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(203, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 88;
            this.label5.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 87;
            this.label4.Text = "Codigo";
            // 
            // dgv_Entradas
            // 
            this.dgv_Entradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Entradas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Entradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Entradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Entradas.EnableHeadersVisualStyles = false;
            this.dgv_Entradas.Location = new System.Drawing.Point(32, 247);
            this.dgv_Entradas.Name = "dgv_Entradas";
            this.dgv_Entradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv_Entradas.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Entradas.Size = new System.Drawing.Size(690, 271);
            this.dgv_Entradas.TabIndex = 86;
            this.dgv_Entradas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Entradas_CellDoubleClick);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Silver;
            this.btn_eliminar.Location = new System.Drawing.Point(649, 547);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(99, 31);
            this.btn_eliminar.TabIndex = 85;
            this.btn_eliminar.Tag = "3";
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_propietario
            // 
            this.txt_propietario.Location = new System.Drawing.Point(491, 554);
            this.txt_propietario.Name = "txt_propietario";
            this.txt_propietario.Size = new System.Drawing.Size(121, 20);
            this.txt_propietario.TabIndex = 84;
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(206, 554);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(121, 20);
            this.txt_producto.TabIndex = 83;
            // 
            // txt_codSalida
            // 
            this.txt_codSalida.Location = new System.Drawing.Point(43, 554);
            this.txt_codSalida.Name = "txt_codSalida";
            this.txt_codSalida.Size = new System.Drawing.Size(97, 20);
            this.txt_codSalida.TabIndex = 82;
            // 
            // dtp_FechaPro
            // 
            this.dtp_FechaPro.Location = new System.Drawing.Point(516, 178);
            this.dtp_FechaPro.Name = "dtp_FechaPro";
            this.dtp_FechaPro.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaPro.TabIndex = 81;
            // 
            // cmb_propietario
            // 
            this.cmb_propietario.FormattingEnabled = true;
            this.cmb_propietario.Location = new System.Drawing.Point(547, 151);
            this.cmb_propietario.Name = "cmb_propietario";
            this.cmb_propietario.Size = new System.Drawing.Size(121, 21);
            this.cmb_propietario.TabIndex = 80;
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
            this.btn_aceparPro.Location = new System.Drawing.Point(563, 207);
            this.btn_aceparPro.Name = "btn_aceparPro";
            this.btn_aceparPro.Size = new System.Drawing.Size(84, 31);
            this.btn_aceparPro.TabIndex = 79;
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
            this.btn_aceptarCod.Location = new System.Drawing.Point(330, 207);
            this.btn_aceptarCod.Name = "btn_aceptarCod";
            this.btn_aceptarCod.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarCod.TabIndex = 78;
            this.btn_aceptarCod.Tag = "3";
            this.btn_aceptarCod.Text = "Aceptar";
            this.btn_aceptarCod.UseVisualStyleBackColor = false;
            this.btn_aceptarCod.Click += new System.EventHandler(this.btn_aceptarCod_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(313, 166);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(121, 20);
            this.txt_codigo.TabIndex = 77;
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
            this.btn_aceptarDate.Location = new System.Drawing.Point(92, 207);
            this.btn_aceptarDate.Name = "btn_aceptarDate";
            this.btn_aceptarDate.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarDate.TabIndex = 76;
            this.btn_aceptarDate.Tag = "3";
            this.btn_aceptarDate.Text = "Aceptar";
            this.btn_aceptarDate.UseVisualStyleBackColor = false;
            this.btn_aceptarDate.Click += new System.EventHandler(this.btn_aceptarDate_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(32, 163);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "Propietario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 73;
            this.label3.Text = "Codigo";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(106, 63);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(54, 18);
            this.lbl_fecha.TabIndex = 72;
            this.lbl_fecha.Text = "Fecha";
            // 
            // btn_propietario
            // 
            this.btn_propietario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_propietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_propietario.FlatAppearance.BorderSize = 0;
            this.btn_propietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_propietario.Image = ((System.Drawing.Image)(resources.GetObject("btn_propietario.Image")));
            this.btn_propietario.Location = new System.Drawing.Point(574, 84);
            this.btn_propietario.Name = "btn_propietario";
            this.btn_propietario.Size = new System.Drawing.Size(67, 61);
            this.btn_propietario.TabIndex = 71;
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
            this.btn_codigo.Location = new System.Drawing.Point(339, 84);
            this.btn_codigo.Name = "btn_codigo";
            this.btn_codigo.Size = new System.Drawing.Size(67, 61);
            this.btn_codigo.TabIndex = 70;
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
            this.btn_Fecha.Location = new System.Drawing.Point(100, 84);
            this.btn_Fecha.Name = "btn_Fecha";
            this.btn_Fecha.Size = new System.Drawing.Size(67, 61);
            this.btn_Fecha.TabIndex = 69;
            this.btn_Fecha.UseVisualStyleBackColor = false;
            this.btn_Fecha.Click += new System.EventHandler(this.btn_Fecha_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.Black;
            this.lbl_buscar.Location = new System.Drawing.Point(12, 36);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(112, 21);
            this.lbl_buscar.TabIndex = 68;
            this.lbl_buscar.Text = "Buscar Salida";
            // 
            // EliminarSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 615);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_codDetalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Entradas);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_propietario);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.txt_codSalida);
            this.Controls.Add(this.dtp_FechaPro);
            this.Controls.Add(this.cmb_propietario);
            this.Controls.Add(this.btn_aceparPro);
            this.Controls.Add(this.btn_aceptarCod);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_aceptarDate);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.btn_propietario);
            this.Controls.Add(this.btn_codigo);
            this.Controls.Add(this.btn_Fecha);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElliminarSalida";
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_codDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Entradas;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_propietario;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_codSalida;
        private System.Windows.Forms.DateTimePicker dtp_FechaPro;
        private System.Windows.Forms.ComboBox cmb_propietario;
        private System.Windows.Forms.Button btn_aceparPro;
        private System.Windows.Forms.Button btn_aceptarCod;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_aceptarDate;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button btn_propietario;
        private System.Windows.Forms.Button btn_codigo;
        private System.Windows.Forms.Button btn_Fecha;
        private System.Windows.Forms.Label lbl_buscar;
    }
}