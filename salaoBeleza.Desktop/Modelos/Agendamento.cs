using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaoBeleza.Desktop.Modelos;

internal class Agendamento
{
    public  int id {  get; set; }
    public int ServicoId { get; set; }
    public int UsuarioId { get; set; }
    public int funcionarioId { get; set; }
    public DateTime AgendamentoEm {  get; set; }
}
