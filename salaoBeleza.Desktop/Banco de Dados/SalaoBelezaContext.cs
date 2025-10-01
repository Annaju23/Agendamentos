using Microsoft.EntityFrameworkCore;
using salaoBeleza.Desktop.Modelos;

namespace salaoBeleza.Desktop.Banco_de_Dados;

internal class SalaoBelezaContext:DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Funcionarios> Funcionarios { get; set; }
    public DbSet<servico> Servicos { get; set; }
    public DbSet<Agendamentos> Agendamentos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string textoConexao = "server=localhost; user=root; password=; database=salaobeleza";
        optionsBuilder.UseMySql(textoConexao, ServerVersion.AutoDetect(textoConexao));
    }
}
