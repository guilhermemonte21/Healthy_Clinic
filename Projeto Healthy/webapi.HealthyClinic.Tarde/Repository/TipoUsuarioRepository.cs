using webapi.HealthyClinic.Tarde.Context;
using webapi.HealthyClinic.Tarde.Domain;
using webapi.HealthyClinic.Tarde.Interface;

namespace webapi.HealthyClinic.Tarde.Repository
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly HealthyContext _context;
        public void Atualizar(Guid id, TipoUsuario tipousuario)
        {
            try
            {
                TipoUsuario Tu = _context.TipoUsuario.Find(id)!;
                if (Tu != null)
                {
                    Tu.IdTipoUsuario = tipousuario.IdTipoUsuario;
                    Tu.Titulo = tipousuario.Titulo;
                }
                _context.TipoUsuario.Update(Tu!);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TipoUsuario tipousuario)
        {
            try
            {
                _context.TipoUsuario.Add(tipousuario);
                _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }
    }
}
