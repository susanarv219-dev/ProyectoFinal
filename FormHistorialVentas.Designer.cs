namespace ProyectoFinal
{
    partial class FormHistorialVentas
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
            dgvHistorial = new DataGridView();
            Venta = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Productos = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            MPago = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            btnFiltrar = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            btnRegresar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { Venta, Fecha, Hora, Productos, Total, MPago });
            dgvHistorial.Location = new Point(27, 304);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 62;
            dgvHistorial.Size = new Size(1864, 592);
            dgvHistorial.TabIndex = 0;
            // 
            // Venta
            // 
            Venta.HeaderText = "N, Venta";
            Venta.MaxInputLength = 32900;
            Venta.MinimumWidth = 8;
            Venta.Name = "Venta";
            Venta.Visible = false;
            Venta.Width = 305;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 8;
            Fecha.Name = "Fecha";
            Fecha.Width = 305;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.MinimumWidth = 8;
            Hora.Name = "Hora";
            Hora.Width = 305;
            // 
            // Productos
            // 
            Productos.HeaderText = "Productos";
            Productos.MinimumWidth = 8;
            Productos.Name = "Productos";
            Productos.Width = 580;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.Width = 305;
            // 
            // MPago
            // 
            MPago.HeaderText = "Mètodo de pago";
            MPago.MinimumWidth = 8;
            MPago.Name = "MPago";
            MPago.Width = 305;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(1864, 153);
            panel1.TabIndex = 24;
            panel1.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(376, 19);
            label1.Name = "label1";
            label1.Size = new Size(1138, 116);
            label1.TabIndex = 0;
            label1.Text = "HISTORIAL DE VENTA";
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.DarkSlateBlue;
            btnFiltrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnFiltrar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = SystemColors.ButtonHighlight;
            btnFiltrar.Location = new Point(1539, 247);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(100, 42);
            btnFiltrar.TabIndex = 27;
            btnFiltrar.Text = "FILTRAR";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            textBox1.Location = new Point(135, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 45);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(27, 252);
            label2.Name = "label2";
            label2.Size = new Size(102, 38);
            label2.TabIndex = 25;
            label2.Text = "Buscar";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.Indigo;
            btnRegresar.Location = new Point(1744, 902);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(147, 49);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Indigo;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(192, 192, 255);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(192, 192, 255);
            dateTimePicker1.CalendarTitleForeColor = Color.Indigo;
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(765, 248);
            dateTimePicker1.MinDate = new DateTime(1753, 1, 9, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 39);
            dateTimePicker1.TabIndex = 28;
            dateTimePicker1.Value = new DateTime(2026, 4, 26, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(607, 252);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 29;
            label3.Text = "Fecha desde:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(1069, 253);
            label4.Name = "label4";
            label4.Size = new Size(150, 32);
            label4.TabIndex = 31;
            label4.Text = "Fecha hasta:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.Indigo;
            dateTimePicker2.CalendarMonthBackground = Color.FromArgb(192, 192, 255);
            dateTimePicker2.CalendarTitleBackColor = Color.FromArgb(192, 192, 255);
            dateTimePicker2.CalendarTitleForeColor = Color.Indigo;
            dateTimePicker2.Font = new Font("Segoe UI", 12F);
            dateTimePicker2.Location = new Point(1225, 247);
            dateTimePicker2.MinDate = new DateTime(1753, 1, 9, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(296, 39);
            dateTimePicker2.TabIndex = 32;
            dateTimePicker2.Value = new DateTime(2026, 4, 26, 0, 0, 0, 0);
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.Indigo;
            btnBorrar.Location = new Point(27, 902);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(309, 49);
            btnBorrar.TabIndex = 34;
            btnBorrar.Text = "BORRAR DEL HISTORIAL";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1924, 954);
            Controls.Add(btnBorrar);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnRegresar);
            Controls.Add(btnFiltrar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dgvHistorial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "HISTORIAL DE VENTA";
            WindowState = FormWindowState.Maximized;
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorial;
        private Panel panel1;
        private Label label1;
        private Button btnFiltrar;
        private TextBox textBox1;
        private Label label2;
        private Button button5;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Button btnRegresar;
        private Button btnBorrar;
        private DataGridViewTextBoxColumn Venta;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Productos;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn MPago;
    }
}