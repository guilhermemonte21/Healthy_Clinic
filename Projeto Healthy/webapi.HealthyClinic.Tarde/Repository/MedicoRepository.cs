using webapi.HealthyClinic.Tarde.Context;
using webapi.HealthyClinic.Tarde.Domain;
using webapi.HealthyClinic.Tarde.Interface;

namespace webapi.HealthyClinic.Tarde.Repository
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthyContext _context;

        public void Atualizar(Guid id, Medico medico)
        {
            try
            {
                Medico doc = _context.Medico.Find(id)!;
                if (doc != null)
                {
                    doc.CRM = medico.CRM;
                    doc.IdUsuario = medico.IdUsuario;
                    doc.IdEspecialidade = medico.IdEspecialidade;
                }
                _context.Medico.Update(doc!);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Medico BuscarPorId(Guid id)
        {
            return _context.Medico.FirstOrDefault(x => x.IdMedico == id)!;
        }

        public void Cadastrar(Medico medico)
        {
            try
            {
                _context.Medico.Add(medico);
                _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public void Deletar(Guid id)
        {
            Medico m = _context.Medico.Find(id)!;
            if (m != null)
            {
                _context.Remove(m);
            }
            _context.SaveChanges();
        }

        public List<Medico> ListarTodos()
        {
            return _context.Medico.ToList();
        }
    }
}
    

