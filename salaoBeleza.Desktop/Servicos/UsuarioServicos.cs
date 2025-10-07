using salaoBeleza.Desktop.Banco_de_Dados;
using salaoBeleza.Desktop.Modelos;

namespace salaoBeleza.Desktop.Servicos;

internal class UsuarioServicos
{
    private SalaoBelezaContext _context;

    public UsuarioServicos(SalaoBelezaContext context)
    {
        _context = context;
    }
    // Criar um metodo public AdicionarUsuario que recebe um parametro do tipo Usuario. 
    public void AdicionarUsuario(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        MessageBox.Show("Usuario adicionado com sucesso.", "Sucesso no cadastro");
    }

    public Usuario ObterUsuario(string email, string senha)
    {
        Usuario? usuario  = _context.Usuarios.FirstOrDefault(u => u.Email.Equals(email));
        if (usuario == null)
        {
           throw new Exception ("Usuario não foi encontrado!");
        }
        if (!usuario.Senha.Equals(senha))
        {
            throw new Exception("Email ou senha estão errados!");
        }
        return usuario;
    }
}

