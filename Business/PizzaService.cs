
using PizzaExample.Models;
using PizzaExample.Data;


namespace PizzaExample.Business
{
    public class PizzaService 
    {

        private readonly IPizzaRepository _pizzaRepository;

        public PizzaService(IPizzaRepository pizzaRepository){
            _pizzaRepository = pizzaRepository;
        }
        public  List<Pizza> GetAll()
        {
            return _pizzaRepository.GetAll();
        }

        public  Pizza Get(int id)
        {
            return _pizzaRepository.Get(id);
        }
          

    public  void Add(Pizza pizza)
    {
        _pizzaRepository.Add(pizza);
    }

    public  void Update(Pizza pizza)
    {
        _pizzaRepository.Update(pizza);
    }

    public  void Delete(int id)
    {
        _pizzaRepository.Delete(id);
    }
}


        
    }

