namespace PizzaExample.Models;

public class Pedido
{
    public int Id { get; set; }
    public decimal Precio { get; set; }
    public Usuario Cliente { get; set; }
    public List<Pizza> Pizzas { get; set; }

}