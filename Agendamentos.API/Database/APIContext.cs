using Agendamentos.Biblioteca;
using Microsoft.EntityFrameworkCore;

namespace Agendamentos.API.Database;

public class APIContext(DbContextOptions optionsBuilder) : DbContext(optionsBuilder)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configurando chave primária 
        modelBuilder.Entity<Client>().HasKey(c => c.ID);
        modelBuilder.Entity<Employee>().HasKey(e => e.ID);
        modelBuilder.Entity<Service>().HasKey(s => s.ID);
        modelBuilder.Entity<Role>().HasKey(r => r.ID);
        modelBuilder.Entity<Appointment>().HasKey(a => a.id);
        modelBuilder.Entity<Address>().HasKey(ad => ad.ID);
        
        //Configurar as colunas 
        modelBuilder.Entity<Client>().HasIndex(c => c.Email).IsUnique();
        modelBuilder.Entity<Client>().HasIndex(c => c.Phone).IsUnique();
        modelBuilder.Entity<Employee>().HasIndex(e => e.Email).IsUnique();
        modelBuilder.Entity<Employee>().HasIndex(e => e.Phone).IsUnique();
        modelBuilder.Entity<Role>().HasIndex(r => r.Name).IsUnique();
        modelBuilder.Entity<Service>().HasIndex(s => s.Name).IsUnique();

        //Configurar as colunas nâo nulas

        //configura chaves estrangeiras

        modelBuilder.Entity<Employee>().HasOne(e => e.Role).WithMany(r => r.Employees).HasForeignKey(e => e.RoleID);
        modelBuilder.Entity<Appointment>().HasOne(a => a.Client).WithMany(c => c.Appointments).HasForeignKey(a =>a.ClientID);
        modelBuilder.Entity<Appointment>().HasOne(a => a.Employee).WithMany(e => e.Appointments).HasForeignKey(a =>a.EmployeeID);
        modelBuilder.Entity<Appointment>().HasOne(a => a.Service).WithMany(s => s.Appointments).HasForeignKey(a =>a.ServiceID);
    }

   // toda migração precisa que o banco de dados esteja rodando ou seja abra o banco de dados (Xamp) é exemplo de um banco de dados que pode ser usado
}
