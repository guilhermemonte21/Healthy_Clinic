using webapi.HealthyClinic.Tarde.Domain;

namespace webapi.HealthyClinic.Tarde.Interface
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);
        void Deletar(Guid id);
        void Atualizar(Guid id, Especialidade medico);
    }
}
