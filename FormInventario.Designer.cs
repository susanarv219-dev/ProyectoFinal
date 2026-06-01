namespace ProyectoFinal
{
    partial class FormInventario
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
            label2 = new Label();
            txtBuscar = new TextBox();
            label3 = new Label();
            btnBuscar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbFiltroCategoria = new ComboBox();
            txtNombre = new TextBox();
            dgvProductos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Caducidad = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            label7 = new Label();
            txtPrecio = new TextBox();
            groupBox1 = new GroupBox();
            txtID = new TextBox();
            label10 = new Label();
            numStock = new NumericUpDown();
            dtpCaducidad = new DateTimePicker();
            cmbCategoria = new ComboBox();
            textBox7 = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnRegresar = new Button();
            process1 = new System.Diagnostics.Process();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(463, 217);
            label2.Name = "label2";
            label2.Size = new Size(102, 38);
            label2.TabIndex = 1;
            label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            txtBuscar.Location = new Point(571, 215);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(426, 45);
            txtBuscar.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(1084, 217);
            label3.Name = "label3";
            label3.Size = new Size(149, 38);
            label3.TabIndex = 3;
            label3.Text = "Categorìa:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSlateBlue;
            btnBuscar.BackgroundImage = Properties.Resources.ChatGPT_Image_5_may_2026__02_43_56_p_m_;
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.Location = new Point(1003, 214);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(63, 46);
            btnBuscar.TabIndex = 6;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.Location = new Point(70, 59);
            label4.Name = "label4";
            label4.Size = new Size(96, 26);
            label4.TabIndex = 7;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F);
            label5.Location = new Point(70, 158);
            label5.Name = "label5";
            label5.Size = new Size(112, 26);
            label5.TabIndex = 8;
            label5.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F);
            label6.Location = new Point(393, 59);
            label6.Name = "label6";
            label6.Size = new Size(122, 26);
            label6.TabIndex = 9;
            label6.Text = "Caducidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11F);
            label8.Location = new Point(714, 59);
            label8.Name = "label8";
            label8.Size = new Size(73, 26);
            label8.TabIndex = 11;
            label8.Text = "Stock:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11F);
            label9.Location = new Point(393, 158);
            label9.Name = "label9";
            label9.Size = new Size(80, 26);
            label9.TabIndex = 12;
            label9.Text = "Precio:";
            // 
            // cmbFiltroCategoria
            // 
            cmbFiltroCategoria.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            cmbFiltroCategoria.FormattingEnabled = true;
            cmbFiltroCategoria.Location = new Point(1230, 217);
            cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            cmbFiltroCategoria.Size = new Size(177, 46);
            cmbFiltroCategoria.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(192, 192, 255);
            txtNombre.Font = new Font("Microsoft Sans Serif", 11F);
            txtNombre.Location = new Point(70, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 32);
            txtNombre.TabIndex = 14;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Nombre, ID, Precio, Stock, Caducidad, Categoria });
            dgvProductos.Location = new Point(469, 266);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(966, 279);
            dgvProductos.TabIndex = 15;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.Width = 150;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            Stock.Width = 150;
            // 
            // Caducidad
            // 
            Caducidad.HeaderText = "Caducidad";
            Caducidad.MinimumWidth = 8;
            Caducidad.Name = "Caducidad";
            Caducidad.Width = 150;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 8;
            Categoria.Name = "Categoria";
            Categoria.Width = 150;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 14);
            label7.Name = "label7";
            label7.Size = new Size(201, 32);
            label7.TabIndex = 10;
            label7.Text = "Total productos:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(192, 192, 255);
            txtPrecio.Font = new Font("Microsoft Sans Serif", 11F);
            txtPrecio.Location = new Point(377, 205);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(204, 32);
            txtPrecio.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Lavender;
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(numStock);
            groupBox1.Controls.Add(dtpCaducidad);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(469, 629);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(966, 280);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(192, 192, 255);
            txtID.Font = new Font("Microsoft Sans Serif", 11F);
            txtID.Location = new Point(694, 205);
            txtID.Name = "txtID";
            txtID.Size = new Size(204, 32);
            txtID.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11F);
            label10.Location = new Point(694, 158);
            label10.Name = "label10";
            label10.Size = new Size(40, 26);
            label10.TabIndex = 25;
            label10.Text = "ID:";
            // 
            // numStock
            // 
            numStock.BackColor = Color.FromArgb(192, 192, 255);
            numStock.ForeColor = Color.Indigo;
            numStock.Location = new Point(694, 95);
            numStock.Name = "numStock";
            numStock.Size = new Size(204, 37);
            numStock.TabIndex = 24;
            // 
            // dtpCaducidad
            // 
            dtpCaducidad.CalendarForeColor = Color.Indigo;
            dtpCaducidad.CalendarMonthBackground = Color.FromArgb(192, 192, 255);
            dtpCaducidad.CalendarTitleBackColor = Color.FromArgb(192, 192, 255);
            dtpCaducidad.CalendarTitleForeColor = Color.Indigo;
            dtpCaducidad.Font = new Font("Segoe UI", 8F);
            dtpCaducidad.Location = new Point(377, 103);
            dtpCaducidad.MinDate = new DateTime(1753, 1, 9, 0, 0, 0, 0);
            dtpCaducidad.Name = "dtpCaducidad";
            dtpCaducidad.Size = new Size(204, 29);
            dtpCaducidad.TabIndex = 23;
            dtpCaducidad.Value = new DateTime(2026, 4, 26, 0, 0, 0, 0);
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(192, 192, 255);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(77, 199);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(197, 38);
            cmbCategoria.TabIndex = 22;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Lavender;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox7.ForeColor = Color.Indigo;
            textBox7.Location = new Point(204, 14);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(54, 32);
            textBox7.TabIndex = 21;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 192, 255);
            btnAgregar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.Indigo;
            btnAgregar.Location = new Point(959, 915);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(450, 55);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(192, 192, 255);
            btnEditar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Indigo;
            btnEditar.Location = new Point(492, 551);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(450, 60);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 192, 255);
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Indigo;
            btnEliminar.Location = new Point(959, 551);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(449, 60);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1864, 153);
            panel1.TabIndex = 23;
            panel1.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(567, 17);
            label1.Name = "label1";
            label1.Size = new Size(685, 116);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.Indigo;
            btnRegresar.Location = new Point(1527, 893);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(151, 49);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // process1
            // 
            process1.StartInfo.CreateNewProcessGroup = false;
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(192, 192, 255);
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Indigo;
            btnLimpiar.Location = new Point(492, 915);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(450, 55);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1924, 954);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegresar);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(groupBox1);
            Controls.Add(dgvProductos);
            Controls.Add(btnAgregar);
            Controls.Add(cmbFiltroCategoria);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "INVENTARIO";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtBuscar;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnBuscar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private ComboBox cmbFiltroCategoria;
        private TextBox txtNombre;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Caducidad;
        private DataGridViewTextBoxColumn Categoria;
        private Label label7;
        private TextBox txtPrecio;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private TextBox textBox7;
        private Button btnEditar;
        private Button btnEliminar;
        private Panel panel1;
        private Label label1;
        private ComboBox cmbCategoria;
        private NumericUpDown numStock;
        private DateTimePicker dtpCaducidad;
        private Button button5;
        private Button btnRegresar;
        private System.Diagnostics.Process process1;
        private TextBox txtID;
        private Label label10;
        private Button btnLimpiar;
    }
}