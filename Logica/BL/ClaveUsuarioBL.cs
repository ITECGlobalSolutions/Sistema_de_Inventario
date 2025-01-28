using Entidades.Modelos;
using Datos.Nucleo;
using MathNet.Numerics.Integration;

namespace Logica.BL
{
    public class ClaveUsuarioBL : Context<ClaveUsuarios>
    {
        public async Task<ClaveUsuarios?> BuscarClave(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<ClaveUsuarios?> BuscarClaveUsuario(int IdUsuario)
        {
            return await Task.FromResult(GET_ALL().Result.Where(x => x.IdUsuario == IdUsuario || x.Estado == true).FirstOrDefault());
        }
        public async Task<IEnumerable<ClaveUsuarios>> ListaClave()
        {
            return await GET_ALL();
        }
        public async Task<ClaveUsuarios?> GuardarClave(ClaveUsuarios claveUsuarios)
        {
            return await INSERT(claveUsuarios);
        }
        public async Task<ClaveUsuarios?> ModificarClave(ClaveUsuarios claveUsuarios)
        {
            await UPDATE(claveUsuarios);
            return await GET_BYID(claveUsuarios.Id);
        }
    }
}
