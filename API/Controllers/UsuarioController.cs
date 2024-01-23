using PizzaExample.Models;
using PizzaExample.Business;
using Microsoft.AspNetCore.Mvc;

namespace PizzaExample.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly UsuarioService _usuarioService;
    public UsuarioController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet]
public ActionResult<List<Usuario>> GetAll() =>
    _usuarioService.GetAll();

    [HttpGet("{id}")]
public ActionResult<Usuario> Get(int id)
{
    var usuario = _usuarioService.Get(id);

    if(usuario == null)
        return NotFound();

    return usuario;
}

    [HttpPost]
public IActionResult Create(Usuario usuario)
{            
    _usuarioService.Add(usuario);
    return CreatedAtAction(nameof(Get), new { id = usuario.Id }, usuario);
}
[HttpPut("{id}")]
public IActionResult Update(int id, Usuario usuario)
{
    if (id != usuario.Id)
        return BadRequest();
           
    var existingUsuario = _usuarioService.Get(id);
    if(existingUsuario is null)
        return NotFound();
   
    _usuarioService.Update(usuario);           
   
    return NoContent();
}

    [HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    var usuario = _usuarioService.Get(id);
   
    if (usuario is null)
        return NotFound();
       
    _usuarioService.Delete(id);
   
    return NoContent();
}
}