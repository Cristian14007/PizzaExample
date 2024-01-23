using PizzaExample.Models;

namespace PizzaExample.Data
{
    public interface IPedidoRepository
    {
        List<Pedido> GetAll();
        void Add(Pedido pedido);
        Pedido Get(int id);
        void Update(Pedido pedido);
        void Delete (int id);


    }
}