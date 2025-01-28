using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class PerfilBL:Context<Perfil>
    {
        public async Task<Perfil?> BuscarPerfil(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<Perfil>> ListaPerfil()
        {
            return await GET_ALL();
        }
        public async Task<Perfil?> GuardarPerfil(Perfil perfil)
        {
            return await INSERT(perfil);
        }
        public async Task<Perfil?> ModificarPerfil(Perfil perfil)
        {
            await UPDATE(perfil);
            return await GET_BYID(perfil.Id);
        }
    }
}
