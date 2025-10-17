namespace Agendamentos.Biblioteca;

public class Service
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public List<Appointment> Appointments { get; set; }
    public Service() { }
    protected Service(int id, string name, string? deacription, decimal price)
    {
        this.ID = id;
        this.Name = name;
        this.Description = deacription;
        this.Price = price;
    }
}
