namespace salaoBeleza.Desktop
{
    partial class FormDashboard
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
            tblDivisao = new TableLayoutPanel();
            pnlAgendar = new Panel();
            pnlAgendamentos = new Panel();
            lblTitulo = new Label();
            lblSub = new Label();
            tblFormulario = new TableLayoutPanel();
            lblServico = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            tblDivisao.SuspendLayout();
            pnlAgendar.SuspendLayout();
            tblFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // tblDivisao
            // 
            tblDivisao.ColumnCount = 2;
            tblDivisao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblDivisao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblDivisao.Controls.Add(pnlAgendamentos, 1, 0);
            tblDivisao.Controls.Add(pnlAgendar, 0, 0);
            tblDivisao.Dock = DockStyle.Fill;
            tblDivisao.Location = new Point(8, 8);
            tblDivisao.Name = "tblDivisao";
            tblDivisao.RowCount = 1;
            tblDivisao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDivisao.Size = new Size(1242, 648);
            tblDivisao.TabIndex = 0;
            // 
            // pnlAgendar
            // 
            pnlAgendar.BackColor = Color.FromArgb(35, 34, 37);
            pnlAgendar.Controls.Add(tblFormulario);
            pnlAgendar.Controls.Add(lblSub);
            pnlAgendar.Controls.Add(lblTitulo);
            pnlAgendar.Dock = DockStyle.Fill;
            pnlAgendar.Location = new Point(0, 0);
            pnlAgendar.Margin = new Padding(0);
            pnlAgendar.Name = "pnlAgendar";
            pnlAgendar.Padding = new Padding(20);
            pnlAgendar.Size = new Size(372, 648);
            pnlAgendar.TabIndex = 0;
            // 
            // pnlAgendamentos
            // 
            pnlAgendamentos.Dock = DockStyle.Fill;
            pnlAgendamentos.ForeColor = Color.FromArgb(178, 175, 182);
            pnlAgendamentos.Location = new Point(384, 0);
            pnlAgendamentos.Margin = new Padding(12, 0, 0, 0);
            pnlAgendamentos.Name = "pnlAgendamentos";
            pnlAgendamentos.Size = new Size(858, 648);
            pnlAgendamentos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(346, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agende um atendimento";
            // 
            // lblSub
            // 
            lblSub.BackColor = Color.Transparent;
            lblSub.Dock = DockStyle.Top;
            lblSub.ForeColor = Color.FromArgb(152, 149, 157);
            lblSub.Location = new Point(20, 58);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(332, 38);
            lblSub.TabIndex = 1;
            lblSub.Text = "Selecione o serviço, a data e informe o horário para criar o agendamento";
            // 
            // tblFormulario
            // 
            tblFormulario.ColumnCount = 1;
            tblFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFormulario.Controls.Add(lblServico, 0, 0);
            tblFormulario.Controls.Add(label3, 0, 4);
            tblFormulario.Controls.Add(label2, 0, 2);
            tblFormulario.Controls.Add(comboBox2, 0, 3);
            tblFormulario.Controls.Add(comboBox1, 0, 1);
            tblFormulario.Controls.Add(comboBox3, 0, 5);
            tblFormulario.Dock = DockStyle.Top;
            tblFormulario.Location = new Point(20, 96);
            tblFormulario.Name = "tblFormulario";
            tblFormulario.RowCount = 6;
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.Size = new Size(332, 322);
            tblFormulario.TabIndex = 2;
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Dock = DockStyle.Top;
            lblServico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblServico.ForeColor = Color.FromArgb(178, 175, 182);
            lblServico.Location = new Point(3, 0);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(326, 32);
            lblServico.TabIndex = 0;
            lblServico.Text = "Serviço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 106);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 212);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 162);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(3, 268);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 33);
            comboBox3.TabIndex = 5;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 24, 27);
            ClientSize = new Size(1258, 664);
            Controls.Add(tblDivisao);
            MinimumSize = new Size(1280, 720);
            Name = "FormDashboard";
            Padding = new Padding(8);
            Text = "Salão de Beleza-Agendamento";
            tblDivisao.ResumeLayout(false);
            pnlAgendar.ResumeLayout(false);
            pnlAgendar.PerformLayout();
            tblFormulario.ResumeLayout(false);
            tblFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblDivisao;
        private Panel pnlAgendamentos;
        private Panel pnlAgendar;
        private Label lblSub;
        private Label lblTitulo;
        private TableLayoutPanel tblFormulario;
        private Label lblServico;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}