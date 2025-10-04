namespace salaoBeleza.Desktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void CadastrarUsuarios(object sender, EventArgs e)
        {
            new FormCadatros().ShowDialog();
        }
    }
}
