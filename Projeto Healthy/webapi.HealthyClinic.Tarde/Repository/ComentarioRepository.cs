using webapi.HealthyClinic.Tarde.Context;
using webapi.HealthyClinic.Tarde.Domain;
using webapi.HealthyClinic.Tarde.Interface;

namespace webapi.HealthyClinic.Tarde.Repository
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthyContext _context;

        public void Atualizar(Guid id, Comentario comentario)
        {
            try
            {
                Comentario m = _context.Comentario.Find(id)!;
                if (m != null)
                {

                    m.ComentarioConsulta = comentario.ComentarioConsulta;
                }
                _context.Comentario.Update(m!);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Clinica BuscarPorUsuario(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Comentario comentario)
        {
            try
            {
                _context.Comentario.Add(comentario);
                _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public void Deletar(Guid id)
        {
            Comentario com = _context.Comentario.Find(id)!;
            if (com != null)
            {
                _context.Remove(com);
            }
            _context.SaveChanges();
        }

        public List<Comentario> ListarMeus(Guid id)
        {
            Paciente p = _context.Paciente.Find(id)!;
            List<Comentario> list = new List<Comentario>();

            foreach (Comentario com in _context.Comentario)
            {
                if (com.Consulta!.IdPaciente == p.IdPaciente)
                {
                    list.Add(com);
                }
            }
            return list;
        }

        public List<Clinica> ListarTodos()
        {
            return _context.Clinica.ToList();
        }
    }
}
