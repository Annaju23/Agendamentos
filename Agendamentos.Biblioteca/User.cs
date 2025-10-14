namespace Agendamentos.Biblioteca;

public abstract class User
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateOnly Birth { get; set; }
    public string? Description { get; set; }  
    public Address? Address { get; set; }
    // Construtor minimo - Contem as informações obrigatórias
    protected User(string nome, string email, string telefone, DateOnly nascimento)
    {
        this.Name = nome;
        this.Email = email;
        this.Phone = telefone;
        this.Birth = nascimento;
      
    }
    // Construtor total - Contem todas as informações
    protected User(string nome, string email, string telefone, DateOnly nascimento, Address endereco, string descricao, int id )
        :this(nome, email, telefone, nascimento)
    {
       this.ID = id;
       this.Description = descricao;
       this.Address = endereco;
    }

    protected User()
    {
    }
}
