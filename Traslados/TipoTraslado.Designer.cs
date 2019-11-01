namespace Bodega.Traslados
{
    partial class TipoTraslado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoTraslado));
            this.btn_salida = new System.Windows.Forms.Button();
            this.btn_entrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salida
            // 
            this.btn_salida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_salida.FlatAppearance.BorderSize = 0;
            this.btn_salida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_salida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_salida.Image = ((System.Drawing.Image)(resources.GetObject("btn_salida.Image")));
            this.btn_salida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salida.Location = new System.Drawing.Point(218, 289);
            this.btn_salida.Name = "btn_salida";
            this.btn_salida.Size = new System.Drawing.Size(357, 74);
            this.btn_salida.TabIndex = 4;
            this.btn_salida.Text = "    Salida de Productos";
            this.btn_salida.UseVisualStyleBackColor = false;
            // 
            // btn_entrada
            // 
            this.btn_entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_entrada.FlatAppearance.BorderSize = 0;
            this.btn_entrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(192)))), ((int)(((byte)(227)))));
            this.btn_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_entrada.Image = ((System.Drawing.Image)(resources.GetObject("btn_entrada.Image")));
            this.btn_entrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entrada.Location = new System.Drawing.Point(218, 149);
            this.btn_entrada.Name = "btn_entrada";
            this.btn_entrada.Size = new System.Drawing.Size(358, 74);
            this.btn_entrada.TabIndex = 3;
            this.btn_entrada.Text = "    Entrada de Productos";
            this.btn_entrada.UseVisualStyleBackColor = false;
            this.btn_entrada.Click += new System.EventHandler(this.button1_Click);
            // 
            // TipoTraslado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 615);
            this.Controls.Add(this.btn_salida);
            this.Controls.Add(this.btn_entrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipoTraslado";
            this.Text = "TipoTraslado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salida;
        private System.Windows.Forms.Button btn_entrada;
    }
}