using webapi.HealthyClinic.Tarde.Domain;

namespace webapi.HealthyClinic.Tarde.Interface
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);
        void Deletar(Guid id);
        List<Usuario> Listar();
        Usuario BuscarPorEmailESenha(Guid id);

        Usuario BuscarPorId(Guid id);
        void Atualizar(Guid id, Usuario usuario);
    }
}
