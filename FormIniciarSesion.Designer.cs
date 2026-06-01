namespace ProyectoFinal
{
    partial class FormIniciarSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngresar = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.Navy;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            btnIngresar.ForeColor = SystemColors.ButtonFace;
            btnIngresar.Location = new Point(81, 469);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(373, 34);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContraseña.BackColor = Color.Silver;
            txtContraseña.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            txtContraseña.Location = new Point(81, 405);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(373, 29);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.BackColor = Color.Silver;
            txtUsuario.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            txtUsuario.Location = new Point(81, 305);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(373, 29);
            txtUsuario.TabIndex = 2;
            // 
            // lblContraseña
            // 
            lblContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            lblContraseña.ForeColor = Color.White;
            lblContraseña.Location = new Point(81, 370);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(125, 22);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Location = new Point(81, 277);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(88, 22);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.ChatGPT_Image_4_may_2026__08_53_12_a_m_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(535, 624);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblContraseña);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIngresar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private Label lblUsuario;
    }
}
