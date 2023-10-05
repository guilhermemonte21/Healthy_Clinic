using webapi.HealthyClinic.Tarde.Domain;

namespace webapi.HealthyClinic.Tarde.Interface
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);
        void Deletar(Guid id);
        List<Medico> ListarTodos();

        Medico BuscarPorId(Guid id);
        void Atualizar(Guid id,Medico medico);
    }
}
