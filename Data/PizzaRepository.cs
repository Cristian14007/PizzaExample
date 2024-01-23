
using PizzaExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaExample.Data
{
    public class PizzaRepository : IPizzaRepository
    {
        private  List<Pizza> Pizzas { get; set; }
        private  int nextId = 3;

        public PizzaRepository()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza
            {
                Id = 1,
                Name = "Classic Italian",
                IsGlutenFree = false,
                Ingredientes = new List<Ingrediente>
                {
                    new Ingrediente { Id = 1, Nombre = "Pepperoni", Origen = "Animal" },
                    new Ingrediente { Id = 2, Nombre = "Olivas", Origen = "Vegetal" }
                }
            },
                new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true, Ingredientes = new List<Ingrediente>
                {
                    new Ingrediente { Id = 3, Nombre = "Salchichon", Origen = "Animal" },
                    new Ingrediente { Id = 4, Nombre = "Cebolla", Origen = "Vegetal" }
                }}
            };

        }

        public  List<Pizza> GetAll()
        {
            return Pizzas;
        }

        public  Pizza Get(int id)
        {
            return Pizzas.FirstOrDefault(p => p.Id == id);
        }

        public  void Add(Pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        public  void Update(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if (index != -1)
            {
                Pizzas[index] = pizza;
            }
        }

        public  void Delete(int id)
        {
            var pizza = Get(id);
            if (pizza != null)
            {
                Pizzas.Remove(pizza);
            }
        }
    }
}
