
namespace Agendamentos.Biblioteca;

public class Client : User
{
    public bool CanReceiveEmail { get; set; } = false;
    public List<Appointment> Appointments { get; set; } 

    public Client() : base() { }

    public Client(string name, string email, string phone, DateOnly birth, bool CanReceiveEmail) : base(name, email, phone, birth)
    {
        this.CanReceiveEmail = CanReceiveEmail;
    }


    public Client(string name, string email, string phone, DateOnly birth, bool CanReceiveEmail, Address address, string description, int id) : base(name, email, phone, birth, address, description, id)
    {

        this.CanReceiveEmail = CanReceiveEmail;
    }

}

