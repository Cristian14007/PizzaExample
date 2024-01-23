using PizzaExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaExample.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private List<Usuario> Usuarios { get; set; }
        private int nextId = 3;

        public UsuarioRepository()
        {
            Usuarios = new List<Usuario>
            {
                new Usuario { Id = 1, Nombre = "Juan Perez", Direccion = "Calle 123, Ciudad", Edad = 18},
                new Usuario { Id = 2, Nombre = "Maria Rodriguez", Direccion = "Avenida 456, Otra Ciudad", Edad = 22 }
            };
        }

        public List<Usuario> GetAll()
        {
            return Usuarios;
        }

        public Usuario Get(int id)
        {
            return Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public void Add(Usuario usuario)
        {
            usuario.Id = nextId++;
            Usuarios.Add(usuario);
        }

        public void Update(Usuario usuario)
        {
            var index = Usuarios.FindIndex(u => u.Id == usuario.Id);
            if (index != -1)
            {
                Usuarios[index] = usuario;
            }
        }

        public void Delete(int id)
        {
            var usuario = Get(id);
            if (usuario != null)
            {
                Usuarios.Remove(usuario);
            }
        }
    }
}
