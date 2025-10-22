using Agendamentos.API.Database;
using Agendamentos.Biblioteca;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agendamentos.API.Controllers;

[Route("[controller]")]
[ApiController]
public class RoleController(APIContext context) : ControllerBase
{
    private APIContext _context = context;

    [HttpPost]
    public async Task<IActionResult> RegisterRoleAsync()
    {
        await _context.Roles.AddAsync();
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(RegisterRoleAsync);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetRoleByIdAsync(int id)
    {
      Role result = await _context.Roles.FindAsync(id);
        if (result is null) return NotFound("Cliente não foi encontrado!");
        return Ok(result);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateRoletAsync([FromBody] Role request)
    {
        if (request.ID == null) return BadRequest();
        Role? result = await _context.Roles.FindAsync(request.ID);
        if (result == null) return NotFound();

        _context.Clients.Update(request);
        await _context.SaveChangesAsync();
        return Ok();

    }
    [HttpPatch("{id}")]
    public async Task<IActionResult> ToggleEmailFromRolesIdAsync(int Id)
    {
       Role result = await _context.Roles.FindAsync(Id);
        if (result is null) return NotFound("Cliente não deseja receber email!");
        result.CanReceiveEmail = !result.CanReceiveEmail;
        await _context.SaveChangesAsync();
        return NoContent();

    }
    [HttpDelete]
    public async Task<IActionResult> DeleteRoleByIdAsync(int Id)
    {
        Role? amendoim = await _context.Roles.FindAsync(Id);
        if (amendoim == null) return NotFound();
        _context.Remove(amendoim);
        await _context.SaveChangesAsync();
        return NoContent();
    }

}
