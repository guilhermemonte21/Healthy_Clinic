using webapi.HealthyClinic.Tarde.Context;
using webapi.HealthyClinic.Tarde.Domain;
using webapi.HealthyClinic.Tarde.Interface;

namespace webapi.HealthyClinic.Tarde.Repository
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HealthyContext _context;

        public void Atualizar(Guid id, Especialidade especialidade)
        {
            try
            {
                Especialidade m = _context.Especialidade.Find(id)!;
                if (m != null)
                {

                    m.Titulo = especialidade.Titulo;
                }
                _context.Especialidade.Update(m!);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Especialidade especialidade)
        {
            try
            {
                _context.Especialidade.Add(especialidade);
                _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public void Deletar(Guid id)
        {
            Especialidade e = _context.Especialidade.Find(id)!;
            if (e != null)
            {
                _context.Remove(e);
            }
            _context.SaveChanges();
        }
    }
}
