using canciones.Contexto;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace canciones.entity
{
    public class Cancionesentity
    {
        public static void Setcanciones(EntityTypeBuilder <Canciones> ccancion)
        {
            ccancion.Property(x => x.Titulo).HasMaxLength(2);

        }
    }
}
