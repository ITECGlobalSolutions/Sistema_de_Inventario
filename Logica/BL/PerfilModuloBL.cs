using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class PerfilModuloBL : Context<PerfilModulo>
    {
        public async Task<PerfilModulo?> BuscarPerfilModulo(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<PerfilModulo>> ListaPerfilModulo()
        {
            return await GET_ALL();
        }
        public async Task<PerfilModulo?> GuardarPerfilModulo(PerfilModulo perfilModulo)
        {
            return await INSERT(perfilModulo);
        }
        public async Task<PerfilModulo?> ModificarPerfilModulo(PerfilModulo perfilModulo)
        {
            await UPDATE(perfilModulo);
            return await GET_BYID(perfilModulo.Id);
        }
    }
}
