using canciones.Data;
using canciones.Entidad;
using Microsoft.EntityFrameworkCore;


namespace canciones.Repositorios
{
    public class CancionRepositorio : ICancionRepositorio
    {
        private readonly DataContext _contexto;

        public CancionRepositorio(DataContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<Canciones>> GetAllCanciones()
        {
            var song = await _contexto.canciones.ToListAsync();
            return song;
        }
    }
}
