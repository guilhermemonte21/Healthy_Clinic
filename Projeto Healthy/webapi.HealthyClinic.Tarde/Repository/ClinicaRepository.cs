using webapi.HealthyClinic.Tarde.Context;
using webapi.HealthyClinic.Tarde.Domain;
using webapi.HealthyClinic.Tarde.Interface;

namespace webapi.HealthyClinic.Tarde.Repository
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthyContext _context;

        public ClinicaRepository()
        {
            _context= new HealthyContext();
        }
        public void Atualizar(Guid id, Clinica clinica)
        {
            try
            {
                Clinica m = _context.Clinica.Find(id)!;
                if (m != null)
                {

                    m.CNPJ = clinica.CNPJ;
                    m.NomeFantasia = clinica.NomeFantasia;
                    m.HorarioFuncionamento = clinica.HorarioFuncionamento;
                    m.Endereco = clinica.Endereco;
                }
                _context.Clinica.Update(m!);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Clinica comentarioEvento)
        {
            try
            {
                _context.Clinica.Add(comentarioEvento);
                _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }
    }
}
