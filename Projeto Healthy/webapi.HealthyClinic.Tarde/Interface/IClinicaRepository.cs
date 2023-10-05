using webapi.HealthyClinic.Tarde.Domain;

namespace webapi.HealthyClinic.Tarde.Interface
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica comentarioEvento);
        void Atualizar(Guid id, Clinica clinica);
        
    }
}
