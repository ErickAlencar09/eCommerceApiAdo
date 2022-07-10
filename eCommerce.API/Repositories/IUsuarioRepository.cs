using eCommerce.API.Models;

namespace eCommerce.API.Repositories
{
    public interface IUsuarioRepository
    {
        public List<Usuario> Get();
        public Usuario GetById(int id);
        public void Update(Usuario usuario);
        public void Insert(Usuario usuario);
        public void Delete(int id);

    }
}
