using webapi.HealthyClinic.Tarde.Context;
using webapi.HealthyClinic.Tarde.Domain;
using webapi.HealthyClinic.Tarde.Interface;

namespace webapi.HealthyClinic.Tarde.Repository
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthyContext _context;
        public void Atualizar(Guid id, Consulta consulta)
        {
            try
            {
                Consulta m = _context.Consulta.Find(id)!;
                if (m != null)
                {

                    m.Descricao = consulta.Descricao;
                    m.Clinica = consulta.Clinica;
                    m.Medico = consulta.Medico;
                }
                _context.Consulta.Update(m!);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Consulta BuscarPorId(Guid id)
        {
            return _context.Consulta.FirstOrDefault(x => x.IdConsulta == id)!;
        }

        public void Cadastrar(Consulta consulta)
        {
            try
            {
                _context.Consulta.Add(consulta);
                _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public void Deletar(Guid id)
        {
            Consulta con = _context.Consulta.Find(id)!;
            if (con != null)
            {
                _context.Remove(con);
            }
            _context.SaveChanges();
        }

        public List<Consulta> ListarMedico()
        {
            try
            {
                List<Consulta> list = new List<Consulta>();
                foreach (Consulta c in _context.Consulta)
                {
                    if (c.IdMedico == id)
                    {
                        list.Add(c);
                    }
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Consulta> ListarPacientes()
        {
            try
            {
                List<Consulta> list = new List<Consulta>();
                foreach (Consulta c in _context.Consulta)
                {
                    if (c.IdPaciente == id)
                    {
                        list.Add(c);
                    }
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Consulta> ListarTodos()
        {
            return _context.Consulta.ToList();
        }
    }
}
