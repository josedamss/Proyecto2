namespace Proyecto_2
{
    partial class frmproductos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnexcel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgridproduct = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btneli = new System.Windows.Forms.Button();
            this.btnmodi = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridproduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnexcel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dtgridproduct);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(413, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 426);
            this.panel2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(353, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.Color.White;
            this.btnexcel.Location = new System.Drawing.Point(426, 352);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(104, 23);
            this.btnexcel.TabIndex = 13;
            this.btnexcel.Text = "Exportar Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "6 Productos * Verde: Stock normal * Rojo: Stock bajo ( < 5 unidades )";
            // 
            // dtgridproduct
            // 
            this.dtgridproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridproduct.Location = new System.Drawing.Point(17, 81);
            this.dtgridproduct.Name = "dtgridproduct";
            this.dtgridproduct.Size = new System.Drawing.Size(513, 249);
            this.dtgridproduct.TabIndex = 12;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(220)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(455, 29);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Listado de Producto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btneli);
            this.panel1.Controls.Add(this.btnmodi);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.txtstock);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtprecio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 426);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(23, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "ADVERTENCIA: STOCK BAJO - Requiere Reposicion";
            // 
            // btneli
            // 
            this.btneli.BackColor = System.Drawing.Color.Red;
            this.btneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneli.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneli.ForeColor = System.Drawing.Color.White;
            this.btneli.Location = new System.Drawing.Point(113, 382);
            this.btneli.Name = "btneli";
            this.btneli.Size = new System.Drawing.Size(75, 23);
            this.btneli.TabIndex = 10;
            this.btneli.Text = "Eliminar";
            this.btneli.UseVisualStyleBackColor = false;
            // 
            // btnmodi
            // 
            this.btnmodi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(68)))));
            this.btnmodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodi.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodi.ForeColor = System.Drawing.Color.White;
            this.btnmodi.Location = new System.Drawing.Point(194, 382);
            this.btnmodi.Name = "btnmodi";
            this.btnmodi.Size = new System.Drawing.Size(75, 23);
            this.btnmodi.TabIndex = 9;
            this.btnmodi.Text = "Modificar";
            this.btnmodi.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Green;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(26, 382);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(26, 308);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(316, 22);
            this.txtstock.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stock Actual :";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(26, 218);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(316, 22);
            this.txtprecio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio de Venta : *";
            // 
            // txtcat
            // 
            this.txtcat.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcat.Location = new System.Drawing.Point(26, 136);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(316, 22);
            this.txtcat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria: *";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(26, 59);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(316, 22);
            this.txtnombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Producto:  *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Productos";
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmproductos";
            this.Text = "frmproductos";
            this.Load += new System.EventHandler(this.frmproductos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridproduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgridproduct;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btneli;
        private System.Windows.Forms.Button btnmodi;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}