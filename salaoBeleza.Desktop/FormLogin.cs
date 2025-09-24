namespace salaoBeleza.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CadastrarUsuarios(object sender, EventArgs e)
        {
            new FormCadatros().ShowDialog();
        }
    }
}
