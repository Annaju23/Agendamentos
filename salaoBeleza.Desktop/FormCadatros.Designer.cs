namespace salaoBeleza.Desktop
{
    partial class FormCadatros
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
            barraTopo = new Panel();
            btnVoltar = new Button();
            label1 = new Label();
            pnlFormulario = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label5 = new Label();
            txtComfimacao = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label4 = new Label();
            txtSenha = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            txtEmail = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            txtNome = new TextBox();
            btnCadastrar = new Button();
            barraTopo.SuspendLayout();
            pnlFormulario.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // barraTopo
            // 
            barraTopo.Controls.Add(btnVoltar);
            barraTopo.Controls.Add(label1);
            barraTopo.Dock = DockStyle.Top;
            barraTopo.Location = new Point(6, 5);
            barraTopo.Margin = new Padding(2);
            barraTopo.Name = "barraTopo";
            barraTopo.Size = new Size(338, 60);
            barraTopo.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(258, 22);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(78, 25);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += FecharCadastro;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe Print", 17.25F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(210, 60);
            label1.TabIndex = 1;
            label1.Text = "Salão de Beleza";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlFormulario
            // 
            pnlFormulario.AutoSize = true;
            pnlFormulario.Controls.Add(flowLayoutPanel4);
            pnlFormulario.Controls.Add(flowLayoutPanel3);
            pnlFormulario.Controls.Add(flowLayoutPanel2);
            pnlFormulario.Controls.Add(flowLayoutPanel1);
            pnlFormulario.Dock = DockStyle.Top;
            pnlFormulario.Location = new Point(6, 65);
            pnlFormulario.Margin = new Padding(2);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(338, 228);
            pnlFormulario.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label5);
            flowLayoutPanel4.Controls.Add(txtComfimacao);
            flowLayoutPanel4.Dock = DockStyle.Top;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Font = new Font("Segoe UI", 12F);
            flowLayoutPanel4.Location = new Point(0, 171);
            flowLayoutPanel4.Margin = new Padding(0, 0, 0, 10);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(338, 57);
            flowLayoutPanel4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(2, 0);
            label5.Margin = new Padding(2, 0, 2, 5);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 3;
            label5.Text = "Confirmar Senha";
            // 
            // txtComfimacao
            // 
            txtComfimacao.Location = new Point(142, 0);
            txtComfimacao.Margin = new Padding(0, 0, 0, 10);
            txtComfimacao.Name = "txtComfimacao";
            txtComfimacao.PasswordChar = '*';
            txtComfimacao.Size = new Size(340, 29);
            txtComfimacao.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(txtSenha);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Font = new Font("Segoe UI", 12F);
            flowLayoutPanel3.Location = new Point(0, 114);
            flowLayoutPanel3.Margin = new Padding(0, 0, 0, 10);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(338, 57);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(2, 0);
            label4.Margin = new Padding(2, 0, 2, 5);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 3;
            label4.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(61, 0);
            txtSenha.Margin = new Padding(0, 0, 0, 10);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(340, 29);
            txtSenha.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(txtEmail);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Font = new Font("Segoe UI", 12F);
            flowLayoutPanel2.Location = new Point(0, 57);
            flowLayoutPanel2.Margin = new Padding(0, 0, 0, 10);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(338, 57);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(2, 0);
            label3.Margin = new Padding(2, 0, 2, 5);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(57, 0);
            txtEmail.Margin = new Padding(0, 0, 0, 10);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 29);
            txtEmail.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtNome);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0, 0, 0, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(338, 57);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 5);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 3;
            label2.Text = "Nome completo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(138, 0);
            txtNome.Margin = new Padding(0, 0, 0, 10);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(340, 29);
            txtNome.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = true;
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(123, 358);
            btnCadastrar.Margin = new Padding(2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(87, 31);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // FormCadatros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(350, 390);
            Controls.Add(pnlFormulario);
            Controls.Add(barraTopo);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormCadatros";
            Padding = new Padding(6, 5, 6, 5);
            Text = "FornCadatros";
            barraTopo.ResumeLayout(false);
            pnlFormulario.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel barraTopo;
        private Label label1;
        private Button btnVoltar;
        private Panel pnlFormulario;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox txtNome;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label5;
        private TextBox txtComfimacao;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label4;
        private TextBox txtSenha;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private TextBox txtEmail;
        private Button btnCadastrar;
    }
}