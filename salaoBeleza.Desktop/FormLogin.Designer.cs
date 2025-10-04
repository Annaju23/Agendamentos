namespace salaoBeleza.Desktop
{
    partial class FormLogin
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
            button1 = new Button();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 12F);
            btnEntrar.ForeColor = Color.FromArgb(64, 0, 64);
            btnEntrar.Location = new Point(1, 195);
            btnEntrar.Margin = new Padding(2, 2, 2, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(78, 32);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(1, 67);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 29);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(1, 121);
            txtSenha.Margin = new Padding(2, 2, 2, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(254, 29);
            txtSenha.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(64, 0, 64);
            lblTitulo.Location = new Point(1, 5);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(216, 37);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Salão de Beleza";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14F);
            lblEmail.ForeColor = Color.FromArgb(64, 0, 64);
            lblEmail.Location = new Point(1, 43);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblSenh
            // 
            lblSenh.AutoSize = true;
            lblSenh.Font = new Font("Segoe UI", 12F);
            lblSenh.ForeColor = Color.FromArgb(64, 0, 64);
            lblSenh.Location = new Point(1, 98);
            lblSenh.Margin = new Padding(2, 0, 2, 0);
            lblSenh.Name = "lblSenh";
            lblSenh.Size = new Size(53, 21);
            lblSenh.TabIndex = 6;
            lblSenh.Text = "Senha";
            // 
            // chkLembrar
            // 
            chkLembrar.AutoSize = true;
            chkLembrar.Font = new Font("Segoe UI", 11F);
            chkLembrar.ForeColor = Color.FromArgb(64, 0, 64);
            chkLembrar.Location = new Point(1, 158);
            chkLembrar.Margin = new Padding(2, 2, 2, 2);
            chkLembrar.Name = "chkLembrar";
            chkLembrar.Size = new Size(110, 24);
            chkLembrar.TabIndex = 7;
            chkLembrar.Text = "Lembrar-me";
            chkLembrar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.FromArgb(64, 0, 64);
            button1.Location = new Point(136, 195);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(87, 32);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CadastrarUsuarios;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(560, 270);
            Controls.Add(button1);
            Controls.Add(chkLembrar);
            Controls.Add(lblSenh);
            Controls.Add(lblEmail);
            Controls.Add(lblTitulo);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(btnEntrar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormLogin";
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
        private Button button1;
    }
}
