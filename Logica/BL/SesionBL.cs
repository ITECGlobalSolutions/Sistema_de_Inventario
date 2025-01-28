using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class SesionBL : Context<Sesion>
    {
        public async Task<Sesion?> Buscarsesion(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<Sesion>> Listasesion()
        {
            return await GET_ALL();
        }
        public async Task<Sesion?> Guardarsesion(Sesion sesion)
        {
            return await INSERT(sesion);
        }
        public async Task<Sesion?> Modificarsesion(Sesion sesion)
        {
            await UPDATE(sesion);
            return await GET_BYID(sesion.Id);
        }
    }
}
