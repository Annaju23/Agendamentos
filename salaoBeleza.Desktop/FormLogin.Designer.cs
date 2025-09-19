namespace salaoBeleza.Desktop
{
    partial class Form1
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
            btnEntrar = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblTitulo = new Label();
            lblEmail = new Label();
            lblSenh = new Label();
            chkLembrar = new CheckBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 12F);
            btnEntrar.ForeColor = Color.FromArgb(64, 0, 64);
            btnEntrar.Location = new Point(2, 325);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(112, 39);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(2, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(361, 39);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(2, 201);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(361, 39);
            txtSenha.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(64, 0, 64);
            lblTitulo.Location = new Point(2, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(315, 54);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Salão de Beleza";
            lblTitulo.Click += this.IblTitulo_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14F);
            lblEmail.ForeColor = Color.FromArgb(64, 0, 64);
            lblEmail.Location = new Point(2, 71);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 38);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            lblEmail.Click += this.label1_Click;
            // 
            // lblSenh
            // 
            lblSenh.AutoSize = true;
            lblSenh.Font = new Font("Segoe UI", 12F);
            lblSenh.ForeColor = Color.FromArgb(64, 0, 64);
            lblSenh.Location = new Point(2, 164);
            lblSenh.Name = "lblSenh";
            lblSenh.Size = new Size(80, 32);
            lblSenh.TabIndex = 6;
            lblSenh.Text = "Senha";
            // 
            // chkLembrar
            // 
            chkLembrar.AutoSize = true;
            chkLembrar.Font = new Font("Segoe UI", 11F);
            chkLembrar.ForeColor = Color.FromArgb(64, 0, 64);
            chkLembrar.Location = new Point(2, 264);
            chkLembrar.Name = "chkLembrar";
            chkLembrar.Size = new Size(160, 34);
            chkLembrar.TabIndex = 7;
            chkLembrar.Text = "Lembrar-me";
            chkLembrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(chkLembrar);
            Controls.Add(lblSenh);
            Controls.Add(lblEmail);
            Controls.Add(lblTitulo);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(btnEntrar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblTitulo;
        private Label lblEmail;
        private Label lblSenh;
        private CheckBox chkLembrar;
    }
}
