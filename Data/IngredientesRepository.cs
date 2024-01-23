
using PizzaExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaExample.Data
{
    public class IngredientesRepository : IIngredientesRepository
    {
        private  List<Ingrediente> Ingredientes { get; set; }
        private  int nextId = 5;

        public IngredientesRepository()
        {
            Ingredientes = new List<Ingrediente>
            {
                new Ingrediente { Id = 1, Nombre = "Pepperoni", Origen = "Animal" },
                new Ingrediente { Id = 2, Nombre = "Olivas", Origen = "Vegetal" },
                new Ingrediente { Id = 3, Nombre = "Salchichon", Origen = "Animal" },
                new Ingrediente { Id = 4, Nombre = "Cebolla", Origen = "Vegetal" }
            };
        }

        public  List<Ingrediente> GetAll()
        {
            return Ingredientes;
        }

        public  Ingrediente Get(int id)
        {
            return Ingredientes.FirstOrDefault(p => p.Id == id);
        }

        public  void Add(Ingrediente ingrediente)
        {
            ingrediente.Id = nextId++;
            Ingredientes.Add(ingrediente);
        }

        public  void Update(Ingrediente ingrediente)
        {
            var index = Ingredientes.FindIndex(p => p.Id == ingrediente.Id);
            if (index != -1)
            {
                Ingredientes[index] = ingrediente;
            }
        }

        public  void Delete(int id)
        {
            var ingrediente = Get(id);
            if (ingrediente != null)
            {
                Ingredientes.Remove(ingrediente);
            }
        }
    }
}
