using System.Data;

namespace Agendamentos.Biblioteca;

public class Appointment
{
    public int id { get; set; }
    public int Client { get; set; }
    public Client ClientID { get; set; }
    public int EmployeeID { get; set; }
    public Employee Employee { get; set; }
    public int ServiceID { get; set; }
    public Service Service { get; set; }
    public DateTime ScheduledAt { get; set; }

    public Appointment(Client client, Employee employee, Service service, DateTime scheduledAt)
    {
       this.ClientID = client;
       this.Employee = employee;
       this.Service = service;
       this.ScheduledAt = scheduledAt;
    }
    
    public Appointment( Client client, Employee employee, Service service, DateTime scheduledAt, int id): this(client, employee, service, scheduledAt)
    {
       this.id = id;
    }
}
