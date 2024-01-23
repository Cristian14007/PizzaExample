
using PizzaExample.Models;
using PizzaExample.Data;


namespace PizzaExample.Business
{
    public class PedidoService 
    {

        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository){
            _pedidoRepository = pedidoRepository;
        }
        public  List<Pedido> GetAll()
        {
            return _pedidoRepository.GetAll();
        }

        public  Pedido Get(int id)
        {
            return _pedidoRepository.Get(id);
        }
          

    public  void Add(Pedido pedido)
    {
        _pedidoRepository.Add(pedido);
    }

    public  void Update(Pedido pedido)
    {
        _pedidoRepository.Update(pedido);
    }

    public  void Delete(int id)
    {
        _pedidoRepository.Delete(id);
    }
}


        
    }

