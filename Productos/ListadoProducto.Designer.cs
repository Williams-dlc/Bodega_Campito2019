namespace Bodega.Productos
{
    partial class ListadoProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoProducto));
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbx_Nombre = new System.Windows.Forms.GroupBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.cmb_propietario = new System.Windows.Forms.ComboBox();
            this.gbx_Producto = new System.Windows.Forms.GroupBox();
            this.txt_codProducto = new System.Windows.Forms.TextBox();
            this.btn_aceptarProd = new System.Windows.Forms.Button();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_Prestados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_Nombre.SuspendLayout();
            this.gbx_Producto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_productos
            // 
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.EnableHeadersVisualStyles = false;
            this.dgv_productos.Location = new System.Drawing.Point(27, 159);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv_productos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productos.Size = new System.Drawing.Size(788, 379);
            this.dgv_productos.TabIndex = 0;
            this.dgv_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCTOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 70);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gbx_Nombre
            // 
            this.gbx_Nombre.Controls.Add(this.btn_aceptar);
            this.gbx_Nombre.Controls.Add(this.cmb_propietario);
            this.gbx_Nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Nombre.Location = new System.Drawing.Point(27, 85);
            this.gbx_Nombre.Name = "gbx_Nombre";
            this.gbx_Nombre.Size = new System.Drawing.Size(341, 68);
            this.gbx_Nombre.TabIndex = 3;
            this.gbx_Nombre.TabStop = false;
            this.gbx_Nombre.Text = "Buscar por propietario";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceptar.Location = new System.Drawing.Point(200, 22);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptar.TabIndex = 12;
            this.btn_aceptar.Tag = "3";
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // cmb_propietario
            // 
            this.cmb_propietario.FormattingEnabled = true;
            this.cmb_propietario.Location = new System.Drawing.Point(6, 25);
            this.cmb_propietario.Name = "cmb_propietario";
            this.cmb_propietario.Size = new System.Drawing.Size(188, 26);
            this.cmb_propietario.TabIndex = 0;
            // 
            // gbx_Producto
            // 
            this.gbx_Producto.Controls.Add(this.txt_codProducto);
            this.gbx_Producto.Controls.Add(this.btn_aceptarProd);
            this.gbx_Producto.Controls.Add(this.txt_producto);
            this.gbx_Producto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Producto.Location = new System.Drawing.Point(462, 85);
            this.gbx_Producto.Name = "gbx_Producto";
            this.gbx_Producto.Size = new System.Drawing.Size(343, 68);
            this.gbx_Producto.TabIndex = 4;
            this.gbx_Producto.TabStop = false;
            this.gbx_Producto.Text = "Buscar por producto";
            // 
            // txt_codProducto
            // 
            this.txt_codProducto.Location = new System.Drawing.Point(15, 25);
            this.txt_codProducto.Name = "txt_codProducto";
            this.txt_codProducto.Size = new System.Drawing.Size(36, 26);
            this.txt_codProducto.TabIndex = 14;
            // 
            // btn_aceptarProd
            // 
            this.btn_aceptarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_aceptarProd.FlatAppearance.BorderSize = 0;
            this.btn_aceptarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_aceptarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_aceptarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarProd.ForeColor = System.Drawing.Color.Silver;
            this.btn_aceptarProd.Location = new System.Drawing.Point(248, 20);
            this.btn_aceptarProd.Name = "btn_aceptarProd";
            this.btn_aceptarProd.Size = new System.Drawing.Size(84, 31);
            this.btn_aceptarProd.TabIndex = 13;
            this.btn_aceptarProd.Tag = "3";
            this.btn_aceptarProd.Text = "Aceptar";
            this.btn_aceptarProd.UseVisualStyleBackColor = false;
            this.btn_aceptarProd.Click += new System.EventHandler(this.btn_aceptarProd_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(50, 25);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(163, 26);
            this.txt_producto.TabIndex = 0;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.BackColor = System.Drawing.Color.Orange;
            this.btn_Mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Mostrar.FlatAppearance.BorderSize = 0;
            this.btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mostrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mostrar.Image")));
            this.btn_Mostrar.Location = new System.Drawing.Point(389, 92);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(67, 61);
            this.btn_Mostrar.TabIndex = 5;
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(462, 117);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(165, 19);
            this.lbl_buscar.TabIndex = 6;
            this.lbl_buscar.Text = "Buscar por producto";
            // 
            // btn_Prestados
            // 
            this.btn_Prestados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Prestados.FlatAppearance.BorderSize = 0;
            this.btn_Prestados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Prestados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Prestados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prestados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prestados.ForeColor = System.Drawing.Color.Silver;
            this.btn_Prestados.Location = new System.Drawing.Point(27, 559);
            this.btn_Prestados.Name = "btn_Prestados";
            this.btn_Prestados.Size = new System.Drawing.Size(131, 31);
            this.btn_Prestados.TabIndex = 13;
            this.btn_Prestados.Tag = "3";
            this.btn_Prestados.Text = "Prestados";
            this.btn_Prestados.UseVisualStyleBackColor = false;
            this.btn_Prestados.Click += new System.EventHandler(this.btn_Prestados_Click);
            // 
            // ListadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 615);
            this.Controls.Add(this.btn_Prestados);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.gbx_Producto);
            this.Controls.Add(this.gbx_Nombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoProducto";
            this.Text = "ListadoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_Nombre.ResumeLayout(false);
            this.gbx_Producto.ResumeLayout(false);
            this.gbx_Producto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbx_Nombre;
        private System.Windows.Forms.ComboBox cmb_propietario;
        private System.Windows.Forms.GroupBox gbx_Producto;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_aceptarProd;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_codProducto;
        private System.Windows.Forms.Button btn_Prestados;
    }
}