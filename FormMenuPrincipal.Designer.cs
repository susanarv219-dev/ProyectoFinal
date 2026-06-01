namespace ProyectoFinal
{
    partial class FormMenuPrincipal
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
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            lblStock = new Label();
            lblVentas = new Label();
            lblProductos = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnCerrarSesion = new Button();
            btnHistorial = new Button();
            btnReportes = new Button();
            btnVenta = new Button();
            btnInventario = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.MediumPurple;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(btnHistorial);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnVenta);
            panel1.Controls.Add(btnInventario);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(3288, 951);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Indigo;
            btnSalir.Location = new Point(1355, 880);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(274, 42);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblStock);
            groupBox1.Controls.Add(lblVentas);
            groupBox1.Controls.Add(lblProductos);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Trebuchet MS", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 64);
            groupBox1.Location = new Point(314, 393);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1315, 481);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "RESUMEN";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.White;
            lblStock.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.FromArgb(192, 0, 0);
            lblStock.Location = new Point(1019, 274);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 54);
            lblStock.TabIndex = 11;
            lblStock.Text = "4";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.BackColor = Color.White;
            lblVentas.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = Color.FromArgb(0, 192, 0);
            lblVentas.Location = new Point(562, 274);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(71, 54);
            lblVentas.TabIndex = 10;
            lblVentas.Text = "69";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.BackColor = Color.White;
            lblProductos.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductos.ForeColor = Color.FromArgb(128, 128, 255);
            lblProductos.Location = new Point(259, 274);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(71, 54);
            lblProductos.TabIndex = 9;
            lblProductos.Text = "69";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.ChatGPT_Image_7_may_2026__08_51_55_p_m_;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(867, 84);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(353, 371);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.ChatGPT_Image_6_may_2026__08_51_55_p_m_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(484, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(353, 371);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ChatGPT_Image_5_may_2026__08_51_55_p_m_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(98, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 371);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Indigo;
            btnCerrarSesion.Location = new Point(1355, 928);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(274, 42);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(192, 192, 255);
            btnHistorial.BackgroundImage = Properties.Resources.ChatGPT_Image_7_may_2026__01_28_00_p_m_;
            btnHistorial.BackgroundImageLayout = ImageLayout.Stretch;
            btnHistorial.Font = new Font("Segoe UI Black", 29F);
            btnHistorial.Location = new Point(1028, 55);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(254, 315);
            btnHistorial.TabIndex = 4;
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(255, 192, 255);
            btnReportes.BackgroundImage = Properties.Resources.ChatGPT_Image_8_may_2026__01_28_00_p_m_;
            btnReportes.BackgroundImageLayout = ImageLayout.Stretch;
            btnReportes.Font = new Font("Segoe UI Black", 29F);
            btnReportes.Location = new Point(1375, 55);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(254, 315);
            btnReportes.TabIndex = 3;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnVenta
            // 
            btnVenta.BackColor = Color.FromArgb(255, 192, 255);
            btnVenta.BackgroundImage = Properties.Resources.ChatGPT_Image_6_may_2026__01_28_00_p_m_;
            btnVenta.BackgroundImageLayout = ImageLayout.Stretch;
            btnVenta.Font = new Font("Segoe UI Black", 29F);
            btnVenta.Location = new Point(674, 55);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(254, 315);
            btnVenta.TabIndex = 2;
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(192, 192, 255);
            btnInventario.BackgroundImage = Properties.Resources.ChatGPT_Image_5_may_2026__01_28_00_p_m_;
            btnInventario.BackgroundImageLayout = ImageLayout.Stretch;
            btnInventario.Font = new Font("Segoe UI Black", 29F);
            btnInventario.ImageAlign = ContentAlignment.TopCenter;
            btnInventario.Location = new Point(314, 55);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(254, 315);
            btnInventario.TabIndex = 1;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 954);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "MENU PRINCIPAL";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnInventario;
        private Button button4;
        private Button btnReportes;
        private Button btnVenta;
        private Button btnCerrarSesion;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lblStock;
        private Label lblVentas;
        private Label lblProductos;
        private Button btnHistorial;
        private Button btnSalir;
    }
}