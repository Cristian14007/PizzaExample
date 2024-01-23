using PizzaExample.Models;
using PizzaExample.Business;
using Microsoft.AspNetCore.Mvc;

namespace PizzaExample.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    private readonly PedidoService _pedidoService;
    public PedidoController(PedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }

    [HttpGet]
public ActionResult<List<Pedido>> GetAll() =>
    _pedidoService.GetAll();

    [HttpGet("{id}")]
public ActionResult<Pedido> Get(int id)
{
    var pedido = _pedidoService.Get(id);

    if(pedido == null)
        return NotFound();

    return pedido;
}

    [HttpPost]
public IActionResult Create(Pedido pedido)
{            
    _pedidoService.Add(pedido);
    return CreatedAtAction(nameof(Get), new { id = pedido.Id }, pedido);
}
[HttpPut("{id}")]
public IActionResult Update(int id, Pedido pedido)
{
    if (id != pedido.Id)
        return BadRequest();
           
    var existingPedido = _pedidoService.Get(id);
    if(existingPedido is null)
        return NotFound();
   
    _pedidoService.Update(pedido);           
   
    return NoContent();
}

    [HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    var pedido = _pedidoService.Get(id);
   
    if (pedido is null)
        return NotFound();
       
    _pedidoService.Delete(id);
   
    return NoContent();
}
}