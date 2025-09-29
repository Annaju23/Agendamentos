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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblAgendamentos = new Label();
            lblSubAgendamentos = new Label();
            pnlAgendar = new Panel();
            tblFormulario = new TableLayoutPanel();
            lblServico = new Label();
            lblHorario = new Label();
            lblData = new Label();
            cbxData = new ComboBox();
            cbxServico = new ComboBox();
            cbxHorario = new ComboBox();
            lblSub = new Label();
            lblTitulo = new Label();
            btnAgendar = new Button();
            dgvDados = new DataGridView();
            tblDivisao.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlAgendar.SuspendLayout();
            tblFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // tblDivisao
            // 
            tblDivisao.ColumnCount = 2;
            tblDivisao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblDivisao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblDivisao.Controls.Add(flowLayoutPanel1, 1, 0);
            tblDivisao.Controls.Add(pnlAgendar, 0, 0);
            tblDivisao.Dock = DockStyle.Fill;
            tblDivisao.Location = new Point(6, 5);
            tblDivisao.Margin = new Padding(2);
            tblDivisao.Name = "tblDivisao";
            tblDivisao.RowCount = 2;
            tblDivisao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDivisao.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblDivisao.Size = new Size(873, 399);
            tblDivisao.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblAgendamentos);
            flowLayoutPanel1.Controls.Add(lblSubAgendamentos);
            flowLayoutPanel1.Controls.Add(dgvDados);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(273, 0);
            flowLayoutPanel1.Margin = new Padding(12, 0, 0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(600, 379);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // lblAgendamentos
            // 
            lblAgendamentos.AutoSize = true;
            lblAgendamentos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAgendamentos.ForeColor = Color.White;
            lblAgendamentos.Location = new Point(23, 20);
            lblAgendamentos.Name = "lblAgendamentos";
            lblAgendamentos.Size = new Size(190, 25);
            lblAgendamentos.TabIndex = 0;
            lblAgendamentos.Text = "Seus agendamentos";
            // 
            // lblSubAgendamentos
            // 
            lblSubAgendamentos.AutoSize = true;
            lblSubAgendamentos.Font = new Font("Segoe UI", 11F);
            lblSubAgendamentos.ForeColor = Color.FromArgb(152, 149, 157);
            lblSubAgendamentos.Location = new Point(23, 45);
            lblSubAgendamentos.Name = "lblSubAgendamentos";
            lblSubAgendamentos.Size = new Size(305, 20);
            lblSubAgendamentos.TabIndex = 1;
            lblSubAgendamentos.Text = "consulte a baixo seus ultimos agendamentos";
            // 
            // pnlAgendar
            // 
            pnlAgendar.BackColor = Color.FromArgb(35, 34, 37);
            pnlAgendar.Controls.Add(tblFormulario);
            pnlAgendar.Controls.Add(lblSub);
            pnlAgendar.Controls.Add(lblTitulo);
            pnlAgendar.Controls.Add(btnAgendar);
            pnlAgendar.Dock = DockStyle.Fill;
            pnlAgendar.Font = new Font("Segoe UI", 9F);
            pnlAgendar.Location = new Point(0, 0);
            pnlAgendar.Margin = new Padding(0);
            pnlAgendar.Name = "pnlAgendar";
            pnlAgendar.Padding = new Padding(14, 12, 14, 12);
            pnlAgendar.Size = new Size(261, 379);
            pnlAgendar.TabIndex = 0;
            pnlAgendar.Paint += pnlAgendar_Paint;
            // 
            // tblFormulario
            // 
            tblFormulario.ColumnCount = 1;
            tblFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFormulario.Controls.Add(lblServico, 0, 0);
            tblFormulario.Controls.Add(lblHorario, 0, 4);
            tblFormulario.Controls.Add(lblData, 0, 2);
            tblFormulario.Controls.Add(cbxData, 0, 3);
            tblFormulario.Controls.Add(cbxServico, 0, 1);
            tblFormulario.Controls.Add(cbxHorario, 0, 5);
            tblFormulario.Dock = DockStyle.Top;
            tblFormulario.Location = new Point(14, 64);
            tblFormulario.Margin = new Padding(2);
            tblFormulario.Name = "tblFormulario";
            tblFormulario.RowCount = 7;
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblFormulario.Size = new Size(233, 200);
            tblFormulario.TabIndex = 2;
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Dock = DockStyle.Top;
            lblServico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblServico.ForeColor = Color.FromArgb(178, 175, 182);
            lblServico.Location = new Point(2, 0);
            lblServico.Margin = new Padding(2, 0, 2, 0);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(229, 21);
            lblServico.TabIndex = 0;
            lblServico.Text = "Serviço";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHorario.ForeColor = Color.FromArgb(178, 175, 182);
            lblHorario.Location = new Point(2, 120);
            lblHorario.Margin = new Padding(2, 0, 2, 0);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(82, 25);
            lblHorario.TabIndex = 2;
            lblHorario.Text = "Horário";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblData.ForeColor = Color.FromArgb(178, 175, 182);
            lblData.Location = new Point(2, 60);
            lblData.Margin = new Padding(2, 0, 2, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(53, 25);
            lblData.TabIndex = 1;
            lblData.Text = "Data";
            // 
            // cbxData
            // 
            cbxData.Dock = DockStyle.Fill;
            cbxData.FormattingEnabled = true;
            cbxData.Location = new Point(2, 92);
            cbxData.Margin = new Padding(2);
            cbxData.Name = "cbxData";
            cbxData.Size = new Size(229, 23);
            cbxData.TabIndex = 4;
            // 
            // cbxServico
            // 
            cbxServico.Dock = DockStyle.Fill;
            cbxServico.FormattingEnabled = true;
            cbxServico.Items.AddRange(new object[] { "Cabelo", "Unhas", "Hidratação" });
            cbxServico.Location = new Point(2, 32);
            cbxServico.Margin = new Padding(2);
            cbxServico.Name = "cbxServico";
            cbxServico.Size = new Size(229, 23);
            cbxServico.TabIndex = 3;
            // 
            // cbxHorario
            // 
            cbxHorario.Dock = DockStyle.Top;
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Location = new Point(2, 152);
            cbxHorario.Margin = new Padding(2);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(229, 23);
            cbxHorario.TabIndex = 5;
            // 
            // lblSub
            // 
            lblSub.BackColor = Color.Transparent;
            lblSub.Dock = DockStyle.Top;
            lblSub.Font = new Font("Segoe UI", 10F);
            lblSub.ForeColor = Color.FromArgb(152, 149, 157);
            lblSub.Location = new Point(14, 37);
            lblSub.Margin = new Padding(2, 0, 2, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(233, 27);
            lblSub.TabIndex = 1;
            lblSub.Text = "Selecione o serviço, a data e informe o horário para criar o agendamento";
            lblSub.Click += lblSub_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(14, 12);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(234, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agende um atendimento";
            // 
            // btnAgendar
            // 
            btnAgendar.Dock = DockStyle.Bottom;
            btnAgendar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgendar.Location = new Point(14, 333);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(233, 34);
            btnAgendar.TabIndex = 6;
            btnAgendar.Text = "Agendar horário";
            btnAgendar.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            dgvDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(23, 68);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(305, 288);
            dgvDados.TabIndex = 2;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 24, 27);
            ClientSize = new Size(885, 409);
            Controls.Add(tblDivisao);
            Margin = new Padding(2);
            MinimumSize = new Size(901, 448);
            Name = "FormDashboard";
            Padding = new Padding(6, 5, 6, 5);
            Text = "Salão de Beleza-Agendamento";
            tblDivisao.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlAgendar.ResumeLayout(false);
            pnlAgendar.PerformLayout();
            tblFormulario.ResumeLayout(false);
            tblFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblDivisao;
        private Panel pnlAgendar;
        private Label lblSub;
        private Label lblTitulo;
        private TableLayoutPanel tblFormulario;
        private Label lblServico;
        private Label lblData;
        private Label lblHorario;
        private ComboBox cbxServico;
        private ComboBox cbxData;
        private ComboBox cbxHorario;
        private Button btnAgendar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblAgendamentos;
        private Label lblSubAgendamentos;
        private DataGridView dgvDados;
    }
}