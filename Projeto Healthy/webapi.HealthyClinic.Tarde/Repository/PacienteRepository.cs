using webapi.HealthyClinic.Tarde.Context;
using webapi.HealthyClinic.Tarde.Domain;
using webapi.HealthyClinic.Tarde.Interface;

namespace webapi.HealthyClinic.Tarde.Repository
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthyContext _context;
        public void Atualizar(Guid id, Paciente paciente)
        {
            try
            {
                Paciente p = _context.Paciente.Find(id)!;
                if (p != null)
                {
                    p.IdUsuario = paciente.IdUsuario;
                }
                _context.Paciente.Update(p!);
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

        public void Cadastrar(Paciente paciente)
        {
            try
            {
                _context.Paciente.Add(paciente);
                _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public void Deletar(Guid id)
        {
            Paciente p= _context.Paciente.Find(id)!;
            if (p != null)
            {
                _context.Remove(p);
            }
            _context.SaveChanges();
        }
    }
}
