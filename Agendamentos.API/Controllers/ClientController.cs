using Agendamentos.Biblioteca;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agendamentos.API.Controllers;

[Route("[controller]")] // Anotação para definir a rota do controlador
[ApiController]
public class ClientController : ControllerBase
{
    [HttpPost]
    public IActionResult RegisterClient([FromBody]Client request)
    {
        return Created();
    }

    [HttpGet("{id}")] 
    public IActionResult GetClientByID(int id)
    {
        return Ok(new
        {
            Message = id
        });
    }
}
