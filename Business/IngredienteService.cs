
using PizzaExample.Models;
using PizzaExample.Data;


namespace PizzaExample.Business
{
    public class IngredienteService
    {

        private readonly IngredientesRepository _ingredienteRepository;

        public IngredienteService(IngredientesRepository ingredientesRepository){
            _ingredienteRepository = ingredientesRepository;
        }
        public  List<Ingrediente> GetAll()
        {
            return _ingredienteRepository.GetAll();
        }

        public  Ingrediente Get(int id)
        {
            return _ingredienteRepository.Get(id);
        }
          

    public  void Add(Ingrediente ingrediente)
    {
        _ingredienteRepository.Add(ingrediente);
    }

    public  void Update(Ingrediente ingrediente)
    {
        _ingredienteRepository.Update(ingrediente);
    }

    public  void Delete(int id)
    {
        _ingredienteRepository.Delete(id);
    }
}


        
    }

