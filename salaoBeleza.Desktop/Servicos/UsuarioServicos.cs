using Microsoft.EntityFrameworkCore;
using salaoBeleza.Desktop.Banco_de_Dados;
using salaoBeleza.Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

}

