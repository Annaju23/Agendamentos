using System.Reflection.PortableExecutable;

namespace Agendamentos.Biblioteca;

internal class Role
{
    public int ID { get; set; }
    public string Name { get; set; }

    public Role(string name)
    {
        this.Name = name;
    }

    public Role(string name, int id) : this(name)
    {
        this.ID = id;
    }
}
