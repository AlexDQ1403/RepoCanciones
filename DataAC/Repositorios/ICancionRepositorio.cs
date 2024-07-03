

using canciones.Entidad;

namespace canciones.Repositorios
{
    public interface ICancionRepositorio
    {
       Task< List<Canciones>> GetAllCanciones();
    }
}
