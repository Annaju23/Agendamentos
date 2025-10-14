namespace Agendamentos.Biblioteca;

public class Service
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }

    protected Service(int id, string name, string deacription, string price)
    {
        this.ID = id;
        this.Name = name;
        this.Description = deacription;
        this.Price = price;
    }
}
