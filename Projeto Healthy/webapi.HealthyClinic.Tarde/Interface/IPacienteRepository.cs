using webapi.HealthyClinic.Tarde.Domain;

namespace webapi.HealthyClinic.Tarde.Interface
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);
        void Deletar(Guid id);

        Consulta BuscarPorId(Guid id);
        void Atualizar(Guid id, Paciente paciente);
    }
}
