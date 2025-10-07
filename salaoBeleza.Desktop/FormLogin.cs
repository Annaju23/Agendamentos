using salaoBeleza.Desktop.Banco_de_Dados;
using salaoBeleza.Desktop.Modelos;
using salaoBeleza.Desktop.Servicos;

namespace salaoBeleza.Desktop;

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

    private void AutenticarUsuario()
    {
        List<TextBox> campos = [txtEmail, txtSenha];
        campos.ForEach(campo =>
        {
            if(string.IsNullOrWhiteSpace(campo.Text))
            {
                MessageBox.Show("Existem campos sem informação, preencha-os.", "Faltando informação");
                return;
            }
        });

        UsuarioServicos usuarioServicos = new(new SalaoBelezaContext());
        Usuario usuario = usuarioServicos.ObterUsuario(txtEmail.Text, txtSenha.Text);
        new FormDashboard(usuario).ShowDialog();
        // criamos o objeto e acessamos uma propriedade atraves do ponto .

        
   
    }
}
