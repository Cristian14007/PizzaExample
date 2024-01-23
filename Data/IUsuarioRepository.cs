using PizzaExample.Models;

namespace PizzaExample.Data
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        void Add(Usuario usuario);
        Usuario Get(int id);
        void Update(Usuario usuario);
        void Delete (int id);


    }
}