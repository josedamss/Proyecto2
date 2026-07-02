namespace Proyecto_2
{
    partial class frmclientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lberrorcorreo = new System.Windows.Forms.Label();
            this.lberrorcell = new System.Windows.Forms.Label();
            this.btneli = new System.Windows.Forms.Button();
            this.btnmodi = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtdirecc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexcel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscarcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lberrornombre = new System.Windows.Forms.Label();
            this.lberrordirecc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lberrordirecc);
            this.panel1.Controls.Add(this.lberrornombre);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lberrorcorreo);
            this.panel1.Controls.Add(this.lberrorcell);
            this.panel1.Controls.Add(this.btneli);
            this.panel1.Controls.Add(this.btnmodi);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.txtdirecc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtcorreo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcell);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 480);
            this.panel1.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(26, 73);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(316, 22);
            this.txtid.TabIndex = 15;
            this.txtid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "ID Cliente *";
            // 
            // lberrorcorreo
            // 
            this.lberrorcorreo.AutoSize = true;
            this.lberrorcorreo.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrorcorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lberrorcorreo.Location = new System.Drawing.Point(28, 331);
            this.lberrorcorreo.Name = "lberrorcorreo";
            this.lberrorcorreo.Size = new System.Drawing.Size(0, 14);
            this.lberrorcorreo.TabIndex = 13;
            // 
            // lberrorcell
            // 
            this.lberrorcell.AutoSize = true;
            this.lberrorcell.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrorcell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lberrorcell.Location = new System.Drawing.Point(94, 196);
            this.lberrorcell.Name = "lberrorcell";
            this.lberrorcell.Size = new System.Drawing.Size(0, 14);
            this.lberrorcell.TabIndex = 11;
            // 
            // btneli
            // 
            this.btneli.BackColor = System.Drawing.Color.Red;
            this.btneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneli.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneli.ForeColor = System.Drawing.Color.White;
            this.btneli.Location = new System.Drawing.Point(112, 438);
            this.btneli.Name = "btneli";
            this.btneli.Size = new System.Drawing.Size(75, 23);
            this.btneli.TabIndex = 10;
            this.btneli.Text = "Eliminar";
            this.btneli.UseVisualStyleBackColor = false;
            this.btneli.Click += new System.EventHandler(this.btneli_Click);
            // 
            // btnmodi
            // 
            this.btnmodi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(68)))));
            this.btnmodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodi.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodi.ForeColor = System.Drawing.Color.White;
            this.btnmodi.Location = new System.Drawing.Point(193, 438);
            this.btnmodi.Name = "btnmodi";
            this.btnmodi.Size = new System.Drawing.Size(75, 23);
            this.btnmodi.TabIndex = 9;
            this.btnmodi.Text = "Modificar";
            this.btnmodi.UseVisualStyleBackColor = false;
            this.btnmodi.Click += new System.EventHandler(this.btnmodi_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Green;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(31, 438);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtdirecc
            // 
            this.txtdirecc.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdirecc.Location = new System.Drawing.Point(31, 397);
            this.txtdirecc.Name = "txtdirecc";
            this.txtdirecc.Size = new System.Drawing.Size(316, 22);
            this.txtdirecc.TabIndex = 8;
            this.txtdirecc.TextChanged += new System.EventHandler(this.txtdirecc_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(31, 306);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(316, 22);
            this.txtcorreo.TabIndex = 6;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo Electronico: *";
            // 
            // txtcell
            // 
            this.txtcell.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcell.Location = new System.Drawing.Point(26, 225);
            this.txtcell.Name = "txtcell";
            this.txtcell.Size = new System.Drawing.Size(316, 22);
            this.txtcell.TabIndex = 4;
            this.txtcell.TextChanged += new System.EventHandler(this.txtcell_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono *";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(26, 148);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(316, 22);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Cliente";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnexcel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.txtbuscarcliente);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(416, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 426);
            this.panel2.TabIndex = 2;
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.Color.White;
            this.btnexcel.Location = new System.Drawing.Point(405, 371);
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
            this.label7.Location = new System.Drawing.Point(29, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "5 Clientes Registrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 249);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(220)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(434, 59);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarcliente.Location = new System.Drawing.Point(32, 59);
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.Size = new System.Drawing.Size(389, 22);
            this.txtbuscarcliente.TabIndex = 11;
            this.txtbuscarcliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarcliente_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Listado de Clientes";
            // 
            // lberrornombre
            // 
            this.lberrornombre.AutoSize = true;
            this.lberrornombre.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrornombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lberrornombre.Location = new System.Drawing.Point(161, 120);
            this.lberrornombre.Name = "lberrornombre";
            this.lberrornombre.Size = new System.Drawing.Size(0, 14);
            this.lberrornombre.TabIndex = 16;
            // 
            // lberrordirecc
            // 
            this.lberrordirecc.AutoSize = true;
            this.lberrordirecc.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrordirecc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lberrordirecc.Location = new System.Drawing.Point(103, 367);
            this.lberrordirecc.Name = "lberrordirecc";
            this.lberrordirecc.Size = new System.Drawing.Size(12, 14);
            this.lberrordirecc.TabIndex = 17;
            this.lberrordirecc.Text = "-";
            this.lberrordirecc.Visible = false;
            // 
            // frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmclientes";
            this.Text = "frmclientes";
            this.Load += new System.EventHandler(this.frmclientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtdirecc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneli;
        private System.Windows.Forms.Button btnmodi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscarcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lberrorcorreo;
        private System.Windows.Forms.Label lberrorcell;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lberrornombre;
        private System.Windows.Forms.Label lberrordirecc;
    }
}