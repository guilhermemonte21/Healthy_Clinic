using webapi.HealthyClinic.Tarde.Domain;

namespace webapi.HealthyClinic.Tarde.Interface
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);
        void Atualizar(Guid id,Comentario comentario);
        void Deletar(Guid id);
        List<Comentario> ListarTodos();
        List<Comentario> ListarMeus(Guid id);
        Clinica BuscarPorUsuario(Guid id);
    }
}
