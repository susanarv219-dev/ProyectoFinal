namespace ProyectoFinal
{
    partial class FormReportes
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
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            groupBox4 = new GroupBox();
            lblGananciasHoy = new Label();
            lblVentasHoy = new Label();
            groupBox3 = new GroupBox();
            lstBajoStock = new ListBox();
            groupBox5 = new GroupBox();
            lblCantidadMenosVendido = new Label();
            lblMenosVendido = new Label();
            groupBox6 = new GroupBox();
            label1 = new Label();
            lblCantidadVentas = new Label();
            groupBox2 = new GroupBox();
            lblMasVendido = new Label();
            lblCantidadMasVendido = new Label();
            groupBox1 = new GroupBox();
            lblTotalVendido = new Label();
            btnRegresar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(cartesianChart1);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(27, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(1864, 796);
            panel1.TabIndex = 24;
            panel1.Tag = "";
            // 
            // cartesianChart1
            // 
            cartesianChart1.AutoUpdateEnabled = true;
            cartesianChart1.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            cartesianChart1.Legend = skDefaultLegend1;
            cartesianChart1.Location = new Point(75, 446);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1000, 250);
            cartesianChart1.TabIndex = 30;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            cartesianChart1.Tooltip = skDefaultTooltip1;
            cartesianChart1.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            cartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // groupBox4
            // 
            groupBox4.BackgroundImage = Properties.Resources._716c17e3_5e69_4933_8d90_53d5b8a64fb2;
            groupBox4.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox4.Controls.Add(lblGananciasHoy);
            groupBox4.Controls.Add(lblVentasHoy);
            groupBox4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.DarkGreen;
            groupBox4.Location = new Point(1155, 515);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(618, 306);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            // 
            // lblGananciasHoy
            // 
            lblGananciasHoy.AutoSize = true;
            lblGananciasHoy.BackColor = Color.Transparent;
            lblGananciasHoy.ForeColor = Color.Green;
            lblGananciasHoy.Location = new Point(413, 163);
            lblGananciasHoy.Name = "lblGananciasHoy";
            lblGananciasHoy.Size = new Size(54, 48);
            lblGananciasHoy.TabIndex = 5;
            lblGananciasHoy.Text = "ol";
            // 
            // lblVentasHoy
            // 
            lblVentasHoy.AutoSize = true;
            lblVentasHoy.BackColor = Color.Transparent;
            lblVentasHoy.ForeColor = Color.Green;
            lblVentasHoy.Location = new Point(149, 163);
            lblVentasHoy.Name = "lblVentasHoy";
            lblVentasHoy.Size = new Size(54, 48);
            lblVentasHoy.TabIndex = 2;
            lblVentasHoy.Text = "ol";
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources._6460f2cb_b69f_4975_bff7_655f81aee4bb;
            groupBox3.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox3.Controls.Add(lstBajoStock);
            groupBox3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.DarkGreen;
            groupBox3.Location = new Point(1119, 61);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(680, 448);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            // 
            // lstBajoStock
            // 
            lstBajoStock.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            lstBajoStock.FormattingEnabled = true;
            lstBajoStock.Location = new Point(238, 131);
            lstBajoStock.Name = "lstBajoStock";
            lstBajoStock.Size = new Size(357, 274);
            lstBajoStock.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.BackgroundImage = Properties.Resources._0de73ede_656e_4c64_b95c_26b2b39a07ae;
            groupBox5.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox5.Controls.Add(lblCantidadMenosVendido);
            groupBox5.Controls.Add(lblMenosVendido);
            groupBox5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.DarkGreen;
            groupBox5.Location = new Point(606, 268);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(457, 150);
            groupBox5.TabIndex = 28;
            groupBox5.TabStop = false;
            // 
            // lblCantidadMenosVendido
            // 
            lblCantidadMenosVendido.AutoSize = true;
            lblCantidadMenosVendido.BackColor = Color.Transparent;
            lblCantidadMenosVendido.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblCantidadMenosVendido.ForeColor = Color.FromArgb(192, 0, 0);
            lblCantidadMenosVendido.Location = new Point(183, 99);
            lblCantidadMenosVendido.Name = "lblCantidadMenosVendido";
            lblCantidadMenosVendido.Size = new Size(36, 32);
            lblCantidadMenosVendido.TabIndex = 4;
            lblCantidadMenosVendido.Text = "ol";
            // 
            // lblMenosVendido
            // 
            lblMenosVendido.AutoSize = true;
            lblMenosVendido.BackColor = Color.Transparent;
            lblMenosVendido.ForeColor = Color.FromArgb(192, 0, 0);
            lblMenosVendido.Location = new Point(174, 51);
            lblMenosVendido.Name = "lblMenosVendido";
            lblMenosVendido.Size = new Size(54, 48);
            lblMenosVendido.TabIndex = 1;
            lblMenosVendido.Text = "ol";
            // 
            // groupBox6
            // 
            groupBox6.BackgroundImage = Properties.Resources.d12ec261_1830_4611_beb9_985ee7aab672;
            groupBox6.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(lblCantidadVentas);
            groupBox6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.ForeColor = Color.DarkGreen;
            groupBox6.Location = new Point(606, 88);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(457, 150);
            groupBox6.TabIndex = 28;
            groupBox6.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(193, 51);
            label1.Name = "label1";
            label1.Size = new Size(140, 48);
            label1.TabIndex = 2;
            label1.Text = "Ventas";
            // 
            // lblCantidadVentas
            // 
            lblCantidadVentas.AutoSize = true;
            lblCantidadVentas.BackColor = Color.Transparent;
            lblCantidadVentas.ForeColor = Color.CornflowerBlue;
            lblCantidadVentas.Location = new Point(142, 51);
            lblCantidadVentas.Name = "lblCantidadVentas";
            lblCantidadVentas.Size = new Size(54, 48);
            lblCantidadVentas.TabIndex = 1;
            lblCantidadVentas.Text = "ol";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.d78a193f_64c3_4a38_8783_c0338b0317c0;
            groupBox2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox2.Controls.Add(lblMasVendido);
            groupBox2.Controls.Add(lblCantidadMasVendido);
            groupBox2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.DarkGreen;
            groupBox2.Location = new Point(75, 268);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 150);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            // 
            // lblMasVendido
            // 
            lblMasVendido.AutoSize = true;
            lblMasVendido.BackColor = Color.Transparent;
            lblMasVendido.ForeColor = Color.Green;
            lblMasVendido.Location = new Point(149, 51);
            lblMasVendido.Name = "lblMasVendido";
            lblMasVendido.Size = new Size(54, 48);
            lblMasVendido.TabIndex = 4;
            lblMasVendido.Text = "ol";
            // 
            // lblCantidadMasVendido
            // 
            lblCantidadMasVendido.AutoSize = true;
            lblCantidadMasVendido.BackColor = Color.Transparent;
            lblCantidadMasVendido.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblCantidadMasVendido.ForeColor = Color.Green;
            lblCantidadMasVendido.Location = new Point(167, 99);
            lblCantidadMasVendido.Name = "lblCantidadMasVendido";
            lblCantidadMasVendido.Size = new Size(36, 32);
            lblCantidadMasVendido.TabIndex = 3;
            lblCantidadMasVendido.Text = "ol";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.b7fb22ed_6c36_4a5d_8035_33ae5a099954;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(lblTotalVendido);
            groupBox1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DarkGreen;
            groupBox1.Location = new Point(75, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 150);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // lblTotalVendido
            // 
            lblTotalVendido.AutoSize = true;
            lblTotalVendido.BackColor = Color.Transparent;
            lblTotalVendido.ForeColor = Color.Green;
            lblTotalVendido.Location = new Point(190, 51);
            lblTotalVendido.Name = "lblTotalVendido";
            lblTotalVendido.Size = new Size(54, 48);
            lblTotalVendido.TabIndex = 0;
            lblTotalVendido.Text = "ol";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.Indigo;
            btnRegresar.Location = new Point(1679, 877);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(147, 49);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Indigo;
            button1.Location = new Point(27, 877);
            button1.Name = "button1";
            button1.Size = new Size(147, 49);
            button1.TabIndex = 25;
            button1.Text = "IMPRIMIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnImprimir_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Indigo;
            button2.Location = new Point(195, 877);
            button2.Name = "button2";
            button2.Size = new Size(177, 49);
            button2.TabIndex = 26;
            button2.Text = "ACTUALIZAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnActualizar_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1924, 954);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRegresar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            Text = "REPORTES";
            WindowState = FormWindowState.Maximized;
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel1;
        private Button btnRegresar;
        private GroupBox groupBox1;
        private Label lblTotalVendido;
        private GroupBox groupBox6;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private Label lblCantidadVentas;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private Label lblMenosVendido;
        private Label lblVentasHoy;
        private GroupBox groupBox4;
        private Label label4;
        private Label lblCantidadMasVendido;
        private Label lblCantidadMenosVendido;
        private Label lblGananciasHoy;
        private Label lblMasVendido;
        private ListBox lstBajoStock;
        private Label label1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}