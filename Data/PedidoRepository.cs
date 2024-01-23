
using PizzaExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaExample.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        private  List<Pedido> Pedidos { get; set; }
        private  int nextId = 3;

        public PedidoRepository()
        {
            Pedidos = new List<Pedido>
            {
                new Pedido
            {
                Id = 1,
                Precio = 15,
                Cliente = new Usuario{
                     Id = 1, Nombre = "Juan Perez", Direccion = "Calle 123, Ciudad", Edad = 18
                },
                 Pizzas = new List<Pizza>
                {
                    new Pizza{Id = 1,
                Name = "Classic Italian",
                IsGlutenFree = false,
                Ingredientes = new List<Ingrediente>
                {
                    new Ingrediente { Id = 1, Nombre = "Pepperoni", Origen = "Animal" },
                    new Ingrediente { Id = 2, Nombre = "Olivas", Origen = "Vegetal" }
                }}
                
            } 
            },
                new Pedido {
                Id = 2,
                Precio = 12,
                Cliente = new Usuario{
                     Id = 2, Nombre = "Maria Rodriguez", Direccion = "Avenida 456, Otra Ciudad", Edad = 22
                },
                Pizzas = new List<Pizza>
                {
                    new Pizza{Id = 1,
                Name = "Classic Italian",
                IsGlutenFree = false,
                Ingredientes = new List<Ingrediente>
                {
                    new Ingrediente { Id = 1, Nombre = "Pepperoni", Origen = "Animal" },
                    new Ingrediente { Id = 2, Nombre = "Olivas", Origen = "Vegetal" }
                }}
                
            }
            }
            };

        }

        public  List<Pedido> GetAll()
        {
            return Pedidos;
        }

        public  Pedido Get(int id)
        {
            return Pedidos.FirstOrDefault(p => p.Id == id);
        }

        public  void Add(Pedido pedido)
        {
            pedido.Id = nextId++;
            Pedidos.Add(pedido);
        }

        public  void Update(Pedido pedido)
        {
            var index = Pedidos.FindIndex(p => p.Id == pedido.Id);
            if (index != -1)
            {
                Pedidos[index] = pedido;
            }
        }

        public  void Delete(int id)
        {
            var pedido = Get(id);
            if (pedido != null)
            {
                Pedidos.Remove(pedido);
            }
        }
    }
}
