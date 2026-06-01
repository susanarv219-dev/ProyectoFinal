namespace ProyectoFinal
{
    partial class FormVenta
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvProductos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnRegresar = new Button();
            txtDinero = new TextBox();
            cbMetodo = new ComboBox();
            txtBuscar = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            label10 = new Label();
            btnEliminar = new Button();
            dgvCarrito = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnFinalizar = new Button();
            label8 = new Label();
            txtCambio = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(1864, 153);
            panel1.TabIndex = 25;
            panel1.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(744, 22);
            label1.Name = "label1";
            label1.Size = new Size(396, 116);
            label1.TabIndex = 0;
            label1.Text = "VENTA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvProductos);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(46, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 542);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.MediumPurple;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvProductos.Location = new Point(19, 51);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(525, 468);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 110;
            // 
            // Column2
            // 
            Column2.HeaderText = " PRODUCTO";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "PRECIO";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(19, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 48);
            label2.TabIndex = 0;
            label2.Text = "PRODUCTO";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(1743, 885);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(138, 38);
            btnRegresar.TabIndex = 27;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // txtDinero
            // 
            txtDinero.Location = new Point(41, 260);
            txtDinero.MaxLength = 5;
            txtDinero.Name = "txtDinero";
            txtDinero.Size = new Size(489, 31);
            txtDinero.TabIndex = 28;
            txtDinero.Text = "$0.00";
            txtDinero.TextChanged += txtDinero_TextChanged;
            txtDinero.Enter += txtDinero_Enter;
            // 
            // cbMetodo
            // 
            cbMetodo.FormattingEnabled = true;
            cbMetodo.Location = new Point(41, 135);
            cbMetodo.Name = "cbMetodo";
            cbMetodo.Size = new Size(489, 33);
            cbMetodo.TabIndex = 29;
            cbMetodo.SelectedIndexChanged += cbMetodo_SelectedIndexChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            txtBuscar.Location = new Point(683, 227);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(675, 45);
            txtBuscar.TabIndex = 31;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(575, 229);
            label3.Name = "label3";
            label3.Size = new Size(102, 38);
            label3.TabIndex = 30;
            label3.Text = "Buscar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(dgvCarrito);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(683, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(564, 542);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Indigo;
            lblTotal.Location = new Point(130, 481);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 41);
            lblTotal.TabIndex = 35;
            lblTotal.Text = "$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label10.ForeColor = Color.Indigo;
            label10.Location = new Point(19, 481);
            label10.Name = "label10";
            label10.Size = new Size(117, 41);
            label10.TabIndex = 34;
            label10.Text = "TOTAL:";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(212, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 38);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.BackgroundColor = Color.MediumPurple;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6, Column7 });
            dgvCarrito.Location = new Point(19, 51);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.Size = new Size(525, 363);
            dgvCarrito.TabIndex = 1;
            // 
            // Column4
            // 
            Column4.HeaderText = " PRODUCTO";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = " PRECIO ";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 115;
            // 
            // Column6
            // 
            Column6.HeaderText = " CANTIDAD";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 112;
            // 
            // Column7
            // 
            Column7.HeaderText = " SUBTOTAL";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 112;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(19, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 48);
            label4.TabIndex = 0;
            label4.Text = "CARRITO";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnFinalizar);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtCambio);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtDinero);
            groupBox3.Controls.Add(cbMetodo);
            groupBox3.Location = new Point(1317, 294);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(564, 542);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.Indigo;
            btnFinalizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.ForeColor = SystemColors.ButtonFace;
            btnFinalizar.Location = new Point(41, 458);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(489, 38);
            btnFinalizar.TabIndex = 32;
            btnFinalizar.Text = "FINALIZAR VENTA";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(41, 348);
            label8.Name = "label8";
            label8.Size = new Size(110, 32);
            label8.TabIndex = 32;
            label8.Text = "CAMBIO";
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(41, 383);
            txtCambio.Name = "txtCambio";
            txtCambio.ReadOnly = true;
            txtCambio.Size = new Size(489, 31);
            txtCambio.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Indigo;
            label7.Location = new Point(45, 225);
            label7.Name = "label7";
            label7.Size = new Size(224, 32);
            label7.TabIndex = 30;
            label7.Text = "DINERO RECIBIDO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Indigo;
            label6.Location = new Point(41, 102);
            label6.Name = "label6";
            label6.Size = new Size(228, 32);
            label6.TabIndex = 29;
            label6.Text = "METODO DE PAGO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(19, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 48);
            label5.TabIndex = 0;
            label5.Text = "PAGO";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1924, 954);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(txtBuscar);
            Controls.Add(label3);
            Controls.Add(btnRegresar);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "VENTA";
            WindowState = FormWindowState.Maximized;
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private DataGridView dgvProductos;
        private Button btnRegresar;
        private TextBox txtDinero;
        private ComboBox cbMetodo;
        private TextBox txtBuscar;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView dgvCarrito;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private Button btnFinalizar;
        private Label label8;
        private TextBox txtCambio;
        private Label label7;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnEliminar;
        private Label label10;
        private Label lblTotal;
    }
}