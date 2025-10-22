using Agendamentos.API.Database;
using Agendamentos.Biblioteca;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agendamentos.API.Controllers;

[Route("[controller]")] // Anotação para definir a rota do controlador
[ApiController]
public class ClientController(APIContext context) : ControllerBase
{
    private APIContext _context = context;
    [HttpPost]
    public async Task<IActionResult> RegisterClientAsync([FromBody] Client request)
    {
        await _context.Clients.AddAsync(request);
        _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetClientByIDAsync), new { id = request.ID });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetClientByIDAsync(int id)
    {
        //Vai procurar o cliente pelo id aqui
        // _context.Clients.Find()
        //Se não tiver usuario 404 Not Found
        Client? result = await _context.Clients.FindAsync(id);
        if (result is null) return NotFound("Cliente não foi encontrado!");
        return Ok(result);

    }
    [HttpPut]
    public async Task<IActionResult> UpdateClientAsync([FromBody] Client request)
    {
        if (request.ID == null) return BadRequest();
        Client? result = await _context.Clients.FindAsync(request.ID);
        if (result == null) return NotFound();

        _context.Clients.Update(request);
        await _context.SaveChangesAsync();
        return Ok();

    }
    // Crie os metodos abaixo com melhor retorno aplicavel
    //HTTP PUT 200 OK | 204 no content UpdateClientAsync()
    //HTTP PATCH 204 no content | 200 OK ToggleEmailFromClientIdAsync
    //DELETE 204 no content DeleteClienteByIdAsync()


    [HttpPatch("{id}")]
    public async Task<IActionResult> ToggleEmailFromClientIdAsync (int Id)
    {
        Client? result = await _context.Clients.FindAsync(Id);
        if (result is null) return NotFound("Cliente não deseja receber email!");
        result.CanReceiveEmail = !result.CanReceiveEmail;
        await _context.SaveChangesAsync();
        return NoContent();

    }
    [HttpDelete("{Id}")]
    public async Task<IActionResult> DeleteClienteByIdAsync(int Id)
    {
        Client? client = await _context.Clients.FindAsync(Id);
        if (client == null) return NotFound();
        _context.Remove(client);
        await _context.SaveChangesAsync();
        return NoContent();
    }




}
