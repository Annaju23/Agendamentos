using Microsoft.EntityFrameworkCore;
using salaoBeleza.Desktop.Banco_de_Dados;
using salaoBeleza.Desktop.Modelos;
using salaoBeleza.Desktop.Servicos;

namespace salaoBeleza.Desktop;

public partial class FormCadatros : Form
{

    public FormCadatros()
    {
        InitializeComponent();
    }

    private void FecharCadastro(object sender, EventArgs e)
    {
        this.Close();
    }
    private void CadastroUsuario(object sender, EventArgs e)
    {
        List<TextBox> camposParaValidar = [txtSenha, txtComfimacao , txtEmail, txtNome];
        foreach (var campo in camposParaValidar)
        {
           if (string.IsNullOrWhiteSpace(campo.Text))
            {
                MessageBox.Show("Ainda existem campos vazios que preciam ser preenchidos.", "Erro de validação");
                campo.Focus();
                return;
            }
        }
        {
            MessageBox.Show("Erro ao salvar informações de banco de dados");
        }

        if (!txtSenha.Text.Equals(txtComfimacao.Text))
        {
            MessageBox.Show("As senhas digitadas não são iguais.", "Erro de validação!");
            txtComfimacao.Focus();
            return;
        }
        Usuario novoUsuario = new()
        {
            NomeCompleto = txtNome.Text,
            Email = txtEmail.Text,
            Senha = txtSenha.Text,
        };

        try
        {
            UsuarioServicos userServicos = new(new SalaoBelezaContext());
            userServicos.AdicionarUsuario(novoUsuario);
        }
        catch (DbUpdateConcurrencyException)
        {
            MessageBox.Show("Usuario não pode ser salvo no banco de dados");
        }
        catch (DbUpdateException)
        {
            MessageBox.Show("Erro ao salvar informações de banco de dados");
        }

        foreach (var campo in camposParaValidar)
        {
            campo.Text = string.Empty;
        }                  

    }

}