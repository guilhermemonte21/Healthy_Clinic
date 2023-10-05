using webapi.HealthyClinic.Tarde.Context;
using webapi.HealthyClinic.Tarde.Domain;
using webapi.HealthyClinic.Tarde.Interface;

namespace webapi.HealthyClinic.Tarde.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthyContext _context;
        public UsuarioRepository()
        {
            _context= new HealthyContext();
        }
        public void Atualizar(Guid id, Usuario usuario)
        {
            try
            {
                Usuario user = _context.Usuario.Find(id)!;
                if (user != null)
                {
                    user.NomeUsuario = usuario.NomeUsuario;
                    user.CPF = usuario.CPF;
                    user.Email= usuario.Email;
                    user.Senha= usuario.Senha;
                }
                _context.Usuario.Update(user!);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorEmailESenha(Guid id)
        {
            throw new NotImplementedException();
        }

        public  Usuario BuscarPorId(Guid id)
        {
            return _context.Usuario.FirstOrDefault(x => x.IdUsuario == id)!;
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public void Deletar(Guid id)
        {
            Usuario u = _context.Usuario.Find(id)!;
            if (u != null)
            {
                _context.Remove(u);
            }
            _context.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            try
            {
                return _context.Usuario.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
