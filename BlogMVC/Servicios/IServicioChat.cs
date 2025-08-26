

namespace BlogMVC.Servicios
{
    public interface IServicioChat
    {
        Task<string> GenerarCuerpo(string titulo);
        IAsyncEnumerable<string> GenerarCuerpoString(string titulo);
    }
}