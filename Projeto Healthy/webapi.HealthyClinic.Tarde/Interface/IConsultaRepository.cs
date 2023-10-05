using webapi.HealthyClinic.Tarde.Domain;

namespace webapi.HealthyClinic.Tarde.Interface
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);
        void Deletar(Guid id);
        List<Consulta> ListarMedico();
        List<Consulta> ListarTodos();
        List<Consulta> ListarPacientes();

        Consulta BuscarPorId(Guid id);
        void Atualizar(Guid id, Consulta consulta);
    }
}
