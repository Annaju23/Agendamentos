using System.Reflection.PortableExecutable;

namespace Agendamentos.Biblioteca;

public class Role
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }

    public Role(string name)
    {
        this.Name = name;
    }

    public Role(string name, int id) : this(name)
    {
        this.ID = id;
    }
}
